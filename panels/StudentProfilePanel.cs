using Learning_Managment_System;
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

namespace SchoolManagementSystem.panels
{
    public partial class StudentProfilePanel : UserControl
    {
        private ControlsService _nav;
        private ClassService _cl;
        private StudentService _st;
        private ProfessorService _pf;
        public static Student? selectedStudent;
        List<Class> StudentClasses = new List<Class>();


        public StudentProfilePanel(ControlsService nav, ClassService cl, StudentService st, ProfessorService pf)
        {
            InitializeComponent();
            _nav = nav;
            _cl = cl;
            _st = st;
            _pf = pf;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                if (selectedStudent != null)
                {
                    stuName.Text = $" {selectedStudent.firstName} {selectedStudent.lastName}";
                    stuAge.Text = $"{selectedStudent.age}";
                    stuEmail.Text = $"{selectedStudent.email}";
                    stuPhone.Text = $"{selectedStudent.phone}";
                    stuGrade.Text = $"{selectedStudent.grade}";
                    stuID.Text = $"{selectedStudent.id}";
                }
            }
        }
        public void InitalaizeTable()
        {
            StudentsTable.Rows.Clear();
            if (selectedStudent != null)
            {
                stuName.Text = $" {selectedStudent.firstName} {selectedStudent.lastName}";
                stuAge.Text = $"{selectedStudent.age}";
                stuEmail.Text = $"{selectedStudent.email}";
                stuPhone.Text = $"{selectedStudent.phone}";
                stuGrade.Text = $"{selectedStudent.grade}";
                stuID.Text = $"{selectedStudent.id}";

                addCourse.Enabled = false;
                var stClasses = _cl.GetStudentClasses(selectedStudent);
                var classes = _cl.GetAll();
                comboBox1.Items.Clear();
                stClasses.ForEach(x => classes.Remove(x));
                classes.ForEach(x => comboBox1.Items.Add(x.code));
            }
            this.StudentClasses = _cl.GetStudentClasses(selectedStudent);
            for (int i = 0; i < this.StudentClasses.Count; i++)
            {
                StudentsTable.Rows.Add(new object[]
                {
                    $"{this.StudentClasses[i].name}"
                });
            }
        }

        private void StudentProfilePanel_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selcted = this.StudentClasses[e.RowIndex];
            _nav.Display(_nav.classProfilePanel, this.StudentClasses[e.RowIndex]);
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

        private void Edit_Click(object sender, EventArgs e)
        {
            new EditStud(_st, _nav, _cl, _pf, selectedStudent).Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            _st.Remove(selectedStudent);
            _nav.Display(_nav.studentsPanel);
            MessageBox.Show($"student {selectedStudent.firstName + selectedStudent.lastName} is deleted");
        }

        private void addCourse_Click(object sender, EventArgs e)
        {
            addCourse.Enabled = false;
            comboBox1.Text = string.Empty;
            _st.AssignToClass(selectedStudent,comboBox1.SelectedItem.ToString());
            MessageBox.Show($"{selectedStudent.firstName} {selectedStudent.lastName} assigned to class {comboBox1.SelectedItem}");
            _nav.Display(_nav.studentProfilePanel, selectedStudent);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            addCourse.Enabled = true;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void stuAge_Click(object sender, EventArgs e)
        {

        }
    }
}
