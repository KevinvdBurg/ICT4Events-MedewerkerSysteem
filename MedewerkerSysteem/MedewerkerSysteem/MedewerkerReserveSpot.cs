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
    public partial class MedewerkerReserveSpot : Form
    {
        Administation administation = new Administation();
        List<CampingSpot> campingSpots = new List<CampingSpot>();
        List<Account> accounts = new List<Account>(); 
        private int number;
        private int CurrentEvent = 0;
        public MedewerkerReserveSpot(int CurrentEvent)
        {
            InitializeComponent();
            this.CurrentEvent = CurrentEvent;
            //todo find highest reserveID and add 1
            
            foreach (var item in administation.FindCampingSpotsAll())
            {
                int i = 0;
                foreach (var item2 in administation.FindReserveSpotsAll())
                {
                    if (item.LocationID == item2.CampingSpot.LocationID)
                    {
                        i++;
                    }
                }
                if (i < item.Category.MaxPerson)
                {
                    campingSpots.Add(item);
                    cbRSspotnumbers.Items.Add(item.SpotID);
                }
            }
            number = administation.FindHighestReserveID();
            nudRSreservationNumber.Minimum = number + 1;
            accounts = administation.FindAccountAll();
            foreach (var item in accounts)
            {
                cbRSname.Items.Add(item.Person.Email);
            }

            
        }

        private void btnRScancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRSreserve_Click(object sender, EventArgs e)
        {
            foreach (var item in campingSpots)
            {
                if (item.SpotID == Convert.ToInt32(cbRSspotnumbers.SelectedItem))
                {
                    CampingSpot campingSpot = item;
                    foreach (var item2 in accounts)
                    {
                        if (item2.Person.Email == cbRSname.SelectedItem.ToString())
                        {
                            Account account = item2;
                            administation.Add(new ReserveSpot(campingSpot, null, account, campingSpot.Category, dtpRSdateuit.Text, dtpRSdatein.Text, cbRSPaid.Checked, Convert.ToInt32(nudRSreservationNumber.Value)), CurrentEvent);
                            Close();
                        }
                    }
                }
            }
            

            
        }
    }
}
