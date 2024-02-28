using SchoolManagementSystem.Models;
using SchoolManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_Managment_System
{
    public partial class newProf : Form
    {
        private ControlsService _nav;
        private StudentService _st;
        private ProfessorService _pf;
        private AccountManager _ac;
        private ClassService _cl;
        public newProf(
 StudentService st
, AccountManager accountManager
, ControlsService nav
, ClassService cl
, ProfessorService pf)
        {
            InitializeComponent();
            _st = st;
            _nav = nav;
            _ac = accountManager;
            _cl = cl;
            _pf = pf;
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            if (firstName.Text.Length == 0)
            {
                MessageBox.Show("first name is required");
                return;
            }
            var prof = new Professor()
            {
                firstName = firstName.Text,
                lastName = lastName.Text,
                email = email.Text,
                phone = phone.Text,
            };
            _pf.Add(prof);
            _nav.Display(_nav.controlPanel);
            Close();
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
