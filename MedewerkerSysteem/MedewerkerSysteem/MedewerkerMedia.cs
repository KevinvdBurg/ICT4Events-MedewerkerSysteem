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
    public partial class MedewerkerMedia : Form
    {
        private Media currentMedia = null;
        public MedewerkerMedia(Media value)
        {
            InitializeComponent();
            currentMedia = value;
        }

        private void lblMreport_Click(object sender, EventArgs e)
        {

        }

        private void lblMFile_Click(object sender, EventArgs e)
        {

        }

        private void btnMcancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMdelete_Click(object sender, EventArgs e)
        {

        }

        private void MedewerkerMedia_Load(object sender, EventArgs e)
        {
            tbMname.Text = currentMedia.AccountName;
            rtbMtext.Text = currentMedia.Inhoud;
            tbFile.Text = currentMedia.Bestandlocatie;
            nudMreportcount.Value = currentMedia.AANTALREPORTS;
        }
    }
}
