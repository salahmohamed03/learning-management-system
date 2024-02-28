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
    public partial class ClassesPanel : UserControl
    {
        private ControlsService _nav;
        private ClassService _cl;
        private StudentService _st;
        private ProfessorService _pf;
        List<Class> searchResult = new List<Class>();
        public ClassesPanel(ControlsService nav, ClassService cl, StudentService st, ProfessorService pf)
        {
            InitializeComponent();
            _nav = nav;
            _cl = cl;
            _st = st;
            _pf = pf;
            initializeTable();
        }

        public void initializeTable()
        {
            ProfesorsTable.Rows.Clear();
            var Classes = _cl.GetAll();
            this.searchResult = Classes;
            //var students = _st.AllClassStudents(selectedClass.code);
            for (int i = 0; i < Classes.Count; i++)
            {
                ProfesorsTable.Rows.Add(new object[]
                {
                    $"{this.searchResult[i].name}" ,$"{this.searchResult[i].hall}" , $"{this.searchResult[i].time}"
                });
            }
        }

        private void ClassesPanel_Load(object sender, EventArgs e)
        {

        }

        private void ProfesorsTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            vScrollBar1.Maximum = ProfesorsTable.RowCount;
        }

        private void ProfesorsTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            vScrollBar1.Maximum = ProfesorsTable.RowCount;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            ProfesorsTable.FirstDisplayedScrollingRowIndex = ProfesorsTable.Rows[e.OldValue].Index;
        }

        private void ProfesorsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selcted = this.searchResult[e.RowIndex];
            _nav.Display(_nav.classProfilePanel, this.searchResult[e.RowIndex]);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }
    }
}
