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
    public partial class ConfirmLokaleDelete : Form
    {

        int id;

        public ConfirmLokaleDelete(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void ConfirmLokaleDelete_Load(object sender, EventArgs e)
        {

        }

        private void nej_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ja_Click(object sender, EventArgs e)
        {
            Lokale lokale = new Lokale();
            returnObj arr = lokale.sletLokale(this.id);
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
    }
}
