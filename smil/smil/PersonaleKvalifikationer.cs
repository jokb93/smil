﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace smil
{
    public partial class PersonaleKvalifikationer : Form
    {
        public int id;

        public PersonaleKvalifikationer(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void alleKval_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
