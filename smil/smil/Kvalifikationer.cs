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
    }
}
