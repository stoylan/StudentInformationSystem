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
    public partial class UpdateInformation : Form
    {
        private int id;
        private string password;
        Database db = new Database();
        RegisterStudent rs = new RegisterStudent();

        public int Id { get => id; set => id = value; }

        public UpdateInformation()
        {
            InitializeComponent();
        }

        private void UpdateInformation_Load(object sender, EventArgs e)
        {
            warnText.BackColor = System.Drawing.Color.Transparent;
            emailError.BackColor = System.Drawing.Color.Transparent;
            emailError.ForeColor = System.Drawing.Color.Red;
            db.Connection.Open();
            db.Command.Connection = db.Connection;
            db.Command.CommandText = "Select Phoneno,Email,password,Username,Name,Surname FROM studentlog where ID ='"+Id+"'";

            db.Datareader = db.Command.ExecuteReader();

            db.Datareader.Read();
            phoneTextBox.Text = db.Datareader.GetValue(0).ToString();
            mailTextBox.Text = db.Datareader.GetValue(1).ToString();
            password = db.Datareader.GetValue(2).ToString();
            usernameTextBox.Text = db.Datareader.GetValue(3).ToString();
            nameTextBox.Text = db.Datareader.GetValue(4).ToString();
            surnameTextBox.Text = db.Datareader.GetValue(5).ToString();
            db.Connection.Close();



        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            emailError.Hide();
            warnText.Hide();
            bool control = true;
            bool emailCheck = rs.checkEmail(mailTextBox.Text);
            if (!(repasswordTextBox.Text.Equals(passwordTextBox.Text)))
            {
                warnText.Text = "The passwords you entered do not match.";
                warnText.ForeColor = System.Drawing.Color.Red;
                warnText.Show();
                control = false;
            }
            else if (!(password.Equals(passwordTextBox.Text)))
            {
                warnText.Text = "You entered a wrong password, please try again.";
                warnText.ForeColor = System.Drawing.Color.Red;
                warnText.Show();
                control = false;
            }
            if (!emailCheck)
            {
                control = false;
                emailError.Show();
                emailError.Text = "E-mail must be valid format. Like example@gmail.com";

            }

            if (control) {
                db.Connection.Open();
                db.Command.Connection = db.Connection;
                db.Command.CommandText = "update studentlog set Phoneno='" + float.Parse(phoneTextBox.Text) + "',Email='" + mailTextBox.Text + "',password='" + passwordTextBox.Text + "' where ID= '" + Id + "'";
                db.Command.ExecuteNonQuery();
                db.Connection.Close();
                warnText.Text = "Information updated succesfully";
                warnText.ForeColor = System.Drawing.Color.LawnGreen;
                warnText.Show();
            }
           
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void repasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            repasswordTextBox.UseSystemPasswordChar = true;
        }
    }
}
