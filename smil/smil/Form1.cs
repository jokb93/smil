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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connect k1 = Connect.Conn();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            returnObj arr = new returnObj(0);
            arr.Add("tekst");
            if(arr[0] == 0)
            {
                label1.Text = arr[1];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpretLokale nr1 = new OpretLokale();
            returnObj message = nr1.Nytlokale();
            resultHandler(message);
        }

        private void resultHandler(returnObj result)
        {

            if(result[0]  == 0)
            {
                // Fejlmelding
                MessageBox.Show(result[1]);
            }

        }

    }
}
