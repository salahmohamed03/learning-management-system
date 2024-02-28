using DSproject;
using Learning_Managment_System;
using Microsoft.Extensions.DependencyInjection;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Services;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            // Services 
            services.AddSingleton<AppDbContext>();
            services.AddSingleton<Form1>();
            services.AddTransient<StudentService>();
            services.AddTransient<ProfessorService>();
            services.AddSingleton<ControlsService>();
            services.AddSingleton<AccountManager>();
            services.AddTransient<ClassService>();

            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            var _ac = serviceProvider.GetRequiredService<AccountManager>();
            var _cl = serviceProvider.GetRequiredService<ClassService>();
            var _nav = serviceProvider.GetRequiredService<ControlsService>();
            var _pf = serviceProvider.GetRequiredService<ProfessorService>();
            var _st = serviceProvider.GetRequiredService<StudentService>();

            Application.Run(new SignIn(_st, _ac, _nav, _cl, _pf));
            //var admin = new Admin()
            //{
            //    userName = "SBME",
            //    password = "123"
            //};
            //_ac.SignIn(admin.userName, admin.password);
            //Application.Run(new Form1(_st, _ac, _nav, _cl, _pf));
        }
    }
}


