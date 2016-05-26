using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smil
{
    class Kvalifikationer
    {
        public returnObj opret(string navn)
        {
            if (Connect.query("INSERT INTO `SMIL`.`kvalifikationsKatalog` (`navn`) VALUES ('"+navn+"');"))
            {
                returnObj Arr = new returnObj(10);  // type 3 er opret behandling
                Arr.Add("Kvalifikation oprettet");

                return Arr;
            } else
            {
                returnObj Arr = new returnObj(0);  // type 3 er opret behandling
                Arr.Add("Kvalifikation kunne ikke oprettes");

                return Arr;
            }
        }

        public returnObj selectKval()
        {
            if (Connect.select("SELECT * FROM `kvalifikationsKatalog`"))
            {


                returnObj Arr = new returnObj(12);
                Arr.Add(Connect.cmd);
                return Arr;

            }
            else
            {
                returnObj Arr = new returnObj(0);
                Arr.Add("forbindelses fejl");

                return Arr;
            }
        }

        public returnObj selectKvalification(int id)
        {
            if (Connect.select("SELECT * FROM `kvalifikationsKatalog` WHERE type = "+id))
            {


                returnObj Arr = new returnObj(12);
                Arr.Add(Connect.cmd);
                return Arr;

            }
            else
            {
                returnObj Arr = new returnObj(0);
                Arr.Add("forbindelses fejl");

                return Arr;
            }
        }

        public returnObj retKvalifikation(string navn, decimal pris, int id)
        {
            if (Connect.query("UPDATE `SMIL`.`kvalifikationsKatalog` SET `navn` = '" + navn + "', `pris` = '" + pris + "' WHERE `kvalifikationsKatalog`.`type` = " + id))
            {


                returnObj Arr = new returnObj(11);
                Arr.Add("Personale rettet");

                return Arr;

            }
            else
            {
                returnObj Arr = new returnObj(0);
                Arr.Add("Forbindelses fejl");

                return Arr;
            }
        }

        public returnObj sletKval(int id)
        {

            try
            {

                if (Connect.query("DELETE FROM `kvalifikationsKatalog` WHERE `type` = " + id))
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
}
