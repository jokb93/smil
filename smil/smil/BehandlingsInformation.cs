using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;

namespace smil
{
    public partial class BehandlingsInformation : Form
    {
        int behandlingsId;
        string date;
        string adresse;
        string behandling;
        string navn;
        int pris;
        int kundenr;
        int post;
        int fakturanr;
        public BehandlingsInformation(int behandlingsId)
        {
            InitializeComponent();
            this.behandlingsId = behandlingsId;
            Behandling behandling = new Behandling();
            returnObj res = behandling.getSpecific(behandlingsId);
            MySqlDataReader reader = res[1].ExecuteReader();
            ArrayList list = new ArrayList();
            reader.Read();
            patient.Text = reader["patient"].ToString();
            personale.Text = reader["personale"].ToString();
            id.Text = behandlingsId.ToString();
            behandlingsnavn.Text = reader["behandlingsnavn"].ToString();
            lokale.Text = reader["lokaleid"].ToString();
            dato.Text = reader["dato"].ToString().Substring(0,10);
            date = reader["dato"].ToString().Substring(0, 10);
            pris = Convert.ToInt32(reader["pris"]);
            post = Convert.ToInt32(reader["post"]);
            adresse = reader["adresse"].ToString();
            navn = reader["patient"].ToString();
            kundenr = Convert.ToInt32(reader["kundenr"]);
            fakturanr = behandlingsId;
            this.behandling = reader["behandlingsnavn"].ToString();

        }

        private void BehandlingsInformation_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Faktura faktura = new Faktura();

                returnObj kundeArr = new returnObj(navn);
                kundeArr.Add(adresse);
                kundeArr.Add(post.ToString());
                kundeArr.Add(kundenr.ToString());
                kundeArr.Add(behandlingsId.ToString());
                kundeArr.Add(date);

                faktura.Fakt(pris, behandling, kundeArr);
                MessageBox.Show("Faktura udskrevet til skrivebord");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Faktura kunne ikke udskrives, prøv igen!");
            }
        }
    }
}
