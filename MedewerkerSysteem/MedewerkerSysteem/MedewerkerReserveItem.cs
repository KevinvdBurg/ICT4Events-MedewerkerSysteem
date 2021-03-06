﻿using System;
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
    public partial class MedewerkerReserveItem : Form
    {
        Administation administation = new Administation();
        List<Account> accounts = new List<Account>();
        List<Item> items = new List<Item>();
        private int number;
        private int CurrentEvent = 0;
        public MedewerkerReserveItem(int CurrentEvent)
        {
            InitializeComponent();
            this.CurrentEvent = CurrentEvent;
            int i = 0;
            int b = 0;
            foreach (var item in administation.FindItems())
            {
                bool check = false;
                foreach (var item2 in administation.FindReserveItemAll())
                {
                    if (item2.Item == item)
                    {
                        check = true;
                    }
                    b++;
                }
                if (!check)
                {
                    cbIRitemname.Items.Add(item.Name);
                    items.Add(item);
                }
                i++;
            }
            int j = i;
            int a = b;
            number = administation.FindHighestItemReserveID() + 1;
            foreach (var item in administation.FindAccountAll())
            {
                cbIRname.Items.Add(item.Person.Email);
            }
        }

        private void btnIRcancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIRreserve_Click(object sender, EventArgs e)
        {
            //Maakt een item reservering aan voor een deelnemer
            foreach (var item in items)
            {
                if (item.Name == cbIRitemname.SelectedItem.ToString())
                {
                    foreach (var item2 in administation.FindAccountAll())
                    {
                        if (item2.Person.Email == cbIRname.SelectedItem.ToString())
                        {
                            
                            Account account = item2;
                            administation.Add(new ReserveItem(item, true, account, item.category, dtpIRdateuit.Text, dtpIRdatein.Text, cbRIpaid.Checked, number), CurrentEvent);
                            
                            Close();
                        }
                    }
                }
            }
        }

        private void MedewerkerReserveItem_Load(object sender, EventArgs e)
        {

        }
    }
}
