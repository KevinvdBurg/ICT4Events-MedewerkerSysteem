﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;

namespace MedewerkerSysteem
{
    public partial class MederwerkerCreateAccount : Form
    {
        
        private Administation administration = new Administation();
        List<Event> events = new List<Event>();

        
        public MederwerkerCreateAccount()
        {
            InitializeComponent();

            events = administration.FindEventAll();
            cbCAaddevent.DataSource = events;
            cbCAaddevent.DisplayMember = "Name";
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Sluit het MedewerkerCreateAccountForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCAcancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Maakt een account en een adres aan en stuurt deze door naar de database
        /// Ook wordt het form gesloten
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCAcreate_Click(object sender, EventArgs e)
        {
            //Adres wordt aangemaakt
            Address address = new Address(tbCAcity.Text, Convert.ToString(nudCAnumber.Value), tbCAzipcode.Text);
            //Persoon wordt aangemaakt
            Person person = new Person(address, tbCAemail.Text, tbCAname.Text, tbCAlastname.Text);
            //Account wordt aangemaakt
            Account account = new Account(person, "bezoeker", " ", tbCApassword.Text);
           
            

            //Account wordt opgeslagen in de database door administration.Add()
            administration.Add(account);
            //address wordt opgeslagen in de database door person.AddAddress()
            person.AddAddress(address);

            foreach (Event item in lbCAeventlist.Items)
            {
                AccountEvent accountEvent = new AccountEvent(false, administration.FindAccountID(account.Person.Email), item.EventID);
                administration.Add(accountEvent);

            }
            //MederwerkerForm MF = new MederwerkerForm(administration);
            //MF.Show();
            Close();

        }

        /// <summary>
        /// Er wordt een event aan de listbox toegevoegd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCAaddevent_Click(object sender, EventArgs e)
        {
            //Geselecteerde event wordt toegevoegd aan de listbox
            if (cbCAaddevent.SelectedText != null || cbCAaddevent.SelectedText !="")
            {
                lbCAeventlist.Items.Add(cbCAaddevent.SelectedItem);
            }
            else
            {
                MessageBox.Show("Geen Event aangeklikt");
            }
            lbCAeventlist.DisplayMember = "Name";
        }

        private void MederwerkerCreateAccount_Load(object sender, EventArgs e)
        {
            
        }

        private void lblCAcity_Click(object sender, EventArgs e)
        {

        }

        private void lblCAGroup_Click(object sender, EventArgs e)
        {

        }

        private void lblCAzipcode_Click(object sender, EventArgs e)
        {

        }

        private void cbCAGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
