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
            OpretLokale nr1 = new OpretLokale();
            returnObj message = nr1.Nytlokale();
            resultHandler(message);
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
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opretBehandling behandling = new opretBehandling();
            DateTime date = DateTime.Now;
            resultHandler(behandling.opretTid(3,1, date,24,1));
        }


        private void button2_Click(object sender, EventArgs e)
        {
            OpretPersonale nr2 = new OpretPersonale();
            returnObj message = nr2.NytPersonale("johnny", "klinikassistent");
            MessageBox.Show(message[1]);
        }
    }
}
