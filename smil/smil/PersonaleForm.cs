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
                    res.Add(reader["titel"]);
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
            Personale member = new Personale();
            returnObj MemArr = member.selectKval(id);
            MySqlDataReader reader = MemArr[1].ExecuteReader();
            kvalifikationer.Items.Clear();
            ArrayList Current = new ArrayList();
            while (reader.Read())
            {
                Current.Add(reader["type"]);
            }
            Connect.Con.Close();

            Kvalifikationer kval = new Kvalifikationer();
            
            returnObj returnarr = kval.selectKval();

            MySqlDataReader kvalreader = returnarr[1].ExecuteReader();
            while (kvalreader.Read())
            {
                ComboboxItem kvali = new ComboboxItem();
                kvali.Text = kvalreader["navn"].ToString();
                returnObj res = new returnObj(kvalreader["type"]);
                kvali.Value = res;
                int curindex = kvalifikationer.Items.Add(kvali);
                if (Current.Contains(kvalreader["type"]))
                {
                    kvalifikationer.SetItemChecked(curindex, true);
                }
            }
            Connect.Con.Close();
        }

        private void slet_Click(object sender, EventArgs e)
        {
            int id = (personaleDropdown.SelectedItem as ComboboxItem).Value[0];
            confirmPersonaleDelte form = new confirmPersonaleDelte(id);
            string navn = (personaleDropdown.SelectedItem as ComboboxItem).Value[1];
            form.Text = "Slet personale - "+ navn;
            form.FormClosed += new FormClosedEventHandler(deletePerson);
            form.Show();
        }

        void deletePerson(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void navn_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kvalifikationer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Kvalifikationer_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Gem_Click(object sender, EventArgs e)
        {
            string navn = navnBox.Text;
            string stilling = stillingBox.Text;
            int id = (personaleDropdown.SelectedItem as ComboboxItem).Value[0];
            Personale person = new Personale();

            returnObj arr = person.retPersonale(navn, stilling, id);

            person.delAllKval(id);
           

            foreach (object item in kvalifikationer.CheckedItems)
            {
                int kvalid = (item as ComboboxItem).Value[0];
                person.opretKval(id, kvalid);
            }

            MessageBox.Show("Ændringer er gemt");
            this.Close();
        }

        private void nytPersonale_Click(object sender, EventArgs e)
        {
            Personale person = new Personale();
            person.NytPersonale("Nyt Personale", "Personaletitel");
            int id = Convert.ToInt32(Connect.cmd.LastInsertedId);
            ComboboxItem item = new ComboboxItem();
            item.Text = "Nyt Personale";
            returnObj res = new returnObj(id);
            res.Add("Nyt Personale");
            res.Add("Personaletitel");
            item.Value = res;
            int personaleid = personaleDropdown.Items.Add(item);
            personaleDropdown.SelectedIndex = personaleid;
        }
    }
}
