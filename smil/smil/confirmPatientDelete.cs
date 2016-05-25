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
    public partial class confirmPatientDelete : Form
    {
        public int id;
        public confirmPatientDelete(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void confirmPatientDelete_Load(object sender, EventArgs e)
        {

        }

        private void ja_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            returnObj arr = patient.sletPatient(this.id);
            if (arr[0] == 0)
            {
                MessageBox.Show(arr[1]);
            }
            else
            {
                MessageBox.Show(arr[1]);
            }
            this.Close();
        }

        private void nej_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
