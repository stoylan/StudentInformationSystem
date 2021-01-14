using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Information_System
{
    class Student
    {
        private string username;
        private string password;
        private string name;
        private string surname;
        private string studentno;
        private string phonenum;
        private string email;
        Database db = new Database();
        public Student(string username, string password, string name, string surname, string studentno, string phonenum, string email)
        {
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            this.Studentno = studentno;
            this.Phonenum = phonenum;
            this.Email = email;
        }
        public Student()
        {

        }

        public int getStudentid()
        {
            db.Connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT ID FROM `studentlog` WHERE username = @username", db.Connection);
            cmd.Parameters.AddWithValue("username", username);
            db.Datareader = cmd.ExecuteReader();
            int id = 0;
            while (db.Datareader.Read())
            {
                id = Convert.ToInt32(db.Datareader.GetValue(0));
            }
            db.Connection.Close();
            return id;
            
        }

        public string getStudentName(int id)
        {
            db.Connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Name,Surname FROM `studentlog` WHERE ID = @id", db.Connection);
            cmd.Parameters.AddWithValue("id", id);
            db.Datareader = cmd.ExecuteReader();
            String name = "";
            String surname = "";
            while (db.Datareader.Read())
            {
                name = db.Datareader.GetValue(0).ToString();
                surname = db.Datareader.GetValue(1).ToString();
                
            }
           
            String StudentName = name + " " + surname;
            db.Connection.Close();
            return StudentName;
        }
        public void deleteStudent(int id)
        {
            db.Connection.Open();
            
            MySqlCommand deleteLesson = new MySqlCommand("delete from lessonlog where ID = '"+id+"'", db.Connection);
            deleteLesson.ExecuteNonQuery();
            MySqlCommand deleteStudent = new MySqlCommand("delete from studentlog where ID = '" + id + "'", db.Connection);
            deleteStudent.ExecuteNonQuery();
            db.Connection.Close();

        }


        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string Studentno { get => studentno; set => studentno = value; }
        public string Phonenum { get => phonenum; set => phonenum = value; }
    }
}
