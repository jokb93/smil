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
            dato.Text = reader["dato"].ToString();
        }

        private void BehandlingsInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
