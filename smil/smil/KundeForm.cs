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
using System.Collections;

namespace smil
{
    public partial class KundeForm : Form
    {
        public KundeForm()
        {
            InitializeComponent();
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
                    personaleDropdown.Items.Add(item);
                }
                Connect.Con.Close();

                personaleDropdown.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nytPersonale_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.NyPatient();
            int id = Convert.ToInt32(Connect.cmd.LastInsertedId);
            ComboboxItem item = new ComboboxItem();
            item.Text = "Ny patient";
            returnObj res = new returnObj(id);
            res.Add("Ny patient");
            res.Add("00000000");
            res.Add("ny vej 1");
            res.Add("0000");
            item.Value = res;
            int personaleid = personaleDropdown.Items.Add(item);
            personaleDropdown.SelectedIndex = personaleid;
        }

        private void personaleDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (personaleDropdown.SelectedItem as ComboboxItem).Value[0];
            string navn = (personaleDropdown.SelectedItem as ComboboxItem).Value[1];
            int tlf = Convert.ToInt32((personaleDropdown.SelectedItem as ComboboxItem).Value[2]);
            string adresse = (personaleDropdown.SelectedItem as ComboboxItem).Value[3];
            int post = Convert.ToInt32((personaleDropdown.SelectedItem as ComboboxItem).Value[4]);
            navnBox.Text = navn;
            telefon.Text = tlf.ToString();
            adresseBox.Text = adresse;
            postnr.Text = post.ToString();
            Connect.Con.Close();
        }

        private void slet_Click(object sender, EventArgs e)
        {
            int id = (personaleDropdown.SelectedItem as ComboboxItem).Value[0];
            confirmPatientDelete form = new confirmPatientDelete(id);
            string navn = (personaleDropdown.SelectedItem as ComboboxItem).Value[1];
            form.Text = "Slet patient - " + navn;
            form.FormClosed += new FormClosedEventHandler(deletePerson);
            form.Show();
        }

        void deletePerson(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Gem_Click(object sender, EventArgs e)
        {
            string navn = navnBox.Text;
            string adresse = adresseBox.Text;
            string tlf = telefon.Text;
            string post = postnr.Text;
            int id = (personaleDropdown.SelectedItem as ComboboxItem).Value[0];
            Patient patient = new Patient();

            patient.retPatient(navn, tlf, adresse, Convert.ToInt32(post), id);
            
            MessageBox.Show("Ændringer er gemt");
            this.Close();
        }

        private void KundeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
