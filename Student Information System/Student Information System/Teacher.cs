using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System
{
    class Teacher
    {
        private string username;
        private string password;
        private string name;
        private string surname;
        private int id;
        public List<string> lessons;
        Database db = new Database();

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Id { get => id; set => id = value; }

        public Teacher()
        {

        }
      
        
        public string getTacherName(int id)
        {
            db.Connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT name,surname FROM `teacherlog` WHERE ID = @id", db.Connection);
            cmd.Parameters.AddWithValue("id", id);
            db.Datareader = cmd.ExecuteReader();
            String name = "";
            String surname = "";
            while (db.Datareader.Read())
            {
                name = db.Datareader.GetValue(0).ToString();
                surname = db.Datareader.GetValue(1).ToString();

            }

            String teacherName = name + " " + surname;
            db.Connection.Close();
            return teacherName;

        }
        public int getTeacherid()
        {
            db.Connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT ID FROM `teacherlog` WHERE username = @username", db.Connection);
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
        public List<String> GetTeacherLesson(int id)
        {
            lessons = new List<string>();
            db.Connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Name FROM `lessoninfo` WHERE TeacherId = @id", db.Connection);
            cmd.Parameters.AddWithValue("id", id);
            db.Datareader = cmd.ExecuteReader();
            while (db.Datareader.Read())
            {

                lessons.Add(db.Datareader.GetValue(0).ToString());

            }
            db.Connection.Close();
            return lessons;
        }
    }
}

