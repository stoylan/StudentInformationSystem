using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Student_Information_System
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            
            InitializeComponent();
            StudentLoginButton.BackColor = System.Drawing.Color.Transparent;
            TeacherLoginButton.BackColor = System.Drawing.Color.Transparent;
            LogoPic.BackColor = System.Drawing.Color.Transparent;
            
            

        }

        private void StudentLoginButton_Click(object sender, EventArgs e)
        {
            StudentLogin studentloginform = new StudentLogin();
            this.Hide();
            studentloginform.Show();

            

        }

        private void TeacherLoginButton_Click(object sender, EventArgs e)
        {
            TeacherLogin teacherLogin = new TeacherLogin();
            teacherLogin.Show();
            this.Hide();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
       


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "Date : " + DateTime.Now.ToLongDateString();
            label3.Text = "Time : " + DateTime.Now.ToLongTimeString();
        }
    }
}
