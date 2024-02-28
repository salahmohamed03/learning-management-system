using Learning_Managment_System;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.panels
{
    public partial class ProfessorProfilePanel : UserControl
    {
        private ControlsService _nav;
        private ClassService _cl;
        private StudentService _st;
        private ProfessorService _pf;
        public static Professor? selectedProfessor;
        List<Class> ProfessorsClaasses = new List<Class>();
        public ProfessorProfilePanel(ControlsService nav, ClassService cl, StudentService st, ProfessorService pf)
        {
            InitializeComponent();
            _nav = nav;
            _cl = cl;
            _st = st;
            _pf = pf;
            List<Class> ProfessorsClaasses = new List<Class>();
        }

        private void ProfessorProfilePanel_Load(object sender, EventArgs e)
        {

        }
        public void InitalaizeTable()
        {
            StudentsTable.Rows.Clear();
            if (selectedProfessor != null)
            {
                profName.Text = $" {selectedProfessor.firstName} {selectedProfessor.lastName}";
                profTitle.Text = $"{selectedProfessor.title}";
                profID.Text = $"{selectedProfessor.id}";
                profAge.Text = $"{selectedProfessor.age}";
                profEmail.Text = $"{selectedProfessor.email}";
                profPhone.Text = $"{selectedProfessor.phone}";
                addCourse.Enabled = false;
                var stClasses = _cl.GetProfClasses(selectedProfessor);
                var classes = _cl.GetAll();
                comboBox1.Items.Clear();
                stClasses.ForEach(x => classes.Remove(x));
                classes.ForEach(x => comboBox1.Items.Add(x.code));
            }
            this.ProfessorsClaasses = _cl.GetProfClasses(selectedProfessor);
            for (int i = 0; i < this.ProfessorsClaasses.Count; i++)
            {
                StudentsTable.Rows.Add(new object[]
                {
                    $"{this.ProfessorsClaasses[i].name}"
                });
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void StudentsTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            vScrollBar1.Maximum = StudentsTable.RowCount;
        }

        private void StudentsTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            vScrollBar1.Maximum = StudentsTable.RowCount;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            StudentsTable.FirstDisplayedScrollingRowIndex = StudentsTable.Rows[e.OldValue].Index;
        }

        private void profTitle_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            new EditProf(_st, _nav, _cl, _pf, selectedProfessor).Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            _pf.Remove(selectedProfessor);
            _nav.Display(_nav.studentsPanel);
            MessageBox.Show($"professor {selectedProfessor.firstName + selectedProfessor.lastName} is deleted");
        }

        private void addCourse_Click(object sender, EventArgs e)
        {
            addCourse.Enabled = false;
            comboBox1.Text = string.Empty;
            _pf.AssignToClass(selectedProfessor, comboBox1.SelectedItem.ToString());
            MessageBox.Show($"{selectedProfessor.firstName} {selectedProfessor.lastName} assigned to class {comboBox1.SelectedItem}");
            _nav.Display(_nav.professorProfilePanel, selectedProfessor);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            addCourse.Enabled = true;
        }
        private void StudentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selcted = this.ProfessorsClaasses[e.RowIndex];
            _nav.Display(_nav.classProfilePanel, this.ProfessorsClaasses[e.RowIndex]);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void profAge_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void profID_Click(object sender, EventArgs e)
        {

        }
    }
}
