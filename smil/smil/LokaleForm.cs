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
    public partial class LokaleForm : Form
    {
        public LokaleForm()
        {
            InitializeComponent();
            try
            {
                Lokale lokale = new Lokale();
                returnObj arr = lokale.selectLokale();

                MySqlDataReader reader = arr[1].ExecuteReader();

                while (reader.Read())
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = reader["id"].ToString();
                    returnObj res = new returnObj(reader["id"]);
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

        private void personaleDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (personaleDropdown.SelectedItem as ComboboxItem).Value[0];
            Lokale lokale = new Lokale();
            returnObj MemArr = lokale.selectKval(id);
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

        private void nytPersonale_Click(object sender, EventArgs e)
        {
            Lokale lokale = new Lokale();
            lokale.Nytlokale();
            int id = Convert.ToInt32(Connect.cmd.LastInsertedId);
            ComboboxItem item = new ComboboxItem();
            item.Text = id.ToString();
            returnObj res = new returnObj(id);
            item.Value = res;
            int lokaleid = personaleDropdown.Items.Add(item);
            personaleDropdown.SelectedIndex = lokaleid;
        }

        private void slet_Click(object sender, EventArgs e)
        {
            int id = (personaleDropdown.SelectedItem as ComboboxItem).Value[0];
            ConfirmLokaleDelete form = new ConfirmLokaleDelete(id);
            form.Text = "Slet lokale - " + id;
            form.FormClosed += new FormClosedEventHandler(deletelokale);
            form.Show();
        }

        void deletelokale(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Gem_Click(object sender, EventArgs e)
        {
            int id = (personaleDropdown.SelectedItem as ComboboxItem).Value[0];
            Lokale lokale = new Lokale();

            lokale.delAllKval(id);


            foreach (object item in kvalifikationer.CheckedItems)
            {
                int kvalid = (item as ComboboxItem).Value[0];
                lokale.opretKval(id, kvalid);
            }

            MessageBox.Show("Ændringer er gemt");
            this.Close();
        }

        private void LokaleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
