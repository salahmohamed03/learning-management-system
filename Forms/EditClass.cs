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
    public partial class EditClass : Form
    {
        private ControlsService _nav;
        private StudentService _st;
        private ProfessorService _pf;
        private ClassService _cl;
        private Class toEdit;
        public EditClass(
 StudentService st
, ControlsService nav
, ClassService cl
, ProfessorService pf,
Class toEdit)
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
            codeInput.Text = toEdit.code;
            nameInput.Text = toEdit.name;
            hallInput.Text = toEdit.hall;
            timeInput.Text = toEdit.time.ToString();
        }
        private void timeInput_TextChanged(object sender, EventArgs e)
        {
            if (!char.IsAsciiDigit(timeInput.Text.LastOrDefault()))
            {
                if(timeInput.Text.Length > 0)
                    timeInput.Text.Remove(Text.Length - 1);
            }
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void EditBtn(object sender, EventArgs e)
        {
            if (codeInput.Text.IsNullOrEmpty() && timeInput.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Some data is required");
                return;
            }
            toEdit.code = codeInput.Text;
            toEdit.hall = hallInput.Text;
            toEdit.name = nameInput.Text;
            toEdit.time = int.Parse(timeInput.Text);
            
            bool Result = _cl.Update(toEdit);
            if (!Result)
            {
                MessageBox.Show("Some data is invalid");
                return;
            }
            _nav.Display(_nav.classProfilePanel, toEdit);
            Close();
        }
    }
}
