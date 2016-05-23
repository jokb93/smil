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
    public partial class PersonaleForm : Form
    {
        public PersonaleForm()
        {
            InitializeComponent();
            try {
                Personale personer = new Personale();
                returnObj arr = personer.selectPersonale();

                MySqlDataReader reader = arr[1].ExecuteReader();
                
                while (reader.Read())
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = reader["navn"].ToString();
                    returnObj res = new returnObj(reader["id"]);
                    res.Add(reader["navn"]);
                    res.Add(reader["stilling"]);
                    item.Value = res;
                    personaleDropdown.Items.Add(item);
                }
                Connect.Con.Close();

                personaleDropdown.SelectedIndex = 0;
            } catch
            {

            }
        }

        private void PersonaleForm_Load(object sender, EventArgs e)
        {

        }

        private void addRemoveKval_Click(object sender, EventArgs e)
        {
            PersonaleKvalifikationer form = new PersonaleKvalifikationer(1);
            form.FormClosed += new FormClosedEventHandler(kvalifikationLukket);
            form.Show();
        }

        void kvalifikationLukket(object sender, FormClosedEventArgs e)
        {
        }

        private void personaleDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (personaleDropdown.SelectedItem as ComboboxItem).Value[0];
            string navn = (personaleDropdown.SelectedItem as ComboboxItem).Value[1];
            string stilling = (personaleDropdown.SelectedItem as ComboboxItem).Value[2];
            navnBox.Text = navn;
            stillingBox.Text = stilling;
        }

        private void slet_Click(object sender, EventArgs e)
        {
            confirmPersonaleDelte form = new confirmPersonaleDelte(1);
            form.Text = "Slet personale - Simon pedersen";
            form.FormClosed += new FormClosedEventHandler(deletePerson);
            form.Show();
        }

        void deletePerson(object sender, FormClosedEventArgs e)
        {
        }

        private void navn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
