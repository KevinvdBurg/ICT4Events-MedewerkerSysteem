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
    public partial class MedewerkerEvent : Form
    {
        Administation administation = new Administation();
        public MedewerkerEvent()
        {
            InitializeComponent();
        }

        private void btnRScancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRSreserve_Click(object sender, EventArgs e)
        {
            Address address = new Address(tbEcity.Text, tbEcountry.Text, tbEstreetname.Text, tbEzipcode.Text);
            Location location = new Location(address, tbElocation.Text);
            Event newEvent = new Event(location, Convert.ToInt32(nudEmaxvisitors.Value), tbEname.Text, Convert.ToInt32(nudEid.Value), Convert.ToString(dtpEdatestart), Convert.ToString(dtpEdateend));

            administation.AddEvent(newEvent);
            location.AddAddress(address);
        }
    }
}
