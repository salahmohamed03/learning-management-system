using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Data;

namespace SchoolManagementSystem.Services
{
    public class AccountManager
    {
        private AppDbContext _db;
        public bool isSignedIn = false;
        public Admin? admin;
        public AccountManager(AppDbContext db) { 
            _db = db;
        }
        public bool SignIn(string userName, string password)
        {
            var _admin = _db.admins.FirstOrDefault(x => x.userName == userName && x.password == password);
            if (_admin is null) return false;
            isSignedIn = true;
            admin = _admin;
            return true;
        }
        public bool SignUp(string userName, string password)
        {
            var test = _db.admins.FirstOrDefault(x => x.userName == userName);
            var exist = test is not null;
            if (exist) return false;
            var newAdmin = new Admin()
            {
                userName = userName,
                password = password
            };
            _db.admins.Add(newAdmin);
            _db.SaveChanges();
            return true;
        }
        public void signOut()
        {
            admin = null;
            isSignedIn = false;
        }
        public void RemoveAll()
        {
            _db.Database.ExecuteSqlRaw("TRUNCATE TABLE [admins]");
            _db.SaveChanges();
        }
    }
}
