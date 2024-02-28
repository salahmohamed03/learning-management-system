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
    public partial class newStud : Form
    {
        private ControlsService _nav;
        private StudentService _st;
        private ProfessorService _pf;
        private AccountManager _ac;
        private ClassService _cl;
        public newStud(
         StudentService st
        , AccountManager accountManager
        , ControlsService nav
        , ClassService cl
        , ProfessorService pf)
        {
            _st = st;
            _nav = nav;
            _ac = accountManager;
            _cl = cl;
            _pf = pf;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addButt_Click(object sender, EventArgs e)
        {
            if (firstName.Text.Length == 0)
            {
                MessageBox.Show("first name is required");
                return;
            }
            var studnet = new Student()
            {
                firstName = firstNameInput.Text,
                lastName = lastNameInput.Text,
                age = int.Parse(ageInput.Text),
                email = emailInput.Text,
                phone = phoneInput.Text,
            };
            _st.Add(studnet);
            _nav.Display(_nav.controlPanel);
            Close();
        }

        private void ageInput_TextChanged(object sender, EventArgs e)
        {
            if (!char.IsAsciiDigit(ageInput.Text.LastOrDefault()))
            {
                if(ageInput.Text.Length > 0)
                    ageInput.Text.Remove(Text.Length - 1);
            }
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
