using Microsoft.IdentityModel.Tokens;
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
    public partial class NewClass : Form
    {
        private ControlsService _nav;
        private StudentService _st;
        private ProfessorService _pf;
        private AccountManager _ac;
        private ClassService _cl;
        public NewClass(
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
            if (codeInput.Text.IsNullOrEmpty() && timeInput.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Some data is required");
                return;
            }
            var newClass = new Class()
            {
                code = codeInput.Text,
                hall = hallInput.Text,
                name = nameInput.Text,
                time = int.Parse(timeInput.Text),
            };
            bool Result = _cl.Add(newClass);
            if (!Result)
            {
                MessageBox.Show("The code is already exist");
                return;
            }
            _nav.Display(_nav.controlPanel);
            Close();
        }

        private void timeInput_TextChanged(object sender, EventArgs e)
        {
            if (!char.IsAsciiDigit(timeInput.Text.LastOrDefault()))
            {
                timeInput.Text.Remove(Text.Length - 1);
            }
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
