using System;
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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            arbejder.Visible = false;
            arbejder.Dock = DockStyle.Fill;


            ComboboxItem front = new ComboboxItem();
            front.Text = "Ingen valgt";
            returnObj frontres = new returnObj(0);
            frontres.Add("Ingen valgt");
            frontres.Add("Ingen valgt");
            front.Value = frontres;
            PersonaleDropdown.Items.Add(front);

            try
            {
                Personale personer = new Personale();
                returnObj arr = personer.selectPersonale();

                MySqlDataReader reader = arr[1].ExecuteReader();

                while (reader.Read())
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = reader["navn"].ToString();
                    returnObj res = new returnObj(reader["id"]);
                    res.Add(reader["navn"]);
                    res.Add(reader["titel"]);
                    item.Value = res;
                    PersonaleDropdown.Items.Add(item);
                }
                Connect.Con.Close();

                PersonaleDropdown.SelectedIndex = 0;
            }
            catch
            {

            }


            ComboboxItem lokalefrist = new ComboboxItem();
            lokalefrist.Text = "Ingen valgt";
            returnObj lokalefristres = new returnObj(0);
            lokalefrist.Value = lokalefristres;
            LokaleDropdown.Items.Add(lokalefrist);

            try
            {
                Lokale lokale = new Lokale();
                returnObj arr = lokale.selectLokale();

                MySqlDataReader reader = arr[1].ExecuteReader();

                while (reader.Read())
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = reader["id"].ToString();
                    returnObj lokaleres = new returnObj(reader["id"]);
                    item.Value = lokaleres;
                    LokaleDropdown.Items.Add(item);
                }
                Connect.Con.Close();

                LokaleDropdown.SelectedIndex = 0;
            }
            catch
            {

            }


            ComboboxItem patientitem = new ComboboxItem();
            patientitem.Text = "Ingen Valgt";
            returnObj patientres = new returnObj(0);
            patientres.Add("Ingen Valgt");
            patientres.Add(00000000);
            patientres.Add("Ingen Valgt");
            patientres.Add(0000);
            patientitem.Value = patientres;
            PatientDropdown.Items.Add(patientitem);

            try
            {
                Patient patient = new Patient();
                returnObj arr = patient.selectPatient();

                MySqlDataReader reader = arr[1].ExecuteReader();

                while (reader.Read())
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = reader["navn"].ToString();
                    returnObj res = new returnObj(reader["id"]);
                    res.Add(reader["navn"]);
                    res.Add(reader["tlf"]);
                    res.Add(reader["adresse"]);
                    res.Add(reader["post"]);
                    item.Value = res;
                    PatientDropdown.Items.Add(item);
                }
                Connect.Con.Close();

                PatientDropdown.SelectedIndex = 0;
            }
            catch
            {

            }


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
            arbejder.Visible = true;
            KundeForm form = new KundeForm();
            form.FormClosed += new FormClosedEventHandler(ChildFormClosed);
            form.Show();
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

        private void lokaleknap_Click(object sender, EventArgs e)
        {
            arbejder.Visible = true;
            LokaleForm form = new LokaleForm();
            form.FormClosed += new FormClosedEventHandler(ChildFormClosed);
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            arbejder.Visible = true;
            KvalifikationsForm form = new KvalifikationsForm();
            form.FormClosed += new FormClosedEventHandler(ChildFormClosed);
            form.Show();
        }
    }
}
