using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Student_Information_System
{
    class RegisterStudent
    {
        Database db = new Database();
        bool hasSameUsername;
        public void registerStudent(string Username, string Password, string Name, string Surname, string Studentno, string Phonenum, string Email)
        {
            db.Connection.Open();
            string query = "insert into studentlog(Username,password,Name,Surname,Studentno,Phoneno,Email) values('" + Username + "','" + Password + "','" + Name + "','" + Surname + "','" + Studentno+ "','" + Phonenum + "','" + Email + "');";
            MySqlCommand mycommand = new MySqlCommand(query, db.Connection);
            db.Datareader = mycommand.ExecuteReader();
            while (db.Datareader.Read())
            {
            }
            db.Connection.Close();

        }

        public bool chechUsername(string username)
        {
            hasSameUsername = false;
            db.Connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT ID FROM `studentlog` WHERE username = @username", db.Connection);
            cmd.Parameters.AddWithValue("username", username);
            db.Datareader = cmd.ExecuteReader();
            while (db.Datareader.Read())
            {
                hasSameUsername = true;
            }
            db.Connection.Close();

            return hasSameUsername;
        }

        public bool checkEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
