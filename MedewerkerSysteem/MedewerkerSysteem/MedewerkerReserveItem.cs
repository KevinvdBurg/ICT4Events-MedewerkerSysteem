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
    public partial class MedewerkerReserveItem : Form
    {
        Administation administation = new Administation();
        List<Account> accounts = new List<Account>();
        List<Item> items = new List<Item>();
        private int number;
        public MedewerkerReserveItem()
        {
            InitializeComponent();
            
            foreach (var item in administation.FindItemsAll())
            {
                bool check = false;
                foreach (var item2 in administation.FindReserveItemAll())
                {
                    if (item2.Item == item)
                    {
                        check = true;
                    }
                }
                if (!check)
                {
                    cbIRitemname.Items.Add(item.Name);
                    items.Add(item);
                }
                
               
                
            }
            number = administation.FindHighestReserveID() + 1;
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
            foreach (var item in items)
            {
                if (item.Name == cbIRitemname.SelectedItem.ToString())
                {
                    foreach (var item2 in accounts)
                    {
                        if (item2.Person.Email == cbIRname.SelectedItem.ToString())
                        {
                            
                            Account account = item2;
                            administation.Add(new ReserveItem(item, true, account, item.category, dtpIRdateuit.Text, dtpIRdatein.Text, cbRIpaid.Checked, number ));
                            
                            Close();
                        }
                    }
                }
            }
        }
    }
}
