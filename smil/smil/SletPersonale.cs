<<<<<<< Updated upstream:smil/smil/SletPersonale.cs
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
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace smil
{
    class OpretLokale
    {
        public returnObj Nytlokale()
        {
            try
            {                    // Query for at oprette nyt lokale
                if (Connect.query("INSERT INTO `SMIL`.`lokale` (`id`) VALUES (NULL);"))
                {
                    returnObj Arr = new returnObj(2);  // type 2 er opret lokale
                    Arr.Add("Lokalet er oprettet");

                    return Arr; //Den retunere vores dynamiske array
                }
                else
                {
                    returnObj Arr = new returnObj(2);  // type 2 er opret lokale


                    Arr.Add("forbindelses fejl");

                    return Arr; //Den retunere vores dynamiske array
                }
            }
            catch
            {
                returnObj Arr = new returnObj(0);  // type 0 er fejlmelding
                Arr.Add("Lokale kunne ikke oprettes");

                return Arr; //Den retunere vores dynamiske array
            }
        }
    }
}

>>>>>>> Stashed changes:smil/smil/OpretLokale.cs
