using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Student_Information_System
{
    public partial class StudenRegister : Form
    {
        Database db = new Database();
        RegisterStudent rs = new RegisterStudent();

        public StudenRegister()
        {
      
            InitializeComponent();
            nameText.BackColor = System.Drawing.Color.Transparent;
            surnameText.BackColor = System.Drawing.Color.Transparent;
            studentnoText.BackColor = System.Drawing.Color.Transparent;
            phoneText.BackColor = System.Drawing.Color.Transparent;
            emailText.BackColor = System.Drawing.Color.Transparent;
            userText.BackColor = System.Drawing.Color.Transparent;
            passwordText.BackColor = System.Drawing.Color.Transparent;
            repasswordText.BackColor = System.Drawing.Color.Transparent;
            mathematicCheck.BackColor = System.Drawing.Color.Transparent;
            physicCheck.BackColor = System.Drawing.Color.Transparent;
            englishCheck.BackColor = System.Drawing.Color.Transparent;
            germanCheck.BackColor = System.Drawing.Color.Transparent;
            biologyCheck.BackColor = System.Drawing.Color.Transparent;
            chemistryCheck.BackColor = System.Drawing.Color.Transparent;
            backButton.BackColor = System.Drawing.Color.Transparent;
            registerButton.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;
            LogoPic.BackColor = System.Drawing.Color.Transparent;
            usernameError.BackColor = System.Drawing.Color.Transparent;
            passwordErrorText.BackColor = System.Drawing.Color.Transparent;
            lessonErrorText.BackColor = System.Drawing.Color.Transparent;
            lessonErrorText.ForeColor = System.Drawing.Color.Red;
            passwordErrorText.ForeColor = System.Drawing.Color.Red;
            emailErrorText.ForeColor = System.Drawing.Color.Red;
            emailErrorText.BackColor = System.Drawing.Color.Transparent;

        }


        private void registerButton_Click(object sender, EventArgs e)
        {
            bool succesful = true;
            lessonErrorText.Hide();
            passwordErrorText.Hide();
            usernameError.Hide();
            emailErrorText.Hide();
            if (String.IsNullOrEmpty(usernameTextBox.Text) || String.IsNullOrEmpty(passwordTextBox.Text) || String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(surnameTextBox.Text) || String.IsNullOrEmpty(studentNoTextBox.Text) || String.IsNullOrEmpty(phoneNoBox.Text) || String.IsNullOrEmpty(emailTextBox.Text)) 
            {
                succesful = false;
                MessageBox.Show("You must fill all the information");

            }
            if (mathematicCheck.Checked == false && physicCheck.Checked == false && chemistryCheck.Checked == false && biologyCheck.Checked == false && germanCheck.Checked == false && englishCheck.Checked == false)
            {
                succesful = false;
                lessonErrorText.Show();
                lessonErrorText.Text = "You must select at least 1 course";
            }
            if(!(passwordTextBox.Text.Equals(repasswordTextBox.Text)))
            {
                succesful = false;
                passwordErrorText.Show();
                passwordErrorText.Text = "The passwords entered do not match.";
            }
            Regex regex = new Regex("^[a-zA-Z]+$");
            Regex regexNum = new Regex("^[0-9]+$");
            Regex regexPassword = new Regex("^[0-9a-zA-Z]+$");

            bool nameCheck = regex.IsMatch(nameTextBox.Text);
            bool surnameCheck = regex.IsMatch(surnameTextBox.Text);
            bool studentnoCheck = regexNum.IsMatch(studentNoTextBox.Text);
            bool phonenoCheck = regexNum.IsMatch(phoneNoBox.Text);
            bool passwordCheck = regexPassword.IsMatch(passwordTextBox.Text);
            bool emailCheck = rs.checkEmail(emailTextBox.Text);
            if (!passwordCheck)
            {
                succesful = false;
                passwordErrorText.Show();
                passwordErrorText.Text = "Password must be contain letter and number.";

            }
            if(passwordTextBox.Text.Length < 6)
            {
                succesful = false;
                passwordErrorText.Show();
                passwordErrorText.Text= "Password must contain at least 6 length.";
            }

            if (rs.chechUsername(usernameTextBox.Text))
            {
                succesful = false;
                usernameError.Show();
                usernameError.Text = "This username is used. Please try again different username";
            }

            if (!emailCheck)
            {
                succesful = false;
                emailErrorText.Show();
                emailErrorText.Text = "E-mail must be valid format. Like example@gmail.com";

            }


       
            if (succesful)
            {
                Student student = new Student(usernameTextBox.Text, passwordTextBox.Text, nameTextBox.Text, surnameTextBox.Text, studentNoTextBox.Text, phoneNoBox.Text, emailTextBox.Text);
                Lesson lesson = new Lesson();
                RegisterLesson rl = new RegisterLesson();
                rs.registerStudent(student.Username, student.Password, student.Name, student.Surname,student.Studentno, student.Phonenum, student.Email);

                if (mathematicCheck.Checked == true)
                {
                    lesson.LessonName = "Mathematic";
                    rl.registerLesson(student.getStudentid(), lesson.LessonName, lesson.Midterm, lesson.Final, lesson.Grade, lesson.WordGrade);
                }
                if (physicCheck.Checked == true)
                {
                    lesson.LessonName = "Physic";
                    rl.registerLesson(student.getStudentid(), lesson.LessonName, lesson.Midterm, lesson.Final, lesson.Grade, lesson.WordGrade);

                }
                if (chemistryCheck.Checked == true)
                {
                    lesson.LessonName = "Chemistry";
                    rl.registerLesson(student.getStudentid(), lesson.LessonName, lesson.Midterm, lesson.Final, lesson.Grade, lesson.WordGrade);
                }
                if (biologyCheck.Checked == true)
                {
                    lesson.LessonName = "Biology";
                    rl.registerLesson(student.getStudentid(), lesson.LessonName, lesson.Midterm, lesson.Final, lesson.Grade, lesson.WordGrade);

                }
                if (germanCheck.Checked == true)
                {
                    lesson.LessonName = "German";
                    rl.registerLesson(student.getStudentid(), lesson.LessonName, lesson.Midterm, lesson.Final, lesson.Grade, lesson.WordGrade);
                }
                if (englishCheck.Checked == true)
                {
                    lesson.LessonName = "English";
                    rl.registerLesson(student.getStudentid(), lesson.LessonName, lesson.Midterm, lesson.Final, lesson.Grade, lesson.WordGrade);

                }               
                MessageBox.Show("Registration Has Been Completed Successfully. You can login right now.");
                this.Close();
                StudentLogin sl = new StudentLogin();
                sl.Show();


            }
            
            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentLogin sl = new StudentLogin();
            sl.Show();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void repasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            repasswordTextBox.UseSystemPasswordChar = true;
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            StudentLogin studentscreen = new StudentLogin();
            studentscreen.Show();
            this.Close();
        }

        private void studentNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
        }

        private void phoneNoBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
   (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void StudenRegister_Load(object sender, EventArgs e)
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
