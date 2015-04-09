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
    public partial class MederwerkerForm : Form
    {
        public MederwerkerForm()
        {
            InitializeComponent();
        }

        private void lblFuction_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Buttons

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            MederwerkerCreateAccount CA = new MederwerkerCreateAccount();
            CA.Show();
        }

        private void btnReserveItem_Click(object sender, EventArgs e)
        {
            MedewerkerReserveItem IR = new MedewerkerReserveItem();
            IR.Show();
        }

        private void btnReserveLocation_Click(object sender, EventArgs e)
        {
            MedewerkerReserveSpot SR = new MedewerkerReserveSpot();
            SR.Show();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            MedewerkerEvent E = new MedewerkerEvent();
            E.Show();
        }
    }
}
