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
    public partial class MedewerkerLogin : Form
    {
        Administation administration = new Administation();
        public MedewerkerLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = lblLoginEmail.Text;
            string password = lblLoginPassword.Text;

            if (administration.Login(email, password))
            {
                MederwerkerForm MF = new MederwerkerForm();
                Close(); 
                MF.Show();
            }
            else
            {
                MessageBox.Show("Er is iets mis gegaan");
            }
            
        }
    }
}
