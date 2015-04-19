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
    public partial class MederwerkerUpdateAccount : Form
    {
        private Account UpdateAccount = new Account();
        private Administation administration = new Administation();
        
        List<Event> events = new List<Event>();

        private DBEvent dbevent = new DBEvent();
        public MederwerkerUpdateAccount(Account account)
        {
            InitializeComponent();
            UpdateAccount = account;
            events = administration.FindEventAll();
            cbUAaddevent.DataSource = events;
            cbUAaddevent.DisplayMember = "Name";

            

        }

        private void MederwerkerUpdateAccount_Load(object sender, EventArgs e)
        {
            tbUAname.Text = UpdateAccount.Person.Name;
            tbUAlastname.Text = UpdateAccount.Person.LastName;
            tbUAemail.Text = UpdateAccount.Person.Email;
            tbUApassword.Text = UpdateAccount.Wachtwoord;
            tbUArepassword.Text = UpdateAccount.Wachtwoord;
            tbUAzipcode.Text = UpdateAccount.Person.Address.ZipCode;
            nudUAnumber.Value = Convert.ToDecimal(UpdateAccount.Person.Address.Number);
            tbUAcity.Text = UpdateAccount.Person.Address.City;

            lbUAeventlist.DataSource = dbevent.SelectAllperAccount(UpdateAccount);
            lbUAeventlist.DisplayMember = "name";

            //todo 
            //get payment stat
        }

        private void btnCAcancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUAupdate_Click(object sender, EventArgs e)
        {
            //Adres wordt aangemaakt
            Address address = new Address(tbUAcity.Text, Convert.ToString(nudUAnumber.Value), tbUAzipcode.Text);
            //Persoon wordt aangemaakt
            Person person = new Person(address, tbUAnewemail.Text, tbUAname.Text, tbUAlastname.Text);
            //Account wordt aangemaakt
            Account account = new Account(person, "bezoeker",null, tbUApassword.Text);



            //Account wordt geupdate
            administration.Update(account, tbUAemail.Text);
            


            //address wordt opgeslagen in de database door person.AddAddress()
            person.AddAddress(address);

            foreach (Event item in lbUAeventlist.Items)
            {
                AccountEvent accountEvent = new AccountEvent(false, administration.FindAccountID(account.Person.Email), item.EventID);
                
                administration.Update(accountEvent);

            }

            Close();
        }
    }
}
