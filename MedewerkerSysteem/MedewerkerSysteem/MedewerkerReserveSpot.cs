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
        public MedewerkerReserveSpot()
        {
            InitializeComponent();
            //todo find highest reserveID and add 1
            
        }

        private void btnRScancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRSreserve_Click(object sender, EventArgs e)
        {
            
            //ReserveSpot reserveSpot = new ReserveSpot();
        }
    }
}
