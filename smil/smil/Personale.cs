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

                if (Connect.query("DELETE FROM `SMIL`.`personale` WHERE id = "+ id + ";"))
                {


                    returnObj Arr = new returnObj(8);  // type 8 er slet personale
                    Arr.Add("Personale er slettet");

                    return Arr;

                }
                else
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

                if (Connect.query("INSERT INTO `SMIL`.`personale` (`navn`, `titel`) VALUES ('"+navn+"', '"+titel+"');"))
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
}
   // public returnObj NytPersonale()
}