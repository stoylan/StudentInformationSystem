using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Student_Information_System
{
    class Database
    {
        private MySqlConnection connection = new MySqlConnection("Server=localhost; Database=studentinfo; Uid=root; Pwd=12345;");
        private MySqlDataAdapter connector = new MySqlDataAdapter();
        private MySqlCommand command = new MySqlCommand();
        private MySqlDataReader datareader;
        public DataSet ds = new DataSet();
        public MySqlDataAdapter da = new MySqlDataAdapter();


        public MySqlConnection Connection { get => connection; set => connection = value; }
        public MySqlDataAdapter Connector { get => connector; set => connector = value; }
        public MySqlCommand Command { get => command; set => command = value; }
        public MySqlDataReader Datareader { get => datareader; set => datareader = value; }

        public bool checkConnect()
        {
            try
            {
                Connection.Open();
                return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }

        }
    }
}

