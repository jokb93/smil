using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;
using System.IO;

namespace smil
{

    public partial class print : Form
    {
        public print()
        {
            InitializeComponent();
            arbejder.Visible = false;
            arbejder.Dock = DockStyle.Fill;


            //TIDER FILL

            ComboboxItem tid;
            returnObj tidarr;
            DateTime time = timePicker.Value;
            TimeSpan ts = new TimeSpan(7, 30, 0);
            time = time.Date + ts;

            for (int i = 0; i < 16; i++)
            {
                time = time.AddMinutes(30.00);
                tid = new ComboboxItem();
                tid.Text = time.ToString("HH:mm");
                tidarr = new returnObj(0);
                tidarr.Add(0);
                tidarr.Add(time.ToString("HH:mm"));
                tidarr.Add("Patient");
                tidarr.Add("Læge");
                tidarr.Add("lokale");
                tid.Value = tidarr;
                Tider.Items.Add(tid);
            }

            //TIDER FILL END


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
            string person;
            string patientid;
            string lokaleid;
            int personale = (PersonaleDropdown.SelectedItem as ComboboxItem).Value[0];
            if (personale == 0)
            {
                person = "";
            }
            else
            {
                person = personale.ToString();
            }
            int patient = (PatientDropdown.SelectedItem as ComboboxItem).Value[0];
            if (patient == 0)
            {
                patientid = "";
            }
            else
            {
                patientid = patient.ToString();
            }
            int lokale = (LokaleDropdown.SelectedItem as ComboboxItem).Value[0];
            if (lokale == 0)
            {
                lokaleid = "";
            }
            else
            {
                lokaleid = lokale.ToString();
            }
            string dato = timePicker.Text;
            Behandling behandling = new Behandling();
            returnObj res = behandling.getAll(person, lokaleid, patientid, dato);
            MySqlDataReader reader = res[1].ExecuteReader();
            ArrayList list = new ArrayList();
            while (reader.Read())
            {
                returnObj newlist = new returnObj(reader["navn"].ToString());
                newlist.Add(Convert.ToInt32(reader["behandlingsid"]));
                newlist.Add(Convert.ToInt32(reader["start"]));
                newlist.Add(Convert.ToInt32(reader["slut"]));
                list.Add(newlist);
            }

            ComboboxItem tid;
            returnObj tidarr;
            DateTime time = timePicker.Value;
            TimeSpan ts = new TimeSpan(7, 30, 0);
            time = time.Date + ts;
            Tider.Items.Clear();
            bool isgoing = false;
            int x = 0;
            for (int i = 0; i < 16; i++)
            {
                time = time.AddMinutes(30.00);
                try
                {
                    returnObj thisList = (returnObj)list[x];

                    if (thisList[2] == i)
                    {
                        tid = new ComboboxItem();
                        tid.Text = time.ToString("HH:mm") + " - " + thisList[0];
                        tidarr = new returnObj(thisList[1]);
                        tidarr.Add(time.ToString("HH:mm"));
                        tid.Value = tidarr;
                        isgoing = true;

                    }
                    else if (thisList[3] == i)
                    {
                        tid = new ComboboxItem();
                        tid.Text = time.ToString("HH:mm") + " - " + thisList[0];
                        tidarr = new returnObj(thisList[1]);
                        tidarr.Add(time.ToString("HH:mm"));
                        tid.Value = tidarr;
                        isgoing = false;
                        x++;
                    }
                    else
                    {
                        if (isgoing)
                        {
                            tid = new ComboboxItem();
                            tid.Text = time.ToString("HH:mm") + " - " + thisList[0];
                            tidarr = new returnObj(thisList[1]);
                            tidarr.Add(time.ToString("HH:mm"));
                            tid.Value = tidarr;
                        }
                        else
                        {
                            tid = new ComboboxItem();
                            tid.Text = time.ToString("HH:mm");
                            tidarr = new returnObj(0);
                            tidarr.Add(time.ToString("HH:mm"));
                            tid.Value = tidarr;
                        }
                    }


                    Tider.Items.Add(tid);

                    Connect.Con.Close();
                }
                catch
                {

                    tid = new ComboboxItem();
                    tid.Text = time.ToString("HH:mm");
                    tidarr = new returnObj(0);
                    tidarr.Add(time.ToString("HH:mm"));
                    tid.Value = tidarr;


                    Tider.Items.Add(tid);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            arbejder.Visible = true;
            nyTid form = new nyTid();
            form.FormClosed += new FormClosedEventHandler(ChildFormClosed);
            form.Show();
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

        private void Tider_MouseDoubleClick(object sender, EventArgs e)
        {
            try
            {
                int behandlingsId = (Tider.SelectedItem as ComboboxItem).Value[0];
                if (behandlingsId > 0)
                {
                    arbejder.Visible = true;
                    BehandlingsInformation form = new BehandlingsInformation(behandlingsId);
                    form.FormClosed += new FormClosedEventHandler(ChildFormClosed);
                    form.Show();
                }
            }
            catch
            {

            }
        }

        private void PersonaleDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string person;
            string patientid;
            string lokaleid;
            int personale = (PersonaleDropdown.SelectedItem as ComboboxItem).Value[0];
            if(personale == 0)
            {
                person = "";
            } else
            {
                person = personale.ToString();
            }
            int patient = (PatientDropdown.SelectedItem as ComboboxItem).Value[0];
            if (patient == 0)
            {
                patientid = "";
            }
            else
            {
                patientid = patient.ToString();
            }
            int lokale = (LokaleDropdown.SelectedItem as ComboboxItem).Value[0];
            if (lokale == 0)
            {
                lokaleid = "";
            }
            else
            {
                lokaleid = lokale.ToString();
            }
            string dato = timePicker.Text;
            Behandling behandling = new Behandling();
            returnObj res = behandling.getAll(person, lokaleid, patientid, dato);
            MySqlDataReader reader = res[1].ExecuteReader();
            ArrayList list = new ArrayList();
            while (reader.Read())
            {
                returnObj newlist = new returnObj(reader["navn"].ToString());
                newlist.Add(Convert.ToInt32(reader["behandlingsid"]));
                newlist.Add(Convert.ToInt32(reader["start"]));
                newlist.Add(Convert.ToInt32(reader["slut"]));
                list.Add(newlist);
            }

            ComboboxItem tid;
            returnObj tidarr;
            DateTime time = timePicker.Value;
            TimeSpan ts = new TimeSpan(7, 30, 0);
            time = time.Date + ts;
            Tider.Items.Clear();
            bool isgoing = false;
            int x = 0;
            for (int i = 0; i < 16; i++)
            {
                time = time.AddMinutes(30.00);
                try
                {
                    returnObj thisList = (returnObj)list[x];

                    if (thisList[2] == i)
                    {
                        tid = new ComboboxItem();
                        tid.Text = time.ToString("HH:mm") + " - " + thisList[0];
                        tidarr = new returnObj(thisList[1]);
                        tidarr.Add(time.ToString("HH:mm"));
                        tid.Value = tidarr;
                        isgoing = true;

                    } else if (thisList[3] == i)
                    {
                        tid = new ComboboxItem();
                        tid.Text = time.ToString("HH:mm") + " - " + thisList[0];
                        tidarr = new returnObj(thisList[1]);
                        tidarr.Add(time.ToString("HH:mm"));
                        tid.Value = tidarr;
                        isgoing = false;
                        x++;
                    }
                    else
                    {
                        if (isgoing)
                        {
                            tid = new ComboboxItem();
                            tid.Text = time.ToString("HH:mm") + " - " + thisList[0];
                            tidarr = new returnObj(thisList[1]);
                            tidarr.Add(time.ToString("HH:mm"));
                            tid.Value = tidarr;
                        }
                        else
                        {
                            tid = new ComboboxItem();
                            tid.Text = time.ToString("HH:mm");
                            tidarr = new returnObj(0);
                            tidarr.Add(time.ToString("HH:mm"));
                            tid.Value = tidarr;
                        }
                    }


                    Tider.Items.Add(tid);

                    Connect.Con.Close();
                }
                catch {
                    
                    tid = new ComboboxItem();
                    tid.Text = time.ToString("HH:mm");
                    tidarr = new returnObj(0);
                    tidarr.Add(time.ToString("HH:mm"));
                    tid.Value = tidarr;


                    Tider.Items.Add(tid);
                }
            }

        }

        private void LokaleDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string person;
            string patientid;
            string lokaleid;
            int personale = (PersonaleDropdown.SelectedItem as ComboboxItem).Value[0];
            if (personale == 0)
            {
                person = "";
            }
            else
            {
                person = personale.ToString();
            }
            int patient = (PatientDropdown.SelectedItem as ComboboxItem).Value[0];
            if (patient == 0)
            {
                patientid = "";
            }
            else
            {
                patientid = patient.ToString();
            }
            int lokale = (LokaleDropdown.SelectedItem as ComboboxItem).Value[0];
            if (lokale == 0)
            {
                lokaleid = "";
            }
            else
            {
                lokaleid = lokale.ToString();
            }
            string dato = timePicker.Text;
            Behandling behandling = new Behandling();
            returnObj res = behandling.getAll(person, lokaleid, patientid, dato);
            MySqlDataReader reader = res[1].ExecuteReader();
            ArrayList list = new ArrayList();
            while (reader.Read())
            {
                returnObj newlist = new returnObj(reader["navn"].ToString());
                newlist.Add(Convert.ToInt32(reader["behandlingsid"]));
                newlist.Add(Convert.ToInt32(reader["start"]));
                newlist.Add(Convert.ToInt32(reader["slut"]));
                list.Add(newlist);
            }

            ComboboxItem tid;
            returnObj tidarr;
            DateTime time = timePicker.Value;
            TimeSpan ts = new TimeSpan(7, 30, 0);
            time = time.Date + ts;
            Tider.Items.Clear();
            bool isgoing = false;
            int x = 0;
            for (int i = 0; i < 16; i++)
            {
                time = time.AddMinutes(30.00);
                try
                {
                    returnObj thisList = (returnObj)list[x];

                    if (thisList[2] == i)
                    {
                        tid = new ComboboxItem();
                        tid.Text = time.ToString("HH:mm") + " - " + thisList[0];
                        tidarr = new returnObj(thisList[1]);
                        tidarr.Add(time.ToString("HH:mm"));
                        tid.Value = tidarr;
                        isgoing = true;

                    }
                    else if (thisList[3] == i)
                    {
                        tid = new ComboboxItem();
                        tid.Text = time.ToString("HH:mm") + " - " + thisList[0];
                        tidarr = new returnObj(thisList[1]);
                        tidarr.Add(time.ToString("HH:mm"));
                        tid.Value = tidarr;
                        isgoing = false;
                        x++;
                    }
                    else
                    {
                        if (isgoing)
                        {
                            tid = new ComboboxItem();
                            tid.Text = time.ToString("HH:mm") + " - " + thisList[0];
                            tidarr = new returnObj(thisList[1]);
                            tidarr.Add(time.ToString("HH:mm"));
                            tid.Value = tidarr;
                        }
                        else
                        {
                            tid = new ComboboxItem();
                            tid.Text = time.ToString("HH:mm");
                            tidarr = new returnObj(0);
                            tidarr.Add(time.ToString("HH:mm"));
                            tid.Value = tidarr;
                        }
                    }


                    Tider.Items.Add(tid);

                    Connect.Con.Close();
                }
                catch
                {

                    tid = new ComboboxItem();
                    tid.Text = time.ToString("HH:mm");
                    tidarr = new returnObj(0);
                    tidarr.Add(time.ToString("HH:mm"));
                    tid.Value = tidarr;


                    Tider.Items.Add(tid);

                }
            }

        }

        private void PatientDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string person;
            string patientid;
            string lokaleid;
            int personale = (PersonaleDropdown.SelectedItem as ComboboxItem).Value[0];
            if (personale == 0)
            {
                person = "";
            }
            else
            {
                person = personale.ToString();
            }
            int patient = (PatientDropdown.SelectedItem as ComboboxItem).Value[0];
            if (patient == 0)
            {
                patientid = "";
            }
            else
            {
                patientid = patient.ToString();
            }
            int lokale = (LokaleDropdown.SelectedItem as ComboboxItem).Value[0];
            if (lokale == 0)
            {
                lokaleid = "";
            }
            else
            {
                lokaleid = lokale.ToString();
            }
            string dato = timePicker.Text;
            Behandling behandling = new Behandling();
            returnObj res = behandling.getAll(person, lokaleid, patientid, dato);
            MySqlDataReader reader = res[1].ExecuteReader();
            ArrayList list = new ArrayList();
            while (reader.Read())
            {
                returnObj newlist = new returnObj(reader["navn"].ToString());
                newlist.Add(Convert.ToInt32(reader["behandlingsid"]));
                newlist.Add(Convert.ToInt32(reader["start"]));
                newlist.Add(Convert.ToInt32(reader["slut"]));
                list.Add(newlist);
            }

            ComboboxItem tid;
            returnObj tidarr;
            DateTime time = timePicker.Value;
            TimeSpan ts = new TimeSpan(7, 30, 0);
            time = time.Date + ts;
            Tider.Items.Clear();
            bool isgoing = false;
            int x = 0;
            for (int i = 0; i < 16; i++)
            {
                time = time.AddMinutes(30.00);
                try
                {
                    returnObj thisList = (returnObj)list[x];

                    if (thisList[2] == i)
                    {
                        tid = new ComboboxItem();
                        tid.Text = time.ToString("HH:mm") + " - " + thisList[0];
                        tidarr = new returnObj(thisList[1]);
                        tidarr.Add(time.ToString("HH:mm"));
                        tid.Value = tidarr;
                        isgoing = true;

                    }
                    else if (thisList[3] == i)
                    {
                        tid = new ComboboxItem();
                        tid.Text = time.ToString("HH:mm") + " - " + thisList[0];
                        tidarr = new returnObj(thisList[1]);
                        tidarr.Add(time.ToString("HH:mm"));
                        tid.Value = tidarr;
                        isgoing = false;
                        x++;
                    }
                    else
                    {
                        if (isgoing)
                        {
                            tid = new ComboboxItem();
                            tid.Text = time.ToString("HH:mm") + " - " + thisList[0];
                            tidarr = new returnObj(thisList[1]);
                            tidarr.Add(time.ToString("HH:mm"));
                            tid.Value = tidarr;
                        }
                        else
                        {
                            tid = new ComboboxItem();
                            tid.Text = time.ToString("HH:mm");
                            tidarr = new returnObj(0);
                            tidarr.Add(time.ToString("HH:mm"));
                            tid.Value = tidarr;
                        }
                    }


                    Tider.Items.Add(tid);

                    Connect.Con.Close();
                }
                catch
                {

                    tid = new ComboboxItem();
                    tid.Text = time.ToString("HH:mm");
                    tidarr = new returnObj(0);
                    tidarr.Add(time.ToString("HH:mm"));
                    tid.Value = tidarr;


                    Tider.Items.Add(tid);
                }
            }

        }

