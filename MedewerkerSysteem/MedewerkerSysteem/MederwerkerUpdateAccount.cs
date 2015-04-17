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
            tbUAlastname.Text = UpdateAccount.Person.Name;
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
            //todo Update query
            Close();
        }
    }
}
