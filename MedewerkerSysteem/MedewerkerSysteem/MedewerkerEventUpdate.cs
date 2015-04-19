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
    public partial class MedewerkerEventUpdate : Form
    {
        Event currentEvent = null;
        public MedewerkerEventUpdate(Event eventt)
        {
            InitializeComponent();
            currentEvent = eventt;
        }

        private void MedewerkerEventUpdate_Load(object sender, EventArgs e)
        {
            tbEname.Text = currentEvent.Name;
            tbElocation.Text = currentEvent.Location.Name;
            tbEzipcode.Text = currentEvent.Location.Address.ZipCode;
            nudEhuisnummer.Value = Convert.ToInt32(currentEvent.Location.Address.Number);
            nudEmaxvisitors.Value = Convert.ToInt32(currentEvent.MaxPerson);

        }
    }
}
