using MySql.Data.MySqlClient;
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
    
    public partial class Attendance : Form
    {
        public string lesson1;
        public string lesson2;
        public string lesson3;
        public int teacherId;
 
       

        Lesson lesson = new Lesson();

        MySqlDataAdapter da = new MySqlDataAdapter();
        MySqlConnection con = new MySqlConnection();
        Database db = new Database();
        public Attendance()
        {
            InitializeComponent();

        }
        public Attendance(string lesson1)
        {
            InitializeComponent();
           
            this.lesson1 = lesson1;
            lessonlabel1.Text = lesson1;
            int absencelimit1 = lesson.getAbsenceLimit(lesson1);
            absence_box.Text = absencelimit1.ToString();
            lessonlabel2.Hide();
            lessonlabel3.Hide();
            absence2_box.Hide();
            absence3_box.Hide();
            button2.Hide();
            button3.Hide();
        }
        public Attendance(string lesson1, string lesson2)
        {
            InitializeComponent();
            
            this.lesson1 = lesson1;
            this.lesson2 = lesson2;
     
            lessonlabel1.Text = lesson1;
            lessonlabel2.Text = lesson2;
            int absencelimit1 = lesson.getAbsenceLimit(lesson1);
            int absencelimit2 = lesson.getAbsenceLimit(lesson2);
            absence_box.Text = absencelimit1.ToString();
            absence2_box.Text = absencelimit2.ToString();
            lessonlabel3.Hide();
            absence3_box.Hide();
            button3.Hide();

        }
        public Attendance(string lesson1,string lesson2,string lesson3)
        {
            InitializeComponent();  
            this.lesson1 = lesson1;
            this.lesson2 = lesson2;
            this.lesson3 = lesson3;
           
            
            lessonlabel1.Text = lesson1;
            lessonlabel2.Text = lesson2;
            lessonlabel3.Text = lesson3;
            int absencelimit1 = lesson.getAbsenceLimit(lesson1);
            int absencelimit2 = lesson.getAbsenceLimit(lesson2);
            int absencelimit3 = lesson.getAbsenceLimit(lesson3);
            absence_box.Text = absencelimit1.ToString();
            absence2_box.Text = absencelimit2.ToString();
            absence3_box.Text = absencelimit3.ToString();

        }
        public bool checkAbsentbox(TextBox absentbox)
        {
            if ((Int32.TryParse(absentbox.Text, out var outParse))&& ((Int32.Parse(absentbox.Text) <= 30) && (Int32.Parse(absentbox.Text) >= 0)))
            {
                return true;
            }
            return false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            db.Connection.Open();
            db.Command.Connection = db.Connection;
                if (checkAbsentbox(absence_box))
                {
                    absentwarning_label.Visible = false;
                    db.Command.CommandText = "update lessoninfo set AbsenceLimit='" + absence_box.Text + "' where Name = '" + lesson1 + "'";
                    db.Command.ExecuteNonQuery();
                }
                else
                    absentwarning_label.Visible = true;


            db.Connection.Close();
        }

        private void AbsentLimit_Load(object sender, EventArgs e)
        {
          
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.Connection.Open();
            db.Command.Connection = db.Connection;
            if (checkAbsentbox(absence2_box))
            {
                absentwarning_label.Visible = false;
                db.Command.CommandText = "update lessoninfo set AbsenceLimit='" + absence2_box.Text + "' where Name = '" + lesson2 + "'";

                db.Command.ExecuteNonQuery();
            }
            else
                absentwarning_label.Visible = true;


            db.Connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.Connection.Open();
            db.Command.Connection = db.Connection;
            if (checkAbsentbox(absence3_box))
            {
                absentwarning_label.Visible = false;
                db.Command.CommandText = "update lessoninfo set AbsenceLimit='" + absence3_box.Text + "' where Name = '" + lesson3 + "'";
                db.Command.ExecuteNonQuery();
            }
            else
                absentwarning_label.Visible = true;


            db.Connection.Close();


        }
    }
}
