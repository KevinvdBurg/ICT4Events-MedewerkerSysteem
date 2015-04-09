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
        public MedewerkerReserveSpot()
        {
            InitializeComponent();
        }

        private void btnRScancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
