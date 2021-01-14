using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Student_Information_System
{
    class RegisterLesson
    {
        Database db = new Database();
        public void registerLesson(int studentid,string lessonName,string midterm, string final, int grade, string gradeWord)
        {
            db.Connection.Open();
            string query = "insert into lessonlog(ID,Name,Midterm,Final,WordGrade) values('" + studentid + "','" + lessonName + "','" + midterm + "','" + final + "','" + gradeWord + "');";
            MySqlCommand mycommand = new MySqlCommand(query, db.Connection);
            db.Datareader = mycommand.ExecuteReader();
            while (db.Datareader.Read())
            {
            }
            db.Connection.Close();
        }
            
        

        }
    }
