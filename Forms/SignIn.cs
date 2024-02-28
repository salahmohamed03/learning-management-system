using Learning_Managment_System;
using Microsoft.Extensions.DependencyInjection;
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

namespace DSproject
{

    public partial class SignIn : Form
    {
        private ControlsService _nav;
        private StudentService _st;
        private ProfessorService _pf;
        private AccountManager _ac;
        private ClassService _cl;
        private string userName;
        private string password;

        public SignIn(
         StudentService st
        , AccountManager ac
        , ControlsService nav
        , ClassService cl
        , ProfessorService pf)
        {
            InitializeComponent();
            _ac = ac;
            _cl = cl;
            _nav = nav;
            _st = st;
            _pf = pf;
            //RemoveDummyData();

        }
        private void RemoveDummyData()
        {
            _st.RemoveAll();
            _pf.RemoveAll();
            _cl.RemoveAll();
            _ac.RemoveAll();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             password = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             userName = textBox1.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new SignUP(_st, _ac, _nav, _cl, _pf).Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (_ac.SignIn(userName, password))
            {
                //launching el homepage b2a .. el message box is temporary 
                Hide();
                new Form1( _st,_ac,_nav,_cl,_pf).Show();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
