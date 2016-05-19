using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace smil
{
    class Behandling
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

        public returnObj rediger(int id, int type, int patientid, DateTime date, int lokaleId, int personaleId)
        {
            if (Connect.query("UPDATE `SMIL`.`behandling` SET `type` = '" + type + "', `patientid` = '" + patientid + "', `dato` = '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE `behandling`.`id` = " + id + ""))
            {
                int behandlingsId = Connect.insertID();
                if (Connect.query("UPDATE `SMIL`.`behandlingslokale` SET `lokaleid` = '"+ lokaleId + "' WHERE `behandlingslokale`.`behandlingid` = " + id + ""))
                {
                    if (Connect.query("UPDATE `SMIL`.`behandlingspersonale` SET `personaleid` = '"+ personaleId + "' WHERE `behandlingspersonale`.`behandlingsid` = " + id + ""))
                    {
                        returnObj Arr = new returnObj(3);  // type 3 er opret behandling
                        Arr.Add("Behandling rettet");

                        return Arr;
                    }
                    else
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
            else
            {
                returnObj Arr = new returnObj(0);  // type 2 er opret lokale
                Arr.Add("forbindelses fejl");

                return Arr;
            }
        }
        
    }
}
