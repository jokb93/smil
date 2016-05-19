using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace smil
{
    class OpretBehandling
    {

        public returnObj opretTid(int type, int patientid, DateTime date, int lokaleId, int personaleId)
        {
            if (Connect.query("INSERT INTO `SMIL`.`behandling` (`id`, `type`, `patientid`, `dato`) VALUES (NULL, '" + type + "', '" + patientid + "', '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "');"))
            {
                int behandlingsId = Connect.insertID();
                if (Connect.query("INSERT INTO `SMIL`.`behandlingslokale` (`behandlingid`, `lokaleid`) VALUES ('"+ behandlingsId + "', '"+ lokaleId+ "');"))
                {
                    if (Connect.query("INSERT INTO `SMIL`.`behandlingspersonale` (`behandlingsid`, `personaleid`) VALUES ('" + behandlingsId + "', '" + personaleId + "');"))
                    {
                        returnObj Arr = new returnObj(3);  // type 3 er opret behandling
                        Arr.Add("Behandling oprettet");

                        return Arr;
                    }
                    else
                    {
                        returnObj Arr = new returnObj(0);  // type 2 er opret lokale
                        Arr.Add("forbindelses fejl");

                        return Arr;
                    }
                } else
                {
                    returnObj Arr = new returnObj(0);  // type 2 er opret lokale
                    Arr.Add("forbindelses fejl");

                    return Arr;
                }
                    

            }
            else
            {
                returnObj Arr = new returnObj(0);  // type 2 er opret lokale
                Arr.Add("forbindelses fejl");

                return Arr;
            }
        }
        
    }
}
