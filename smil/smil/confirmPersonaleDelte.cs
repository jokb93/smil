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
    public partial class confirmPersonaleDelte : Form
    {

        int id;

        public confirmPersonaleDelte(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void confirmPersonaleDelte_Load(object sender, EventArgs e)
        {

        }

        private void ja_Click(object sender, EventArgs e)
        {
            Personale personale = new Personale();
            returnObj arr = personale.SletPersonale(this.id);
            if(arr[0] == 0)
            {
                MessageBox.Show(arr[1]);
            } else
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
