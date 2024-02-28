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
    public partial class ProfessorsPanel : UserControl
    {
        private ControlsService _nav;
        private ProfessorService _pf;
        List<Professor> searchResult = new List<Professor>();
        public ProfessorsPanel(ControlsService nav, ProfessorService pf)
        {
            InitializeComponent();
            _nav = nav;
            _pf = pf;
            List<Professor> professors = new List<Professor>();
            initializeTable();
        }

        public void initializeTable()
        {
            ProfesorsTable.Rows.Clear();
            var professors = _pf.GetAll();
            this.searchResult = professors;
            //var students = _st.AllClassStudents(selectedClass.code);
            for (int i = 0; i < professors.Count; i++)
            {
                ProfesorsTable.Rows.Add(new object[]
                {
                    $"{this.searchResult[i].firstName} {this.searchResult[i].lastName}" ,$"{this.searchResult[i].id}" , $"{this.searchResult[i].email}"
                });
            }
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            ProfesorsTable.FirstDisplayedScrollingRowIndex = ProfesorsTable.Rows[e.OldValue].Index;
        }

        private void StudentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _nav.Display(_nav.professorProfilePanel, this.searchResult[e.RowIndex]);
        }

        private void StudentsTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            vScrollBar1.Maximum = ProfesorsTable.RowCount;
        }

        private void StudentsTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            vScrollBar1.Maximum = ProfesorsTable.RowCount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfesorsTable.Rows.Clear();
            string fullName = searchBar.Text;
            Filter filter = new Filter();
            filter.SetName(fullName);
            this.searchResult = _pf.GetBy(filter);
            for (int i = 0; i < searchResult.Count; i++)
            {
                ProfesorsTable.Rows.Add(new object[]
                {
                    $"{searchResult[i].firstName} {searchResult[i].lastName}" ,$"{searchResult[i].id}",$"{searchResult[i].email}"
                });
            }
        }

        private void ProfessorsPanel_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentsTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
