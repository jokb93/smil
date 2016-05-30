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

        public returnObj opretTid(int patientid, string date, int lokaleId, int personaleId, int start, int slut)
        {
            if (Connect.query("INSERT INTO `SMIL`.`behandling` (`patientid`, `dato`, `start`, `slut`) VALUES ('" + patientid + "', '" + date + "', '" + start + "', '" + slut + "');"))
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

        public returnObj rediger(int id, int type, int patientid, DateTime date, int lokaleId, int personaleId, int min)
        {
            if (Connect.query("UPDATE `SMIL`.`behandling` SET `type` = '" + type + "', `patientid` = '" + patientid + "', `end` = '" + min + "', `dato` = '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE `behandling`.`id` = " + id + ""))
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

        public returnObj getAll(string personale, string lokale, string patient, string dato)
        {
            if (Connect.select("SELECT * FROM `behandling` INNER JOIN `behandlingspersonale` ON `behandlingspersonale`.behandlingsid=`behandling`.`id` INNER JOIN `behandlingslokale` ON `behandlingslokale`.behandlingid=`behandling`.`id` INNER JOIN `patient` ON `patient`.id=`behandling`.`patientid` WHERE `dato` = '" + dato + "' AND lokaleid LIKE '%" + lokale + "%' AND personaleid LIKE '%" + personale + "%' AND patientid LIKE '%" + patient + "%' "))
            {

                returnObj Arr = new returnObj(3);
                Arr.Add(Connect.cmd);
                Arr.Add("SELECT * FROM `behandling` INNER JOIN `behandlingspersonale` ON `behandlingspersonale`.behandlingsid=`behandling`.`id` INNER JOIN `behandlingslokale` ON `behandlingslokale`.behandlingid=`behandling`.`id` WHERE `dato` = '" + dato + "' AND lokaleid LIKE '%" + lokale + "%' AND personaleid LIKE '%" + personale + "%' AND patientid LIKE '%" + patient + "%' ");
                return Arr;
            }
            else
            {
                returnObj Arr = new returnObj(0);  // type 2 er opret lokale
                Arr.Add("forbindelses fejl");

                return Arr;
            }
        }

        public returnObj getSpecific(int id)
        {
            if (Connect.select("SELECT `post`,`adresse`,`pris`,`dato`,`behandlingsid`,`personale`.navn as personale,`patient`.id as kundenr, `kvalifikationsKatalog`.navn as behandlingsnavn, `patient`.navn as patient, lokaleid FROM `behandling` INNER JOIN `behandlingspersonale` ON `behandlingspersonale`.behandlingsid=`behandling`.`id` INNER JOIN `personale` ON `personale`.id=`behandlingspersonale`.`personaleid` INNER JOIN `behandlingslokale` ON `behandlingslokale`.behandlingid=`behandling`.`id` INNER JOIN `kvalifikationsKatalog` ON `kvalifikationsKatalog`.type=`behandling`.`type` INNER JOIN `patient` ON `patient`.id=`behandling`.`patientid` WHERE `behandlingsid` = " + id.ToString()))
            {

                returnObj Arr = new returnObj(3);
                Arr.Add(Connect.cmd);
                return Arr;
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
