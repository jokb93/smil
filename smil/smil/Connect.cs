using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace smil
{
    class Connect
    {
        private static Connect Connection;
        public SqlConnection Con;
        // Constructor is 'protected'
        protected Connect()
        {
            //Con = new SqlConnection("user id=superuser;" +
            //                            "password=kony2012;" +
            //                            "server=146.185.149.25;" +
            //                            "Trusted_Connection=yes;" +
            //                            "database=SMIL;" +
            //                            "connection timeout=30");

      
            string Constring = "Data Source=tcp:146.185.149.25;Initial Catalog=SMIL;User ID=superuser;Password=kony2012;";
            Con = new SqlConnection(Constring);
        }

        public static Connect Conn()
        { 
            if (Connection == null)
            {
                Connection = new Connect();
            }

            return Connection;
        }
    }
}
