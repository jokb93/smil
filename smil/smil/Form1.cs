﻿using System;
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
        }

        private void resultHandler(returnObj res)
        {

            if (res[0] == 0)
            {
                // Fejlmelding
                MessageBox.Show(res[1]);
            }
            else if (res[0] == 2)
            {
                MessageBox.Show(res[1]);
            }
            else if (res[0] == 3)
            {
                MessageBox.Show(res[1]);
            }
            else if (res[0] == 8)
            {
                MessageBox.Show(res[1]);
            }
            else if (res[0] == 10)
            {
                MessageBox.Show(res[1]);
            }
            else if (res[0] == 11)
            {
                MessageBox.Show(res[1]);
            }

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Lokale lokale = new Lokale();
            resultHandler(lokale.sletKval(24,1));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Personale nr3 = new Personale();
            resultHandler(nr3.SletPersonale(3));
        }
    }
}
