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
        private Administation administration = new Administation();
        List<Event> events = new List<Event>();
        
        public MederwerkerCreateAccount()
        {
            InitializeComponent();

            events = administration.FindEventAll();
            foreach (Event eventEvent in events)
            {
                cbCAaddevent.Items.Add(eventEvent.Name);
                
            }
            
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
            Account account = new Account(person, "bezoeker", test);

            //test int
            int i = 1;
            foreach (var item in lbCAeventlist.Items)
            {
                AccountEvent accountEvent = new AccountEvent(false, account.RFID, i++ /*EventID*/ );
                
            }

            //Account wordt opgeslagen in de database door administration.Add()
            administration.Add(account);
            //address wordt opgeslagen in de database door person.AddAddress()
            person.AddAddress(address);
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
        }
    }
}
