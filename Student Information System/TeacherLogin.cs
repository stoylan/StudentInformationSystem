using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_System
{
    public partial class TeacherLogin : Form
    {
        public TeacherLogin()
        {
            InitializeComponent();
            label1.Visible = false;
            usernameText.BackColor = System.Drawing.Color.Transparent;
            passwordText.BackColor = System.Drawing.Color.Transparent;
            LogoPic.BackColor = System.Drawing.Color.Transparent;
            backButton.BackColor = System.Drawing.Color.Transparent;
            loginButton.BackColor = System.Drawing.Color.Transparent;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            startScreen.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            verifyLogin vl = new verifyLogin();
            label1.Visible = true;

            bool checklog = vl.verifyLogteacher(UsernameBox.Text, PasswordBox.Text);
            if (checklog)
            {
                label1.Text = "succesfully";
                int id = vl.TeacherID;
                String username = UsernameBox.Text;

                TeacherScreen ts = new TeacherScreen()
                {
                    teacherId = id
                };


                this.Close();
                ts.Show();
            }
            else
                label1.Text = "You entered wrong username or password. Please try again.";
            
           
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.UseSystemPasswordChar = true;
        }
    }
}
