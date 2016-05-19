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

        public returnObj Fakt(double[] pris, string[] behandling, string[] kundeinfo)
        {
            //kundeinfo pladser [navn, adresse, postnummer, by, kundenr, fakturanr, dato]
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
                    string b4 = kundeinfo[3].PadRight(51);
                    sw.Write(b);
                    sw.WriteLine("Kundenr:    " + kundeinfo[4]);
                    sw.Write(b2);
                    sw.WriteLine("Fakturanr:  " + kundeinfo[5]);
                    sw.Write(b3);
                    sw.WriteLine("Dato:       " + kundeinfo[6]);
                    sw.Write(b4);
                    sw.WriteLine("");
                    sw.WriteLine("");
                    sw.WriteLine("-------------------------------------------------------------------------");
                    sw.WriteLine("Behandling                                                    Pris       ");
                    sw.WriteLine("-------------------------------------------------------------------------");
                    for (int i = 0; i < pris.Length; i++)
                    {
                        sw.Write(behandling[i].PadRight(61));
                        if (pris[i] < 10)
                        {
                            sw.WriteLine("    " + pris[i]);
                        }
                        else if (pris[i] < 100)
                        {
                            sw.WriteLine("   " + pris[i]);
                        }
                        else if (pris[i] < 1000)
                        {
                            sw.WriteLine("  " + pris[i]);
                        }
                        else if (pris[i] < 10000)
                        {
                            sw.WriteLine(" " + pris[i]);
                        }
                        else if (pris[i] < 100000)
                        {
                            sw.WriteLine(pris[i]);
                        }
                    }
                    int linjer = 35 - pris.Length;
                    for (int j = 0; j < linjer; j++)
                    {
                        sw.WriteLine("");
                    }
                    double samletpris = 0;
                    for (int x = 0; x < pris.Length; x++)
                    {
                        samletpris = samletpris + pris[x];
                    }
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