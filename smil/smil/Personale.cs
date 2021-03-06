﻿using System;
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
    class Personale
    {
        public returnObj SletPersonale(int id)
        {

            try
            {

                if (Connect.query("DELETE FROM `SMIL`.`behandlingspersonale` WHERE `behandlingspersonale`.`behandlingsid` = " + id))
                {

                    if (Connect.query("DELETE FROM `SMIL`.`personale` WHERE `personale`.`id` = " + id))
                    {


                        returnObj Arr = new returnObj(8);  // type 8 er slet personale
                        Arr.Add("Personale slettet");

                        return Arr;

                    }
                    else
                    {
                        returnObj Arr = new returnObj(0);  // type 0 er fejlmelding
                        Arr.Add("Personalet har fremtidige behandlingstider");

                        return Arr;
                    }
                } else
                {
                    returnObj Arr = new returnObj(0);  // type 0 er fejlmelding
                    Arr.Add("Personalet har fremtidige behandlingstider");

                    return Arr;
                } 
                    
            }
            catch
            {
                returnObj Arr = new returnObj(0);  // type 0 er fejlmelding
                Arr.Add("Personale kunne ikke oprettes");

                return Arr;
            }
        }

        public returnObj NytPersonale(string navn, string titel)
        {

            try
            {

                if (Connect.query("INSERT INTO `SMIL`.`personale` (`navn`, `titel`) VALUES ('" + navn + "', '" + titel + "');"))
                {


                    returnObj Arr = new returnObj(1);  // type 1 er opret personale
                    Arr.Add("Personale er oprettet");


                    return Arr;

                }
                else
                {
                    returnObj Arr = new returnObj(0);  // type 0 er fejlmelding
                    Arr.Add("forbindelses fejl");

                    return Arr;
                }
            }
            catch
            {
                returnObj Arr = new returnObj(0);  // type 0 er fejlmelding
                Arr.Add("Personale kunne ikke oprettes");

                return Arr;
            }
        }
        public returnObj opretKval(int personaleId, int type)
        {

            try
            {

                if (Connect.query("INSERT INTO kvalifikationer (`type`, `personaleid`) VALUES ('" + type + "', '" + personaleId + "')"))
                {


                    returnObj Arr = new returnObj(11);  
                    Arr.Add("Kvalifikation tilføjet");

                    return Arr;

                }
                else
                {
                    returnObj Arr = new returnObj(0);  
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

        public returnObj sletKval(int personaleId, int type)
        {

            try
            {

                if (Connect.query("DELETE FROM `kvalifikationer` WHERE `type` = " + type + " AND `personaleid` = " + personaleId))
                {


                    returnObj Arr = new returnObj(11);  
                    Arr.Add("Kvalifikation slettet");

                    return Arr;

                }
                else
                {
                    returnObj Arr = new returnObj(0);  
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

        public returnObj delAllKval(int id)
        {
            if (Connect.query("DELETE FROM `kvalifikationer` WHERE `personaleid` = " + id))
            {
                
                returnObj Arr = new returnObj(11);
                Arr.Add("Kvalifikationer slettet");

                return Arr;
            } else
            {

                returnObj Arr = new returnObj(0);
                Arr.Add("Forbindelses fejl");

                return Arr;
            }
        }

        public returnObj retPersonale(string navn, string titel, int id)
        {
            if (Connect.query("UPDATE `SMIL`.`personale` SET `navn` = '" + navn + "', `titel` = '" + titel + "' WHERE `personale`.`id` = " + id))
            {


                returnObj Arr = new returnObj(11);  
                Arr.Add("Personale rettet");

                return Arr;

            }
            else
            {
                returnObj Arr = new returnObj(0);  
                Arr.Add("UPDATE `SMIL`.`personale` SET `navn` = '" + navn + "', `titel` = '" + titel + "' WHERE `personale`.`id` = " + id);

                return Arr;
            }
        }

        public returnObj selectPersonale()
        {
            if (Connect.select("SELECT * FROM `SMIL`.`personale`"))
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

        public returnObj selectKval(int id)
        {
            if (Connect.select("SELECT * FROM `kvalifikationer` INNER JOIN `kvalifikationsKatalog` ON `kvalifikationer` .`type`=`kvalifikationsKatalog`.`type` WHERE `kvalifikationer`.`personaleid` = " + id.ToString()))
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

    }

}