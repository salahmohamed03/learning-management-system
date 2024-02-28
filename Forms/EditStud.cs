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
    public partial class EditStud : Form
    {
        private ControlsService _nav;
        private StudentService _st;
        private ProfessorService _pf;
        private ClassService _cl;
        private Student toEdit;
        public EditStud(
         StudentService st
        , ControlsService nav
        , ClassService cl
        , ProfessorService pf,
Student toEdit)
        {
            _st = st;
            _nav = nav;
            _cl = cl;
            _pf = pf;
            InitializeComponent();
            this.toEdit = toEdit;
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            firstNameInput.Text = toEdit.firstName;
            lastNameInput.Text = toEdit.lastName;
            emailInput.Text = toEdit.email;
            phoneInput.Text = toEdit.phone;
            ageInput.Text = toEdit.age.ToString();
            textBox1.Text = toEdit.grade.ToString();
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

            toEdit.firstName = firstNameInput.Text;
            toEdit.lastName = lastNameInput.Text;
            if(ageInput.Text.Length != 0)
                toEdit.age = int.Parse(ageInput.Text);
            toEdit.email = emailInput.Text;
            toEdit.phone = phoneInput.Text;
            toEdit.grade = int.Parse(textBox1.Text);
            _st.Update(toEdit);
            _nav.Display(_nav.studentProfilePanel,toEdit);
            Close();
        }

        private void ageInput_TextChanged(object sender, EventArgs e)
        {
            if (!char.IsAsciiDigit(ageInput.Text.LastOrDefault()))
            {
                if (ageInput.Text.Length > 0)
                    ageInput.Text.Remove(Text.Length - 1);
            }
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!char.IsAsciiDigit(ageInput.Text.LastOrDefault()))
            {
                if (textBox1.Text.Length > 0)
                    textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
    }
}
