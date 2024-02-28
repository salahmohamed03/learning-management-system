using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models;
using System.Linq;
using WinFormsApp1.Data;

namespace SchoolManagementSystem.Services
{
    public class StudentService
    {
        private AppDbContext _db;
        private AccountManager _ac;
        public StudentService(AppDbContext db, AccountManager ac)
        {
            _db = db;
            _ac = ac;
        }
        public bool Add(Student member)
        {
            member.userId = _ac.admin.id;
            if (member is null) { return false; }
            _db.Students.Add(member);
            _db.SaveChanges();
            return true;
        }
        public bool Add(List<Student> Students)
        {
            Students.ForEach(x => x.userId = _ac.admin.id);
            if (Students is null) { return false; }
            _db.Students.AddRange(Students);
            _db.SaveChanges();
            return true;
        }
        public bool Update(Student member)
        {
            var exist = _db.Students.FirstOrDefault(x => x.id == member.id);
            if (exist is null) return false;
            _db.Students.Update(member);
            _db.SaveChanges();
            return true;
        }
        public bool Remove(Student member)
        {
            if (member is null) { return false; }
            _db.Students.Remove(member);
            var classesAssigned = _db.StudentClasses.Where(c => c.studentId == member.id).ToList();
            _db.StudentClasses.RemoveRange(classesAssigned);
            _db.SaveChanges();
            return true;
        }
        public bool Remove(string firstName, string lastName)
        {
            var member = _db.Students.FirstOrDefault(x => x.firstName == firstName && x.lastName == lastName && x.userId == _ac.admin.id);
            if (member is null) return false;
            _db.Students.Remove(member);
            var classesAssigned = _db.StudentClasses.Where(c => c.studentId == member.id).ToList();
            _db.StudentClasses.RemoveRange(classesAssigned);
            _db.SaveChanges();
            return true;
        }
        public List<Student> GetBy(Filter filter)
        {
            var Result = _db.Students.Where(x => x.grade > filter.above && x.grade < filter.below).ToList();
            if (filter.firstName is not null)
            {
                var subResult = _db.Students.Where(x => x.firstName.Contains(filter.firstName)).ToList();
                Result = Result.Intersect(subResult).ToList();
            }
            if (filter.lastName is not null)
            {
                var subResult = _db.Students.Where(x => x.lastName.Contains(filter.lastName)).ToList();
                Result = Result.Intersect(subResult).ToList();
            }
            var curAccount = _db.Students.Where(x => x.userId == _ac.admin.id).ToList();
            Result = Result.Intersect(curAccount).ToList();
            return Result;
        }
        public List<Student> GetAll()
        {
            var Students = _db.Students.Where(x => x.userId == _ac.admin.id).ToList();
            return Students;
        }
        public void RemoveAll()
        {
            _db.Database.ExecuteSqlRaw("TRUNCATE TABLE [Students]");
            _db.Database.ExecuteSqlRaw("TRUNCATE TABLE [StudentClasses]");
        }
        public bool AssignToClass(Student member, string classCode)
        {
            bool memberResult = _db.Students.Contains(member);
            bool codeResult = _db.classes.FirstOrDefault(x => x.code == classCode && x.userId == _ac.admin.id) is not null;

            if (!memberResult || !codeResult)
                return false;

            var assignment = new StudentClass()
            {
                studentId = member.id,
                classCode = classCode,
                userId = _ac.admin.id
            };
            _db.StudentClasses.Add(assignment);
            _db.SaveChanges();
            return true;
        }
        public List<Student> AllClassStudents(string classCode)
        {
            var _class = _db.classes.FirstOrDefault(x => x.code == classCode && x.userId == _ac.admin.id);
            if (_class is null)
                return new List<Student>();
            var Ids = _db.StudentClasses.Where(x => x.classCode == classCode && x.userId == _ac.admin.id).ToList();
            var Students = new List<Student>();
            foreach (var id in Ids)
            {
                Students.Add(_db.Students.First(x => x.id == id.studentId));
            }
            return Students;
        }
    }
}
