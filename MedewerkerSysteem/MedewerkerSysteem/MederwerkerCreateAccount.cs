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
            int test = 1;
            Address address = new Address(tbCAcity.Text, tbCAcountry.Text, tbCAstreetname.Text, tbCAzipcode.Text);
            Person person = new Person(address, tbCAemail.Text, tbCAname.Text, tbCAlastname.Text);
            Account account = new Account(person, test);
        }

        private void btnCAaddevent_Click(object sender, EventArgs e)
        {

        }
    }
}
