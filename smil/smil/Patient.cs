using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace smil
{
    class Patient
    {
        public returnObj NyPatient()
        {
            try
            {

                if (Connect.query("INSERT INTO `SMIL`.`patient` (`id`, `tlf`, `adresse`, `navn`, `post`) VALUES (NULL, '00000000', 'ny vej 1', 'Ny patient', '0000');"))
                {


                    returnObj Arr = new returnObj(2);  // type 2 er opret lokale
                    Arr.Add("Patient oprettet");

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
                Arr.Add("Patient kunne ikke oprettes");

                return Arr;
            }

        }

        public returnObj sletPatient(int patientId)
        {

            try
            {

                if (Connect.query("DELETE FROM `patient` WHERE `id` = " + patientId))
                {


                    returnObj Arr = new returnObj(11);  // type 2 er opret lokale
                    Arr.Add("Patient slettet");

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
                Arr.Add("Patient kunne ikke slettes");

                return Arr;
            }

        }

        public returnObj selectPatient()
        {
            if (Connect.select("SELECT * FROM `SMIL`.`patient`"))
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

        public returnObj retPatient(string navn, string tlf, string adresse, int post, int id)
        {
            if (Connect.query("UPDATE `SMIL`.`patient` SET `tlf` = '"+tlf+"', `adresse` = '"+adresse+"', `navn` = '"+navn+"', `post` = '"+post+"' WHERE `patient`.`id` = "+id+";"))
            {


                returnObj Arr = new returnObj(11);
                Arr.Add("Patient rettet");

                return Arr;

            }
            else
            {
                returnObj Arr = new returnObj(0);
                Arr.Add("Fejl i forbindelse");

                return Arr;
            }
        }

    }

}
