using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace smil
{
    class Connect
    {
        private static Connect Connection;
        public static MySqlConnection Con;
        public static MySqlCommand cmd;
        // Constructor is 'protected'
        protected Connect()
        {
            Con = new MySqlConnection("Server=146.185.149.25; Port=3306; Database=SMIL; Uid=superuser; Pwd=kony2012;");
        }

        public static Connect Conn()
        { 
            if (Connection == null)
            {
                Connection = new Connect();
            }

            return Connection;
        }

        public static bool query(string query)
        {

            if (Connection == null)
            {
                Connection = new Connect();
            }

            try
            {
                Con.Open();

                cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = Con;

                //Execute query
                cmd.ExecuteNonQuery();
                
                //close connection
                Con.Close();

                return true;
            }
            catch
            {

                return false;

            }
        }

        public static MySqlCommand getCmd()
        {
            return cmd;
        }

        public static int insertID()
        {
            try
            {
                int id = Convert.ToInt32(cmd.LastInsertedId);

                return id;

            }
            catch
            {
                return 0;
            }
            
        }

        public static bool select(string query)
        {

            if (Connection == null)
            {
                Connection = new Connect();
            }

            try
            {
                Con.Open();

                cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = Con;

                //Execute query
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {

                return false;

            }
        }

    }
}
