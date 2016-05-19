using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace smil
{
    class SletPersonale
    {
        public returnObj SletP(int id)
        {
            try
            {

                if (Connect.query("DELETE FROM `SMIL`.`personale` WHERE id = "+id+";"))
                {


                    returnObj Arr = new returnObj(8);  // type 8 er slet personale
                    Arr.Add("Personale er slettet");

                    return Arr;

                }
                else
                {
                    returnObj Arr = new returnObj(0);  // type 0 er fejlmelding
                    Arr.Add("Dette personale har behandlinger fremadrettet");

                    return Arr;
                }
            }
            catch
            {
                returnObj Arr = new returnObj(0);  // type 0 er fejlmelding
                Arr.Add("Personale kunne ikke slettes");

                return Arr;
            }
        }
    }
}
