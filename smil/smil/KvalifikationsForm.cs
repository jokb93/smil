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
    public partial class KvalifikationsForm : Form
    {
        public KvalifikationsForm()
        {
            InitializeComponent();
            try
            {
                Kvalifikationer kval = new Kvalifikationer();
                returnObj arr = kval.selectKval();

                MySqlDataReader reader = arr[1].ExecuteReader();

                while (reader.Read())
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = reader["navn"].ToString();
                    returnObj res = new returnObj(reader["type"]);
                    res.Add(reader["navn"]);
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

        private void KvalifikationsForm_Load(object sender, EventArgs e)
        {

        }

        private void personaleDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (personaleDropdown.SelectedItem as ComboboxItem).Value[0];
            Kvalifikationer kval = new Kvalifikationer();
            returnObj MemArr = kval.selectKvalification(id);
            MySqlDataReader reader = MemArr[1].ExecuteReader();
            reader.Read();
            navnBox.Text = reader["navn"].ToString();
            Connect.Con.Close();
        }

        private void Gem_Click(object sender, EventArgs e)
        {
            int id = (personaleDropdown.SelectedItem as ComboboxItem).Value[0];
            Kvalifikationer kval = new Kvalifikationer();
            string navn = navnBox.Text;
            kval.retKvalifikation(navn, id);
            
            MessageBox.Show("Ændringer er gemt");
            this.Close();
        }

        private void nytPersonale_Click(object sender, EventArgs e)
        {
            Kvalifikationer kval = new Kvalifikationer();
            kval.opret("Ny kvalifikation");
            int id = Convert.ToInt32(Connect.cmd.LastInsertedId);
            ComboboxItem item = new ComboboxItem();
            item.Text = "Ny kvalifikation";
            returnObj res = new returnObj(id);
            res.Add("Ny kvalifikation");
            item.Value = res;
            int lokaleid = personaleDropdown.Items.Add(item);
            personaleDropdown.SelectedIndex = lokaleid;
        }

        private void slet_Click(object sender, EventArgs e)
        {
            int id = (personaleDropdown.SelectedItem as ComboboxItem).Value[0];
            string navn = (personaleDropdown.SelectedItem as ComboboxItem).Value[1];
            ConfirmKvalDelete form = new ConfirmKvalDelete(id);
            form.Text = "Slet Kvalifikation - " + navn;
            form.FormClosed += new FormClosedEventHandler(deletelokale);
            form.Show();
        }

        void deletelokale(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
