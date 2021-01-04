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
        Lesson lesson = new Lesson();
        public String teacherName;

        public TeacherScreen()
        {
            InitializeComponent();

        }

        private void MathematicPage_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        Database db = new Database();


        private void TeacherScreen_Load(object sender, EventArgs e)
        {
            if (teacherName == "admin")
            {
                lesson.fillGrid("Mathematic", mathematicDataGridView);
                lesson.fillGrid("Physic", phy_gridview);
                lesson.fillGrid("English", eng_gridview);
                tabControl1.Show();
                tabControl2.Hide();
            }
            if (teacherName == "admin2")
            {
                lesson.fillGrid("Chemistry", chemistry_gridview);
                lesson.fillGrid("Biology", bio_gridview);
                lesson.fillGrid("German", german_gridview);
                tabControl1.Hide();
                tabControl2.Show();
            }


        }

        private void mathematicEnterGrade_Click(object sender, EventArgs e)
        {
            db.Connection.Open();
            db.Command.Connection = db.Connection;
            lesson.updateGrade(math_vizebox.Text, math_finalbox.Text, math_studentıd.Text, "Mathematic");

            if (!math_vizebox.Text.Equals("-") && !math_finalbox.Text.Equals("-"))
            {
                int grade = (Convert.ToInt32(math_vizebox.Text) * 4) / 10 + (Convert.ToInt32(math_finalbox.Text) * 6) / 10;
                lesson.Grade = grade;
                int absenceLimit = lesson.getAbsenceLimit("Mathematic");
                int average = lesson.updateAndGetAVG("Mathematic");

                lesson.updateWordGrade(Convert.ToInt32(math_absentcombobox.SelectedItem), absenceLimit, Convert.ToInt32(math_studentıd.Text), "Mathematic");
                db.Command.CommandText = "update lessonlog set OverallAverage='" + average + "' where Name = 'Mathematic'";
                db.Command.ExecuteNonQuery();

            }

            if (math_absentcombobox.SelectedIndex != -1)
            {
                db.Command.CommandText = "update lessonlog set Absent='" + math_absentcombobox.SelectedItem + "' where ID= '" + math_studentıd.Text + "' AND Name = 'Mathematic'";
                db.Command.ExecuteNonQuery();
            }



            db.Connection.Close();
            lesson.fillGrid("Mathematic", mathematicDataGridView);
        }

        private void mathematicDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            math_studentıd.Text = mathematicDataGridView.CurrentRow.Cells[0].Value.ToString();
            math_finalbox.Text = mathematicDataGridView.CurrentRow.Cells[5].Value.ToString();
            math_vizebox.Text = mathematicDataGridView.CurrentRow.Cells[4].Value.ToString();
            math_absentcombobox.SelectedItem = mathematicDataGridView.CurrentRow.Cells[7].Value.ToString();
        }

        private void phy_notbutton_Click(object sender, EventArgs e)
        {
            db.Connection.Open();
            db.Command.Connection = db.Connection;
            lesson.updateGrade(phy_vize_box.Text, phy_final_box.Text, phy_studentıd_box.Text, "Physic");

            if (!phy_vize_box.Text.Equals("-") && !phy_final_box.Text.Equals("-"))
            {
                int grade = (Convert.ToInt32(phy_vize_box.Text) * 4) / 10 + (Convert.ToInt32(phy_final_box.Text) * 6) / 10;
                lesson.Grade = grade;
                int absenceLimit = lesson.getAbsenceLimit("Physic");
                int average = lesson.updateAndGetAVG("Physic");

                lesson.updateWordGrade(Convert.ToInt32(phy_absent_combo.SelectedItem), absenceLimit, Convert.ToInt32(phy_studentıd_box.Text), "Physic");
                db.Command.CommandText = "update lessonlog set OverallAverage='" + average + "' where Name = 'Physic'";
                db.Command.ExecuteNonQuery();

            }

            if (phy_absent_combo.SelectedIndex != -1)
            {
                db.Command.CommandText = "update lessonlog set Absent='" + phy_absent_combo.SelectedItem + "' where ID= '" + phy_studentıd_box.Text + "' AND Name = 'Physic'";
                db.Command.ExecuteNonQuery();
            }



            db.Connection.Close();
            lesson.fillGrid("Physic", phy_gridview);
        }

        private void eng_notbutton_Click(object sender, EventArgs e)
        {
            db.Connection.Open();
            db.Command.Connection = db.Connection;
            lesson.updateGrade(eng_vize_box.Text, eng_final_box.Text, eng_studentıd_box.Text, "English");

            if (!eng_vize_box.Text.Equals("-") && !eng_final_box.Text.Equals("-"))
            {
                int grade = (Convert.ToInt32(eng_vize_box.Text) * 4) / 10 + (Convert.ToInt32(eng_final_box.Text) * 6) / 10;
                lesson.Grade = grade;
                int absenceLimit = lesson.getAbsenceLimit("English");
                int average = lesson.updateAndGetAVG("English");

                lesson.updateWordGrade(Convert.ToInt32(eng_combobox.SelectedItem), absenceLimit, Convert.ToInt32(eng_studentıd_box.Text), "English");
                db.Command.CommandText = "update lessonlog set OverallAverage='" + average + "' where Name = 'English'";
                db.Command.ExecuteNonQuery();
            }

            if (eng_combobox.SelectedIndex != -1)
            {
                db.Command.CommandText = "update lessonlog set Absent='" + eng_combobox.SelectedItem + "' where ID= '" + eng_studentıd_box.Text + "' AND Name = 'English'";
                db.Command.ExecuteNonQuery();
            }



            db.Connection.Close();
            lesson.fillGrid("English", eng_gridview);

        }

        private void phy_gridview_MouseClick(object sender, MouseEventArgs e)
        {
            phy_studentıd_box.Text = phy_gridview.CurrentRow.Cells[0].Value.ToString();
            phy_final_box.Text = phy_gridview.CurrentRow.Cells[5].Value.ToString();
            phy_vize_box.Text = phy_gridview.CurrentRow.Cells[4].Value.ToString();
            phy_absent_combo.SelectedItem = phy_gridview.CurrentRow.Cells[7].Value.ToString();
        }

        private void eng_gridview_MouseClick(object sender, MouseEventArgs e)
        {
            eng_studentıd_box.Text = eng_gridview.CurrentRow.Cells[0].Value.ToString();
            eng_final_box.Text = eng_gridview.CurrentRow.Cells[5].Value.ToString();
            eng_vize_box.Text = eng_gridview.CurrentRow.Cells[4].Value.ToString();
            eng_combobox.SelectedItem = eng_gridview.CurrentRow.Cells[7].Value.ToString();
        }

        private void chemistery_notbutton_Click(object sender, EventArgs e)
        {
            db.Connection.Open();
            db.Command.Connection = db.Connection;
            lesson.updateGrade(chemistery_vizebox.Text, chemistry_final.Text, chemistry_studentid.Text, "Chemistry");

            if (!chemistery_vizebox.Text.Equals("-") && !chemistry_final.Text.Equals("-"))
            {
                int grade = (Convert.ToInt32(chemistery_vizebox.Text) * 4) / 10 + (Convert.ToInt32(chemistry_final.Text) * 6) / 10;
                lesson.Grade = grade;
                int absenceLimit = lesson.getAbsenceLimit("Chemistry");
                int average = lesson.updateAndGetAVG("Chemistry");

                lesson.updateWordGrade(Convert.ToInt32(chemistery_absent_combobox.SelectedItem), absenceLimit, Convert.ToInt32(chemistry_studentid.Text), "Chemistry");
                db.Command.CommandText = "update lessonlog set OverallAverage='" + average + "' where Name = 'Chemistry'";
                db.Command.ExecuteNonQuery();

            }

            if (chemistery_absent_combobox.SelectedIndex != -1)
            {
                db.Command.CommandText = "update lessonlog set Absent='" + chemistery_absent_combobox.SelectedItem + "' where ID= '" + chemistry_studentid.Text + "' AND Name = 'Chemistry'";
                db.Command.ExecuteNonQuery();
            }



            db.Connection.Close();
            lesson.fillGrid("Chemistry", chemistry_gridview);
        }

        private void biology_notbutton_Click(object sender, EventArgs e)
        {
            db.Connection.Open();
            db.Command.Connection = db.Connection;
            lesson.updateGrade(biology_vizebox.Text, biology_finalbox.Text, biology_studentid.Text, "Biology");

            if (!biology_vizebox.Text.Equals("-") && !biology_finalbox.Text.Equals("-"))
            {
                int grade = (Convert.ToInt32(biology_vizebox.Text) * 4) / 10 + (Convert.ToInt32(biology_finalbox.Text) * 6) / 10;
                lesson.Grade = grade;
                int absenceLimit = lesson.getAbsenceLimit("Biology");
                int average = lesson.updateAndGetAVG("Biology");

                lesson.updateWordGrade(Convert.ToInt32(biology_absentcombobox.SelectedItem), absenceLimit, Convert.ToInt32(biology_studentid.Text), "Biology");
                db.Command.CommandText = "update lessonlog set OverallAverage='" + average + "' where Name = 'Biology'";
                db.Command.ExecuteNonQuery();
            }

            if (biology_absentcombobox.SelectedIndex != -1)
            {
                db.Command.CommandText = "update lessonlog set Absent='" + biology_absentcombobox.SelectedItem + "' where ID= '" + biology_studentid.Text + "' AND Name = 'Biology'";
                db.Command.ExecuteNonQuery();
            }



            db.Connection.Close();
            lesson.fillGrid("Biology", bio_gridview);
        }

        private void german_notbutton_Click(object sender, EventArgs e)
        {
            db.Connection.Open();
            db.Command.Connection = db.Connection;
            lesson.updateGrade(german_vizebox.Text, german_finalbox.Text, german_studentid.Text, "German");

            if (!german_vizebox.Text.Equals("-") && !german_finalbox.Text.Equals("-"))
            {
                int grade = (Convert.ToInt32(german_vizebox.Text) * 4) / 10 + (Convert.ToInt32(german_finalbox.Text) * 6) / 10;
                lesson.Grade = grade;

                int absenceLimit = lesson.getAbsenceLimit("German");
                lesson.updateWordGrade(Convert.ToInt32(german_absentcombobox.SelectedItem), absenceLimit, Convert.ToInt32(german_studentid.Text), "German");
                int average = lesson.updateAndGetAVG("German");

                db.Command.CommandText = "update lessonlog set OverallAverage='" + average + "' where Name = 'German'";
                db.Command.ExecuteNonQuery();
            }

            if (german_absentcombobox.SelectedIndex != -1)
            {
                db.Command.CommandText = "update lessonlog set Absent='" + german_absentcombobox.SelectedItem + "' where ID= '" + german_studentid.Text + "' AND Name = 'German'";
                db.Command.ExecuteNonQuery();
            }



            db.Connection.Close();
            lesson.fillGrid("German", german_gridview);
        }

        private void chemistry_gridview_MouseClick(object sender, MouseEventArgs e)
        {
            chemistry_studentid.Text = chemistry_gridview.CurrentRow.Cells[0].Value.ToString();
            chemistry_final.Text = chemistry_gridview.CurrentRow.Cells[5].Value.ToString();
            chemistery_vizebox.Text = chemistry_gridview.CurrentRow.Cells[4].Value.ToString();
            chemistery_absent_combobox.SelectedItem = chemistry_gridview.CurrentRow.Cells[7].Value.ToString();
        }



        private void bio_gridview_MouseClick(object sender, MouseEventArgs e)
        {
            biology_studentid.Text = bio_gridview.CurrentRow.Cells[0].Value.ToString();
            biology_finalbox.Text = bio_gridview.CurrentRow.Cells[5].Value.ToString();
            biology_vizebox.Text = bio_gridview.CurrentRow.Cells[4].Value.ToString();
            biology_absentcombobox.SelectedItem = bio_gridview.CurrentRow.Cells[7].Value.ToString();
        }

        private void german_gridview_MouseClick(object sender, MouseEventArgs e)
        {
            german_studentid.Text = german_gridview.CurrentRow.Cells[0].Value.ToString();
            german_finalbox.Text = german_gridview.CurrentRow.Cells[5].Value.ToString();
            german_vizebox.Text = german_gridview.CurrentRow.Cells[4].Value.ToString();
            german_absentcombobox.SelectedItem = german_gridview.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
