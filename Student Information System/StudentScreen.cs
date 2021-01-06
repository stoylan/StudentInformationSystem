using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Information_System
{
    public partial class StudentScreen : Form
    {
        private int studentID;
        public String studentname;
        private String studentUsername;
        Lesson lesson = new Lesson();
        Student student = new Student();
        Transcript transcript = new Transcript();


        public int StudentID1 { get => studentID; set => studentID = value; }
        public string StudentUsername { get => studentUsername; set => studentUsername = value; }

        public StudentScreen()
        {
            InitializeComponent();
            exitLogin.BackColor = System.Drawing.Color.Transparent;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void StudentScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lesson.bringGrade(StudentUsername, StudentID1, dataGridView2);
            studentname = student.getStudentName(StudentID1);
            label1.Text = "                    WELCOME " + studentname.ToUpper()+ "                     ";
            dataGridView2.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Show();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UpdateInformation updateinformation = new UpdateInformation();
            updateinformation.Id = studentID;
            updateinformation.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void transcriptButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Txt Dosyası|*.txt";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFile.FileName, transcript.getTranscriptRecord(studentID,studentname), Encoding.UTF8);
                MessageBox.Show("Your transcript record has saved succesfully.");
            }

        }

        private void exitLogin_Click(object sender, EventArgs e)
        {

            StartScreen sc = new StartScreen();
            sc.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult areuSure = MessageBox.Show("Do you want to remove your account ?", "Confirmation", MessageBoxButtons.YesNo);
            if (areuSure == DialogResult.Yes)
            {
                student.deleteStudent(studentID);
                StartScreen sc = new StartScreen();
                sc.Show();
                this.Close();
            }

        }
    }
}
