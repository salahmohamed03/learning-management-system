using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Data;

namespace SchoolManagementSystem.Services
{
    public class ClassService
    {
        private AppDbContext _db;
        private AccountManager _ac;
        private StudentService _st;
        public ClassService(AppDbContext db, AccountManager ac,StudentService st)
        {
            _db = db;
            _ac = ac;
            _st = st;
        }
        public bool Add(Class _class)
        {
            _class.userId = _ac.admin.id;
            bool exist = _db.classes.FirstOrDefault(x => x.code == _class.code && x.userId == _ac.admin.id) is not null;
            if (_class is null || exist) return false;
            _db.classes.Add(_class);
            _db.SaveChanges();
            return true;
        }        
        public bool Update(Class _class)
        {
            var exist = _db.classes.FirstOrDefault(x => x.Id == _class.Id);
            if (exist is null) return false;
            _db.classes.Update(_class);
            _db.SaveChanges();
            return true;
        }
        public bool Remove(Class _class)
        {
            if (_class is null) return false;
            _db.classes.Remove(_class);
            var assignedStudents = _db.StudentClasses.Where(x => x.classCode == _class.code && x.userId == _ac.admin.id).ToList();
            var assignedProfessors = _db.professorClasses.Where(x => x.classCode == _class.code && x.userId == _ac.admin.id).ToList();
            _db.StudentClasses.RemoveRange(assignedStudents);
            _db.professorClasses.RemoveRange(assignedProfessors);
            _db.SaveChanges();
            return true;
        }
        public List<Class> GetAll()
        {
            return _db.classes.Where(x=> x.userId == _ac.admin.id).ToList();
        }
        public void RemoveAll()
        {
            _db.Database.ExecuteSqlRaw("TRUNCATE TABLE [classes]");
        }
        public List<Class> GetStudentClasses(Student student)
        {
            bool notFound = !_db.Students.Contains(student);
            if (student is null || notFound) return new List<Class>();
            var classesCodes = _db.StudentClasses.Where(x => x.studentId ==  student.id).ToList();
            var codes = new HashSet<string>();
            foreach( var classesCode in classesCodes)
            {
                codes.Add(classesCode.classCode);
            }
            var classes = new List<Class>();    
            foreach(var code in codes)
            {
                classes.Add(_db.classes.First(x => x.code == code));
            }
            return classes;
        }
        public List<Class> GetProfClasses(Professor professor)
        {
            bool notFound = !_db.professors.Contains(professor);
            if (professor is null || notFound) return new List<Class>();
            var classesCodes = _db.professorClasses.Where(x => x.profId == professor.id).ToList();
            var codes = new HashSet<string>();
            foreach (var classesCode in classesCodes)
            {
                codes.Add(classesCode.classCode);
            }
            var classes = new List<Class>();
            foreach (var code in codes)
            {
                classes.Add(_db.classes.First(x => x.code == code));
            }
            return classes;
        }
        public bool ExportToCSV(string classCode,string path)
        {
            var students = _st.AllClassStudents(classCode);
            if (students.IsNullOrEmpty()) return false;
            var sheet = new List<string>
            {
                "Id,Name,Age,Phone,Email,Grade"
            };
            foreach (var student in students)
            {
                StringBuilder row = new StringBuilder();
                row.Append($"{student.id},{student.firstName + " " + student.lastName}" +
                    $",{student.age},{student.phone},{student.email},{student.grade}");
                sheet.Add(row.ToString());
            }
            string file = $@"{path}\{classCode}.csv";
            File.WriteAllLines(file, sheet);
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(file)
            {
                UseShellExecute = true
            };
            p.Start();
            return true;
        }
    }
}
