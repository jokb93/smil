using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smil
{
    public partial class BehandlingsInformation : Form
    {
        int behandlingsId;
        public BehandlingsInformation(int behandlingsId)
        {
            InitializeComponent();
            this.behandlingsId = behandlingsId;
        }

        private void BehandlingsInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
