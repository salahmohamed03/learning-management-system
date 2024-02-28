using SchoolManagementSystem.Models;
using SchoolManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.panels
{
    public partial class StudentsPanel : UserControl
    {
        private ControlsService _nav;
        private StudentService _st;
        List<Student> searchResult = new List<Student>();
        public StudentsPanel(ControlsService nav, StudentService st)
        {
            InitializeComponent();
            _nav = nav;
            _st = st;
            initializeTable();
        }

        public void initializeTable()
        {
            StudentsTable.Rows.Clear();
            var students = _st.GetAll();
            this.searchResult = students;
            //var students = _st.AllClassStudents(selectedClass.code);
            for (int i = 0; i < students.Count; i++)
            {
                StudentsTable.Rows.Add(new object[]
                {
                    $"{this.searchResult[i].firstName} {this.searchResult[i].lastName}" ,$"{this.searchResult[i].id}" , $"{this.searchResult[i].grade}"
                });
            }
        }

        private void StudentsTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            vScrollBar1.Maximum = StudentsTable.RowCount;
        }

        private void StudentsTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            vScrollBar1.Maximum = StudentsTable.RowCount;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            StudentsTable.FirstDisplayedScrollingRowIndex = StudentsTable.Rows[e.OldValue].Index;
        }

        private void StudentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _nav.Display(_nav.studentProfilePanel, this.searchResult[e.RowIndex]);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.searchResult.Clear();
            StudentsTable.Rows.Clear();
            string fullName = textBox1.Text;
            Filter filter = new Filter();
            filter.SetName(fullName);
            this.searchResult = _st.GetBy(filter);

            for (int i = 0; i < searchResult.Count; i++)
            {
                StudentsTable.Rows.Add(new object[]
                {
                    $"{this.searchResult[i].firstName} {this.searchResult[i].lastName}" ,$"{this.searchResult[i].id}",$"{this.searchResult[i].grade}"
                });
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