        private void Tider_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int personale = (PersonaleDropdown.SelectedItem as ComboboxItem).Value[0];
            string personalenavn = (PersonaleDropdown.SelectedItem as ComboboxItem).Value[1];
            string dato = timePicker.Text;

            if (personale == 0)
            {
                MessageBox.Show("Vælg personale for at udskrive oversigt");
            }
            else
            {
                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//fundet på gooooooooogle
                string path = @"" + desktop + "/Oversigt - " + personalenavn + ".txt";
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Oversigt over tider " + dato + " for " + personalenavn);
                    sw.WriteLine();
                    foreach (ComboboxItem item in Tider.Items)
                    {
                        int id = item.Value[0];
                        if (id > 0)
                        {
                            Behandling behandling = new Behandling();
                            returnObj res = behandling.getSpecific(id);
                            MySqlDataReader reader = res[1].ExecuteReader();
                            reader.Read();
                            string lokale = reader["lokale"].ToString();
                            string behandlingsnavn = reader["behandlingsnavn"].ToString();
                            string text = item.Text;
                            sw.WriteLine(item + " - " + behandlingsnavn + " i lokale: " + lokale);
                        } else
                        {
                            sw.WriteLine(item);
                        }
                        Connect.Con.Close();
                    }
                }
                MessageBox.Show(personalenavn+"'s dagsplan er udskrevet til skrivebordet");
            }
        }
    }
}
