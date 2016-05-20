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
            arbejder.Visible = false;
            arbejder.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personale person = new Personale();
            returnObj res = person.retPersonale("Martin Hanse", "Elev", 2);
            MessageBox.Show(res[1]);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            arbejder.Visible = true;
            PersonaleForm form = new PersonaleForm();
            form.FormClosed += new FormClosedEventHandler(ChildFormClosed);
            form.Show();
        }

        void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            arbejder.Visible = false;
        }
    }
}
