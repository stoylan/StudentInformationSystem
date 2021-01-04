using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Student_Information_System
{
    class Lesson
    {
        private int studentid;
        private string lessonName;
        private string midterm;
        private string final;
        private int grade;
        private string wordGrade;
        private int average;

        

        DataSet ds = new DataSet();
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySqlConnection con = new MySqlConnection();
        Database db = new Database();
        public Lesson()
        {
            midterm = "-";
            final = "-";
            wordGrade = "-";
        }
        public void fillGrid(String lessonname,DataGridView datagrid)
        {
            con = new MySqlConnection("Server=localhost; Database=studentinfo; Uid=root; Pwd=12345;");
            da = new MySqlDataAdapter("Select lessonlog.ID,studentlog.Name, studentlog.Surname, studentlog.Studentno,lessonlog.Midterm,lessonlog.Final,lessonlog.Grade,lessonlog.Absent,lessonlog.WordGrade,lessonlog.OverallAverage from lessonlog,studentlog where studentlog.ID = lessonlog.ID AND lessonlog.Name = '" + lessonname + "'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "studentlog");
            datagrid.DataSource = ds.Tables["studentlog"];
            con.Close();


        }
        public void bringGrade(String username, int id,DataGridView datagrid)
        {
            con = new MySqlConnection("Server=localhost; Database=studentinfo; Uid=root; Pwd=12345;");
            da = new MySqlDataAdapter("Select lessonlog.Name,lessonlog.Absent,lessonlog.Midterm,lessonlog.Final,lessonlog.Grade,lessonlog.WordGrade,lessonlog.OverallAverage from lessonlog,studentlog where lessonlog.ID = '" + id + "' AND studentlog.username = '" + username + "'", con);
            con.Open();
            da.Fill(ds, "studentlog");
            datagrid.DataSource = ds.Tables["studentlog"];
            con.Close();
        }
        public int updateAndGetAVG(String Lesson)
        {
            db.Connection.Open();
            db.Command.Connection = db.Connection;
            db.Command.CommandText = "Select AVG(Grade) FROM lessonlog where Name ='"+ Lesson+"' AND Grade between 1 and 100";
            Average = Convert.ToInt32(db.Command.ExecuteScalar());

            db.Command.CommandText = "update lessoninfo set AverageGrade='" + Average + "' WHERE Name = '" + Lesson + "'";
            db.Command.ExecuteNonQuery();
            db.Connection.Close();
            return Average;
        }

        public void updateGrade(String midterm,String final,String id, String Lesson)
        {
            db.Connection.Open();
            db.Command.Connection = db.Connection;
            db.Command.CommandText = "update lessonlog set Midterm='" + midterm + "',Final='" + final + "' where ID= '" + id + "' AND Name = '"+ Lesson +"'";
            db.Command.ExecuteNonQuery();
            db.Connection.Close();
        }

        public void updateWordGrade(int absence, int absenceLimit, int id,String Lesson)
        {
            db.Connection.Open();
            db.Command.Connection = db.Connection;

            if (absence > absenceLimit)
                wordGrade = "DZ";
            else if (grade > 90)
                wordGrade = "AA";
            else if (grade > 85)
                wordGrade = "AB";
            else if (grade > 75)
                wordGrade = "BA";
            else if (grade > 65)
                wordGrade = "BB";
            else if (grade > 60)
                wordGrade = "BC";
            else if (grade > 55)
                wordGrade = "CB";
            else if (grade > average)
                wordGrade = "CC";
            else if (grade > average * 9 / 10)
                wordGrade = "CD";
            else if (grade > average * 8 / 10)
                wordGrade = "DC";
            else if (grade > average * 7 / 10)
                wordGrade = "DD";
            else
                wordGrade = "FF";


            db.Command.CommandText = "update lessonlog set Grade='" + grade + "',WordGrade='" + wordGrade + "' where ID='" + id + "' AND NAME = '" + Lesson + "'";
            db.Command.ExecuteNonQuery();
            db.Connection.Close();
        }

        public int getAbsenceLimit(String Lesson)
        {
            db.Connection.Open();
            db.Command.Connection = db.Connection;
            db.Command.CommandText = "Select AbsenceLimit FROM lessoninfo where Name = '" + Lesson + "'";
            int absenceLimit = Convert.ToInt32(db.Command.ExecuteScalar());
            db.Connection.Close();
            return absenceLimit;

        }
        
        public void getTranscript()
        {

        }


        public string LessonName { get => lessonName; set => lessonName = value; }
        public string WordGrade { get => wordGrade; set => wordGrade = value; }
        public int Studentid { get => studentid; set => studentid = value; }
        public string Midterm { get => midterm; set => midterm = value; }
       
        public string Final { get => final; set => final = value; }
        public int Grade { get => grade; set => grade = value; }
        public int Average { get => average; set => average = value; }
    }
}
