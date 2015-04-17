using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;

namespace MedewerkerSysteem
{
    public partial class MederwerkerCreateAccount : Form
    {
        private Administation administration = new Administation();
        List<Event> events = new List<Event>();

        
        public MederwerkerCreateAccount()
        {
            InitializeComponent();

            events = administration.FindEventAll();
            cbCAaddevent.DataSource = events;
            cbCAaddevent.DisplayMember = "Name";
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCAcancel_Click(object sender, EventArgs e)
        {
            new MederwerkerForm(administration).Show();
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
            Account account = new Account(person, "bezoeker", test, tbCApassword.Text);
           
            foreach (Event item in lbCAeventlist.Items)
            {
                AccountEvent accountEvent = new AccountEvent(false, account.RFID, item.EventID);

            }

            //Account wordt opgeslagen in de database door administration.Add()
            administration.Add(account);
            //address wordt opgeslagen in de database door person.AddAddress()
            person.AddAddress(address);
            new MederwerkerForm(administration).Show();

        }

        private void btnCAaddevent_Click(object sender, EventArgs e)
        {
            //Geselecteerde event wordt toegevoegd aan de listbox
            if (cbCAaddevent.SelectedText != null || cbCAaddevent.SelectedText !="")
            {
                lbCAeventlist.Items.Add(cbCAaddevent.SelectedItem);
            }
            else
            {
                MessageBox.Show("Geen Event aangeklikt");
            }
            lbCAeventlist.DisplayMember = "Name";
        }

        private void MederwerkerCreateAccount_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}
