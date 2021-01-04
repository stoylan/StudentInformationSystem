using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Information_System
{
    class verifyLogin
    {
        Database db = new Database();
        Student student = new Student();
        private int studentID;

        public int StudentID { get => studentID; set => studentID = value; }

        public bool verifyLogstudent(string username,string password)
        {
            db.Connection.Open();

            DataTable table = new DataTable();
            student.Username = username;
            student.Password = password;
            db.Connector = new MySqlDataAdapter("Select * From studentlog where Username = '" + student.Username + "' and password = '" + student.Password + "'", db.Connection);
            db.Connector.Fill(table);
            if (table.Rows.Count > 0)
            {
                studentID = student.getStudentid();
                db.Connection.Close();
                return true;
            }
            else
            {
                db.Connection.Close();
                return false;
            }
        }
        public bool verifyLogteacher(string username, string password)
        {
            db.Connection.Open();
            DataTable table = new DataTable();
            db.Connector = new MySqlDataAdapter("Select * From teacherlog where Username = '" + username + "' and password = '" + password + "'", db.Connection);
            db.Connector.Fill(table);
            if (table.Rows.Count > 0)
            {
                db.Connection.Close();
                return true;
            }
            else
            {
                db.Connection.Close();

                return false;
            }

        }
    }
}
