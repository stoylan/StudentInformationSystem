using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Information_System
{
    public partial class TeacherScreen : Form
    {
        public string lessonName;
        public int teacherId;
        List<String> lessons = new List<string>();
        Teacher teacher = new Teacher();
        Lesson lesson = new Lesson();
        Database db = new Database();

        public string lesson1;
        public string lesson2;
        public string lesson3;
        public TeacherScreen()
        {
            InitializeComponent();
            teacherId = teacher.Id;

        }

        private void MathematicPage_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void getLectureTeacher(int id)
        {
            lessons = teacher.GetTeacherLesson(id);

        }


        private void TeacherScreen_Load(object sender, EventArgs e)
        {
            getLectureTeacher(teacherId);
            timer1.Enabled = true;
            String name = teacher.getTacherName(teacherId);
            teachername_label.Text = "                    WELCOME " + name.ToUpper() + "                     ";
            if (lessons.Count == 3)
            {
                lesson1 = lessons[0];
                lesson2 = lessons[1];
                lesson3 = lessons[2];
                lesson.fillGrid(lesson1, dataGridView1);
                lesson.fillGrid(lesson2, dataGridView2);
                lesson.fillGrid(lesson3, dataGridView3);
                
                lesson_label1.Text = lesson1;
                lesson2_label.Text = lesson2;
                lesson3_label.Text = lesson3;

            }

            if (lessons.Count == 2)
            {
                lesson1 = lessons[0];
                lesson2 = lessons[1];
                lesson.fillGrid(lessons[0], dataGridView1);
                lesson.fillGrid(lessons[1], dataGridView2);
                tabControl1.TabPages.RemoveByKey("tabPage3");
              
                lesson_label1.Text = lesson1;
                lesson2_label.Text = lesson2;

            }
            if (lessons.Count == 1)
            {
                lesson1 = lessons[0];
                lesson.fillGrid(lessons[0], dataGridView1);
               
                lesson_label1.Text = lesson1;
             
                tabControl1.TabPages.RemoveByKey("tabPage2");
                tabControl1.TabPages.RemoveByKey("tabPage3");

            }
            for (int i = 0; i < lessons.Count; i++)
            {

                tabControl1.TabPages[i].Text = lessons[i];

            }



        }

        private void mathematicEnterGrade_Click(object sender, EventArgs e)
        {
            if (checktextboxes(vize_box, final_box))
            {
                warning1label.Visible = false;
                db.Connection.Open();
                db.Command.Connection = db.Connection;
                lesson.updateGrade(vize_box.Text, final_box.Text, studentid_box.Text, lesson1);

                if (!vize_box.Text.Equals("-") && !final_box.Text.Equals("-"))
                {
                    int grade = (Convert.ToInt32(vize_box.Text) * 4) / 10 + (Convert.ToInt32(final_box.Text) * 6) / 10;
                    lesson.Grade = grade;
                    int absenceLimit = lesson.getAbsenceLimit(lesson1);
                    int average = lesson.updateAndGetAVG(lesson1);

                    lesson.updateWordGrade(Convert.ToInt32(absent_combobox1.SelectedItem), absenceLimit, Convert.ToInt32(studentid_box.Text), lesson1);
                    db.Command.CommandText = "update lessonlog set OverallAverage='" + average + "' where Name = '" + lesson1 + "'";
                    db.Command.ExecuteNonQuery();
                }

                if (absent_combobox1.SelectedIndex != -1)
                {
                    db.Command.CommandText = "update lessonlog set Absent='" + absent_combobox1.SelectedItem + "' where ID= '" + studentid_box.Text + "' AND Name = '" + lesson1 + "'";
                    db.Command.ExecuteNonQuery();
                }



                db.Connection.Close();
                lesson.fillGrid(lesson1, dataGridView1);
            }
            else
                warning1label.Visible = true;
        }

        private void mathematicDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            studentid_box.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            final_box.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            vize_box.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            absent_combobox1.SelectedItem = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void phy_notbutton_Click(object sender, EventArgs e)
        {
            if (checktextboxes(vize2_box, final2_box))
            {
                label12.Visible = false;
                db.Connection.Open();
                db.Command.Connection = db.Connection;
                lesson.updateGrade(vize2_box.Text, final2_box.Text, studenid2_box.Text, lesson2);

                if (!vize2_box.Text.Equals("-") && !final2_box.Text.Equals("-"))
                {
                    int grade = (Convert.ToInt32(vize2_box.Text) * 4) / 10 + (Convert.ToInt32(final2_box.Text) * 6) / 10;
                    lesson.Grade = grade;
                    int absenceLimit = lesson.getAbsenceLimit(lesson2);
                    int average = lesson.updateAndGetAVG(lesson2);

                    lesson.updateWordGrade(Convert.ToInt32(absen2_combo.SelectedItem), absenceLimit, Convert.ToInt32(studenid2_box.Text), lesson2);
                    db.Command.CommandText = "update lessonlog set OverallAverage='" + average + "' where Name = '" + lesson2 + "'";
                    db.Command.ExecuteNonQuery();
                }

                if (absen2_combo.SelectedIndex != -1)
                {
                    db.Command.CommandText = "update lessonlog set Absent='" + absen2_combo.SelectedItem + "' where ID= '" + studenid2_box.Text + "' AND Name = '" + lesson2 + "'";
                    db.Command.ExecuteNonQuery();
                }



                db.Connection.Close();
                lesson.fillGrid(lesson2, dataGridView2);
            }
            else
                warning2_label.Visible = true;

        }

        private void eng_notbutton_Click(object sender, EventArgs e)
        {
            if (checktextboxes(vize3_box, final3_box))
            {

                db.Connection.Open();
                db.Command.Connection = db.Connection;
                lesson.updateGrade(vize3_box.Text, final3_box.Text, studentid3_box.Text, lesson3);

                if (!vize3_box.Text.Equals("-") && !final3_box.Text.Equals("-"))
                {
                    int grade = (Convert.ToInt32(vize3_box.Text) * 4) / 10 + (Convert.ToInt32(final3_box.Text) * 6) / 10;
                    lesson.Grade = grade;
                    int absenceLimit = lesson.getAbsenceLimit(lesson3);
                    int average = lesson.updateAndGetAVG(lesson3);

                    lesson.updateWordGrade(Convert.ToInt32(absent3_combo.SelectedItem), absenceLimit, Convert.ToInt32(studentid3_box.Text), lesson3);
                    db.Command.CommandText = "update lessonlog set OverallAverage='" + average + "' where Name = '" + lesson3 + "'";
                    db.Command.ExecuteNonQuery();
                }

                if (absent3_combo.SelectedIndex != -1)
                {
                    db.Command.CommandText = "update lessonlog set Absent='" + absent3_combo.SelectedItem + "' where ID= '" + studentid3_box.Text + "' AND Name = '" + lesson3 + "'";
                    db.Command.ExecuteNonQuery();
                }

                db.Connection.Close();
                lesson.fillGrid(lesson3, dataGridView3);
            }
            else
                warning3_label.Visible = true;

        }

        private void phy_gridview_MouseClick(object sender, MouseEventArgs e)
        {
            studenid2_box.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            final2_box.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            vize2_box.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            absen2_combo.SelectedItem = dataGridView2.CurrentRow.Cells[7].Value.ToString();
        }

        private void eng_gridview_MouseClick(object sender, MouseEventArgs e)
        {
            studentid3_box.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            final3_box.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
            vize3_box.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            absent3_combo.SelectedItem = dataGridView3.CurrentRow.Cells[7].Value.ToString();
        }

      
        public bool checktextboxes(TextBox vizebox,TextBox finalbox)
        {
            if((((Int32.TryParse(vizebox.Text, out var outParse)) && (Int32.TryParse(finalbox.Text, out var outParse2)))&&((Int32.Parse(vizebox.Text)<=100)&&(Int32.Parse(vizebox.Text)>=0)))&& ((Int32.Parse(finalbox.Text) >= 0) && (Int32.Parse(finalbox.Text) <= 100)) && ((Int32.Parse(vizebox.Text) >= 0) && (Int32.Parse(vizebox.Text) <= 100)))
            {
                return true;
            }
            return false;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            teachername_label.Text = teachername_label.Text.Substring(1) + teachername_label.Text.Substring(0, 1);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (lessons.Count == 3)
            {
                Attendance absent = new Attendance(lesson1, lesson2, lesson3);

                absent.Show();
            }
            if (lessons.Count == 2)
            {
                Attendance absent = new Attendance(lesson1, lesson2);
                absent.Show();
            }
            if (lessons.Count == 1)
            {
                Attendance absent = new Attendance(lesson1);
                absent.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
