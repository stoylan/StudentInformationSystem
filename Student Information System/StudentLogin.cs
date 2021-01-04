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
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
            label1.Visible = false;
            usernameText.BackColor = System.Drawing.Color.Transparent;
            passwordText.BackColor = System.Drawing.Color.Transparent;
            LogoPic.BackColor = System.Drawing.Color.Transparent;
            backButton.BackColor = System.Drawing.Color.Transparent;
            loginButton.BackColor = System.Drawing.Color.Transparent;
            registerButton.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;

        }

     

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.UseSystemPasswordChar = true;
        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            startScreen.Show();
            this.Close();
            
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            verifyLogin vl = new verifyLogin();

            bool checklog = vl.verifyLogstudent(UsernameBox.Text, PasswordBox.Text);

            if (checklog)
            {
                label1.Text = "succesfully";
                label1.ForeColor = System.Drawing.Color.LightGreen;
                label1.Visible = true;
                int id = vl.StudentID;
                String username = UsernameBox.Text;
                StudentScreen ss = new StudentScreen
                {
                    StudentID1 = id,
                    StudentUsername = username

                };

                this.Close();


                ss.Show();
            }
            else
            {
                label1.ForeColor = System.Drawing.Color.Red;
                label1.Visible = true;
                label1.Text = "You entered wrong username or password. Please try again.";
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Close();
            StudenRegister sl = new StudenRegister();
            sl.Show();

        }

        private void PasswordBox_TextChanged_1(object sender, EventArgs e)
        {
            PasswordBox.UseSystemPasswordChar = true;
        }
    }
}
