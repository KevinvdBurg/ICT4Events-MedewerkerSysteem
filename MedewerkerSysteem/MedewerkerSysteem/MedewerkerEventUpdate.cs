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

        Administation administation = new Administation();
        public MedewerkerEventUpdate(Event eventt)
        {
            InitializeComponent();
            currentEvent = eventt;
        }

        private void MedewerkerEventUpdate_Load(object sender, EventArgs e)
        {
            tbEname.Text = currentEvent.Name;
            tbEcity.Text = currentEvent.Location.Address.City;
            tbEzipcode.Text = currentEvent.Location.Address.ZipCode;
            nudEhuisnummer.Value = Convert.ToInt32(currentEvent.Location.Address.Number);
            nudEmaxvisitors.Value = Convert.ToInt32(currentEvent.MaxPerson);

        }

        /// <summary>
        /// Update een bestaand event met alle gegevens data in de textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnECreateEvent_Click(object sender, EventArgs e)
        {
            Event TempEvent = new Event(new Location(new Address(tbEcity.Text, Convert.ToString(nudEhuisnummer.Value), tbEzipcode.Text), tbEcity.Text), Convert.ToInt32(nudEmaxvisitors.Value), tbEname.Text, currentEvent.EventID, currentEvent.BeginTime, currentEvent.EndTime);
            administation.UpdateEvent(TempEvent, currentEvent.Location.Address.ZipCode, Convert.ToInt32(currentEvent.Location.Address.Number));
            Close();
        }

        private void btnECancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
