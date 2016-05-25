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
    public partial class ConfirmKvalDelete : Form
    {
        int id;
        public ConfirmKvalDelete(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void nej_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ja_Click(object sender, EventArgs e)
        {
            Kvalifikationer kval = new Kvalifikationer();
            returnObj arr = kval.sletKval(this.id);
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
