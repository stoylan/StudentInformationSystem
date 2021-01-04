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
           /* Database _vt = new Database();

            if (_vt.checkConnect() == true)
            {
                label1.Text = "Connected Database.";
            }

            else
            {
                label1.Text = "Can't Connect Database";
            }*/


        }
    }
}
