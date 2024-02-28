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
    public partial class EditProf : Form
    {
        private ControlsService _nav;
        private StudentService _st;
        private ProfessorService _pf;
        private ClassService _cl;
        private Professor toEdit;
        public EditProf(
 StudentService st
, ControlsService nav
, ClassService cl
, ProfessorService pf,
Professor toEdit)
        {
            InitializeComponent();
            _st = st;
            _nav = nav;
            _cl = cl;
            _pf = pf;
            this.toEdit = toEdit;
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            firstName.Text = toEdit.firstName;
            lastName.Text = toEdit.lastName;
            email.Text = toEdit.email;
            phone.Text = toEdit.phone;
        }
        private void addButt_Click(object sender, EventArgs e)
        {
            if (firstName.Text.Length == 0)
            {
                MessageBox.Show("first name is required");
                return;
            }
            toEdit.firstName = firstName.Text;
            toEdit.lastName = lastName.Text;
            toEdit.email = email.Text;
            toEdit.phone = phone.Text;
            _pf.Update(toEdit);
            _nav.Display(_nav.professorProfilePanel, toEdit);
            Close();
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
