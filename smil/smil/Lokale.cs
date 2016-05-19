using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace smil
{
    class Lokale
    {
        public returnObj Nytlokale()
        {
            try
            {

                if(Connect.query("INSERT INTO `SMIL`.`lokale` (`id`) VALUES (NULL);"))
                {


                    returnObj Arr = new returnObj(2);  // type 2 er opret lokale
                    Arr.Add("Lokalet er oprettet");

                    return Arr;

                }
                else
                {
                    returnObj Arr = new returnObj(0);  // type 2 er opret lokale
                    Arr.Add("forbindelses fejl");

                    return Arr;
                }
            }
            catch
            {
                returnObj Arr = new returnObj(0);  // type 0 er fejlmelding
                Arr.Add("Lokale kunne ikke oprettes");

                return Arr;
            }

        }

        public returnObj opretKval(int lokaleId, int type)
        {

            try
            {

                if (Connect.query("INSERT INTO lokaleKvalifikationer (`type`, `lokaleid`) VALUES ('"+ type + "', '" + lokaleId + "')"))
                {


                    returnObj Arr = new returnObj(11);  // type 2 er opret lokale
                    Arr.Add("Kvalifikation tilføjet");

                    return Arr;

                }
                else
                {
                    returnObj Arr = new returnObj(0);  // type 2 er opret lokale
                    Arr.Add("forbindelses fejl");

                    return Arr;
                }
            }
            catch
            {
                returnObj Arr = new returnObj(0);  // type 0 er fejlmelding
                Arr.Add("Kvalifikation kunne ikke tilføjes");

                return Arr;
            }

        }

        public returnObj sletKval(int lokaleId, int type)
        {

            try
            {

                if (Connect.query("DELETE FROM `lokaleKvalifikationer` WHERE `type` = "+ type+" AND `lokaleid` = " + lokaleId))
                {


                    returnObj Arr = new returnObj(11);  // type 2 er opret lokale
                    Arr.Add("Kvalifikation slettet");

                    return Arr;

                }
                else
                {
                    returnObj Arr = new returnObj(0);  // type 2 er opret lokale
                    Arr.Add("forbindelses fejl");

                    return Arr;
                }
            }
            catch
            {
                returnObj Arr = new returnObj(0);  // type 0 er fejlmelding
                Arr.Add("Kvalifikation kunne ikke slettes");

                return Arr;
            }

        }
    }
   // public returnObj Nytlokale()
}
