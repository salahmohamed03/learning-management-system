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
using WinFormsApp1;

namespace SchoolManagementSystem.panels
{
    public partial class ClassProfilePanel : UserControl
    {
        private ControlsService _nav;
        private ClassService _cl;
        private StudentService _st;
        private ProfessorService _pf;
        public static Class? selectedClass;
        List<Student> searchResut = new List<Student>();
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                if (selectedClass is null) return;
                InitalaizeTable();
            }
        }
        public ClassProfilePanel(ControlsService nav, ClassService cl, StudentService st, ProfessorService pf)
        {
            InitializeComponent();
            _nav = nav;
            _cl = cl;
            _st = st;
            _pf = pf;
            List<Student> ClassStudents = new List<Student>();
        }
        //sample data   
        public void InitalaizeTable()
        {
            StudentsTable.Rows.Clear();
            hallLabel.Text = selectedClass.hall;
            TimeLabel.Text = $"{selectedClass.time}";
            codeLabel.Text = selectedClass.code;
            NameLabel.Text = selectedClass.name;
            label7.Text = string.Empty;
            var profs = _pf.AllClassProfessors(selectedClass.code);
            for(int i = 0; i < 3; i++)
            {
                if (profs.Count == i) break;
                label7.Text += ($"{profs[i].firstName} {profs[i].lastName}\n");
            }
            //if(profs.Count == 1)
            //{ 
            //    label7.Text = $"{profs[0].firstName} {profs[0].lastName}"; 
            //}
            //else if(profs.Count == 2)
            //{
            //    label7.Text = $"{profs[0].firstName} {profs[0].lastName}, " +
            //        $"{profs[1].firstName} {profs[1].lastName}";
            //}
            if (selectedClass is null) return;
            var students = _st.AllClassStudents(selectedClass.code);
            this.searchResut = students;
            for (int i = 0; i < students.Count; i++)
            {
                StudentsTable.Rows.Add(new object[]
                {
                    $"{students[i].firstName} {students[i].lastName}" ,$"{students[i].id}",$"{students[i].grade}"
                });
            }
        }

        //public void LoadScreen()
        //{
        //    InitalaizeTable();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            _nav.Display(_nav.professorsPanel);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _nav.Display(_nav.studentProfilePanel, this.searchResut[e.RowIndex]);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            StudentsTable.FirstDisplayedScrollingRowIndex = StudentsTable.Rows[e.OldValue].Index;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (selectedClass is null) return;
            this.searchResut.Clear();
            StudentsTable.Rows.Clear();
            string fullName = textBox1.Text;
            Filter filter = new Filter();
            filter.SetName(fullName);
            filter.classCode = selectedClass.code;
            this.searchResut = _st.GetBy(filter).Intersect(_st.AllClassStudents(selectedClass.code)).ToList();

            for (int i = 0; i < searchResut.Count; i++)
            {
                StudentsTable.Rows.Add(new object[]
                {
                    $"{this.searchResut[i].firstName} {this.searchResut[i].lastName}" ,$"{this.searchResut[i].id}",$"{this.searchResut[i].grade}"
                });
            }

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            new EditClass(_st, _nav, _cl, _pf, selectedClass).Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            _cl.Remove(selectedClass);
            _nav.Display(_nav.classesPanel);
            MessageBox.Show($"class {selectedClass.name} is deleted");
        }
    }
}
