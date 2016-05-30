using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace smil
{
    class Faktura
    {

        public returnObj Fakt(int pris, string behandling, returnObj kundeinfo)
        {
            //kundeinfo pladser [navn, adresse, postnummer, kundenr, fakturanr, dato]
            try
            {
                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//fundet på gooooooooogle
                string path = @"" + desktop + "/Faktura - SMIL.txt";
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("                            Tandlægerne SMIL                             ");
                    sw.WriteLine("   Tandlægevej 5 - 8270 Højbjerg - TLF: +(45)00000112 - CVR: 48625878    ");
                    sw.WriteLine("-------------------------------------------------------------------------");
                    sw.WriteLine("");
                    sw.WriteLine("Faktura");
                    string b = kundeinfo[0].PadRight(51);
                    string b2 = kundeinfo[1].PadRight(51);
                    string b3 = kundeinfo[2].PadRight(51);
                    sw.Write(b);
                    sw.WriteLine("Kundenr:    " + kundeinfo[3]);
                    sw.Write(b2);
                    sw.WriteLine("Fakturanr:  " + kundeinfo[4]);
                    sw.Write(b3);
                    sw.WriteLine("Dato:       " + kundeinfo[5]);
                    sw.WriteLine("");
                    sw.WriteLine("");
                    sw.WriteLine("-------------------------------------------------------------------------");
                    sw.WriteLine("Behandling                                                    Pris       ");
                    sw.WriteLine("-------------------------------------------------------------------------");
                    sw.Write(behandling.PadRight(61));
                    if (pris < 10)
                    {
                        sw.WriteLine("    " + pris);
                    }
                    else if (pris < 100)
                    {
                        sw.WriteLine("   " + pris);
                    }
                    else if (pris < 1000)
                    {
                        sw.WriteLine("  " + pris);
                    }
                    else if (pris < 10000)
                    {
                        sw.WriteLine(" " + pris);
                    }
                    else if (pris < 100000)
                    {
                        sw.WriteLine(pris);
                    }
                    int linjer = 34;
                    for (int j = 0; j < linjer; j++)
                    {
                        sw.WriteLine("");
                    }
                    double samletpris = pris;
                    double prismoms = samletpris*1.25;
                    sw.WriteLine("-------------------------------------------------------------------------");
                    sw.WriteLine("                                            Pris før moms:   " + samletpris);
                    sw.WriteLine("                                            Pris efter moms: " + prismoms);
                    //sw.WriteLine("                                            Kunderabat:      ");
                    sw.WriteLine("                                            At betale:       " + prismoms);
                    sw.WriteLine("");
                    sw.WriteLine("");
                    sw.WriteLine("Betaling skal ske indenfor 8 dage efter bestillingsdato på");
                    sw.WriteLine("reg. nr. xxxx kontonr. xxxxxxxxxx");
                }
                returnObj Arr = new returnObj(10);  // type 10 er udskriv faktura
                Arr.Add("Faktura er oprettet");

                return Arr;
            }
            catch
            {
                returnObj Arr = new returnObj(0);  // type 0 er udskriv faktura
                Arr.Add("Faktura kunne ikke oprettes");

                return Arr;
            }
        }
    }
}