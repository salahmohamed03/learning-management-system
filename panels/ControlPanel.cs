using Microsoft.IdentityModel.Tokens;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.panels;
using SchoolManagementSystem.Services;


namespace Learning_Managment_System
{
    public partial class ControlPanel : UserControl
    {
        private ControlsService _nav;
        private StudentService _st;
        private ProfessorService _pf;
        private AccountManager _ac;
        private ClassService _cl;
        public ControlPanel(
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

        public void InitializeData()
        {
            exportButt.Enabled = false;
            importButt.Enabled = false;
            pickClass.Items.Clear();
            var classes = _cl.GetAll();
            classes.ForEach(x => pickClass.Items.Add(x.code));
        }
        private void newStudButt_Click(object sender, EventArgs e)
        {
            var Student = new newStud(_st, _ac, _nav, _cl, _pf);
            Student.ShowDialog();
        }

        private void newClassButt_Click(object sender, EventArgs e)
        {
            var Student = new NewClass(_st, _ac, _nav, _cl, _pf);
            Student.ShowDialog();
        }

        private void newProffButt_Click(object sender, EventArgs e)
        {
            var Student = new newProf(_st, _ac, _nav, _cl, _pf);
            Student.ShowDialog();
        }

        private void pickClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            exportButt.Enabled = true;
            importButt.Enabled = true;
        }
        private void exportButt_Click(object sender, EventArgs e)
        {
            exportButt.Enabled = false;
            importButt.Enabled = false;
            var di = new FolderBrowserDialog();
            di.ShowDialog();
            if (_cl.ExportToCSV((string)pickClass.SelectedItem, di.SelectedPath))
            {
                MessageBox.Show("File exported successfully!");
            }
            exportButt.Enabled = true;
            importButt.Enabled = true;
        }

        private void importButt_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "csv File|*.csv";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                string[] lines = System.IO.File.ReadAllLines(opf.FileName);
                string[][] data = new string[lines.Length][];
                int i = 0;
                foreach (string line in lines)
                {
                    data[i] = line.Split(',');
                    i++;
                }
                var dd = data.ToList().ToList();
                ImportCSV(dd);
            }
        }
        private void ImportCSV(List<string[]> csv)
        {
            if (csv.IsNullOrEmpty())
            {
                MessageBox.Show("File imported successfully!");
                return;
            }
            //Name,Age,Phone,Email,Grade
            foreach (var x in csv)
            {
                if (csv[0] == x) continue;
                if (x.Length == 1) continue;
                var name = x[1].Split(' ').ToList();
                if (name.Count == 1) { name.Add(string.Empty); };
                var student = new Student()
                {
                    firstName = name[0],
                    lastName = name[1],
                    age = int.Parse(x[2]),
                    phone = x[3],
                    email = x[4],
                    grade = int.Parse(x[5])
                };
                _st.Add(student);
                _st.AssignToClass(student, (string)pickClass.SelectedItem);
            }
        }
    }
}
