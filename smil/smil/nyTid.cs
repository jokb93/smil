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
    public partial class nyTid : Form
    {
        public nyTid()
        {
            InitializeComponent();
            try
            {
                Kvalifikationer kval = new Kvalifikationer();
                returnObj arr = kval.selectKval();

                MySqlDataReader kvalReader = arr[1].ExecuteReader();

                while (kvalReader.Read())
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = kvalReader["navn"].ToString();
                    returnObj res = new returnObj(kvalReader["type"]);
                    res.Add(kvalReader["navn"]);
                    item.Value = res;
                    behandlingsBox.Items.Add(item);
                }
                Connect.Con.Close();

                behandlingsBox.SelectedIndex = 0;
            }
            catch
            {

            }
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
                    patientBox.Items.Add(item);
                }
                Connect.Con.Close();

                patientBox.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            startTid.SelectedIndex = 0;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = startTid.SelectedIndex;
            endBox.Items.Clear();
            endBox.Enabled = true;
            foreach(object item in startTid.Items)
            {
                int itemIndex = startTid.Items.IndexOf(item);
                if (index < itemIndex)
                {
                    endBox.Items.Add(item);
                }
            }
            endBox.Items.Add("16:00");
            endBox.SelectedIndex = 0;
        }

        private void endBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexOne = startTid.SelectedIndex + 1; // 6
            int indexTwo = endBox.SelectedIndex + indexOne; //3-1+6
            legeBox.Enabled = true;
            patientBox.Enabled = true;
            lokaleBox.Enabled = true;
            string dato = datoBox.Text;
            Connect.select("SELECT * FROM personale INNER JOIN behandlingspersonale ON personale.`id`=behandlingspersonale.`personaleid` INNER JOIN behandling ON behandlingspersonale.`behandlingsid`=behandling.`id` WHERE behandling.`start` < "+ indexOne + " AND behandling.`slut` > "+ indexOne + " AND `dato` = '"+ dato + "' OR behandling.`slut` > " + indexTwo + " AND behandling.`start` < " + indexTwo + " AND `dato` = '" + dato + "'");
            MySqlCommand cmd = Connect.cmd;
            MySqlDataReader reader = cmd.ExecuteReader();
            ArrayList list = new ArrayList();
            while (reader.Read())
            {
                list.Add(reader["personaleid"]);
            }
            Connect.Con.Close();

            try
            {
                Personale personer = new Personale();
                returnObj arr = personer.selectPersonale();

                MySqlDataReader personReader = arr[1].ExecuteReader();
                legeBox.Items.Clear();
                while (personReader.Read())
                {
                    
                    if (list.Contains(personReader["id"]))
                    {

                    }
                    else
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = personReader["navn"].ToString();
                        returnObj res = new returnObj(personReader["id"]);
                        res.Add(personReader["navn"]);
                        res.Add(personReader["titel"]);
                        item.Value = res;
                        legeBox.Items.Add(item);
                    }
                }
                Connect.Con.Close();

                int type = (behandlingsBox.SelectedItem as ComboboxItem).Value[0];
                foreach (object item in legeBox.Items)
                {
                    int id = (item as ComboboxItem).Value[0];
                    Personale personen = new Personale();
                    returnObj array = personen.selectKval(Convert.ToInt32(id));
                    MySqlDataReader kvalReader = array[1].ExecuteReader();
                    ArrayList listen = new ArrayList();
                    while (kvalReader.Read())
                    {
                        listen.Add(kvalReader["type"]);
                    }
                    if (listen.Contains(type))
                    {

                    } else
                    {
                        legeBox.Items.Remove(item);
                    }
                }

            }
            catch
            {

            }


            Connect.select("SELECT * FROM lokale INNER JOIN behandlingslokale ON lokale.`id`=behandlingslokale.`lokaleid` INNER JOIN behandling ON behandlingslokale.`behandlingid`=behandling.`id` WHERE behandling.`start` < " + indexOne + " AND behandling.`slut` > " + indexOne + " AND `dato` = '" + dato + "' OR behandling.`slut` > " + indexTwo + " AND behandling.`start` < " + indexTwo + " AND `dato` = '" + dato + "'");
            cmd = Connect.cmd;
            reader = cmd.ExecuteReader();
            list = new ArrayList();
            while (reader.Read())
            {
                list.Add(reader["lokaleid"]);
            }
            Connect.Con.Close();

            try
            {
                Lokale lokaler = new Lokale();
                returnObj arr = lokaler.selectLokale();

                MySqlDataReader lokaleReader = arr[1].ExecuteReader();
                lokaleBox.Items.Clear();
                while (lokaleReader.Read())
                {
                    if (list.Contains(lokaleReader["id"]))
                    {

                    }
                    else
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = lokaleReader["id"].ToString();
                        returnObj res = new returnObj(lokaleReader["id"]);
                        item.Value = res;
                        lokaleBox.Items.Add(item);
                    }
                }
                Connect.Con.Close();

                int type = (behandlingsBox.SelectedItem as ComboboxItem).Value[0];
                foreach (object item in lokaleBox.Items)
                {
                    int id = (item as ComboboxItem).Value[0];
                    Lokale lokale = new Lokale();
                    returnObj array = lokale.selectKval(Convert.ToInt32(id));
                    MySqlDataReader kvalReader = array[1].ExecuteReader();
                    ArrayList listen = new ArrayList();
                    while (kvalReader.Read())
                    {
                        listen.Add(kvalReader["type"]);
                    }
                    if (listen.Contains(type))
                    {

                    }
                    else
                    {
                        lokaleBox.Items.Remove(item);
                    }
                }
            }
            catch
            {

            }
            Connect.Con.Close();

        }

        private void behandlingsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void nyTid_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Behandling behandling = new Behandling();
            int patientId = (patientBox.SelectedItem as ComboboxItem).Value[0];
            int lokaleId = (lokaleBox.SelectedItem as ComboboxItem).Value[0];
            int personaleId = (legeBox.SelectedItem as ComboboxItem).Value[0];
            int start = startTid.SelectedIndex + 1;
            int slut = endBox.SelectedIndex + start;
            string dato = datoBox.Text;
            returnObj res = behandling.opretTid(patientId, dato, lokaleId, personaleId, start, slut);
            MessageBox.Show(res[1]);
            this.Close();
        }
    }
}
