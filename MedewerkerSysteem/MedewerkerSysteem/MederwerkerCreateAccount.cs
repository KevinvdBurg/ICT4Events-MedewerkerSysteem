using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedewerkerSysteem
{
    public partial class MederwerkerCreateAccount : Form
    {
        Administation administration = new Administation();
        public MederwerkerCreateAccount()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCAcancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        
        private void btnCAcreate_Click(object sender, EventArgs e)
        {
            //tijdelijke int ipv RFID
            string test = "test";
            //Adres wordt aangemaakt
            Address address = new Address(tbCAcity.Text, tbCAcountry.Text, tbCAstreetname.Text, tbCAzipcode.Text);
            //Persoon wordt aangemaakt
            Person person = new Person(address, tbCAemail.Text, tbCAname.Text, tbCAlastname.Text);
            //Account wordt aangemaakt
            Account account = new Account(person, test);

            //Account wordt opgeslagen in de database door administration.Add()
            administration.Add(account);
            //address wordt opgeslagen in de database door person.AddAddress()
            person.AddAddress(address);
        }

        private void btnCAaddevent_Click(object sender, EventArgs e)
        {
            //Geselecteerde event wordt toegevoegd aan de listbox
            if (cbCAaddevent.SelectedText != null)
            {
                lbCAeventlist.Items.Add(cbCAaddevent.SelectedValue);
                //TODO create accountevent
            }
        }
    }
}
