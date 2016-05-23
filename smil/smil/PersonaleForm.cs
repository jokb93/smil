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
    public partial class PersonaleForm : Form
    {
        public PersonaleForm()
        {
            InitializeComponent();
            try {
                Personale personer = new Personale();
                returnObj arr = personer.selectPersonale();

                var reader = arr[1];

                while (reader.Read())
                {
                    personaleDropdown.Items.Add(reader["navn"]);
                }

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
    }
}
