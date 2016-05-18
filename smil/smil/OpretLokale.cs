using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace smil
{
    class OpretLokale
    {
        public returnObj Nytlokale()
        {
            try
            {

                Connect connection = Connect.Conn();

                connection.Con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO `SMIL`.`lokale` (`id`) VALUES (NULL);", connection.Con);
                cmd.ExecuteNonQuery();
                connection.Con.Close();

                returnObj Arr = new returnObj(2);  // type 2 er opret lokale
                Arr.Add("Lokalet er oprettet");

                return Arr;
            }
            catch
            {
                returnObj Arr = new returnObj(0);  // type 0 er fejlmelding
                Arr.Add("Lokale kunne ikke oprettes");

                return Arr;
            }
        }
    }
   // public returnObj Nytlokale()
}
