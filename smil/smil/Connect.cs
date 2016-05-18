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
            SqlConnection Con = new SqlConnection("user id=root;" +
                                       "password=kony2012;" + 
                                       "server=holydb;" +
                                       "Trusted_Connection=yes;" +
                                       "database=SMIL; " +
                                       "connection timeout=30");
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
