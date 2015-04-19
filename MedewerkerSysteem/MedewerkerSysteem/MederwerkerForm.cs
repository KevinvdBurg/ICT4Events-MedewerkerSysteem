using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets; //Needed for the RFID class and the PhidgetException class
using Phidgets.Events; //Needed for the phidget event handling classes

namespace MedewerkerSysteem
{

    public partial class MederwerkerForm : Form
    {
        private RFID rfid; //Declare an RFID object
        private Administation administration = new Administation();
        new Database  db = new Database();
        List<Account> accounts = new List<Account>();
        List<Reserve> reserves = new List<Reserve>();
        List<Event> events = new List<Event>();
        private Event currentEvent = null;

        public MederwerkerForm(Administation admin)
        {
            
            InitializeComponent();
            administration = admin;
            
        }

        private void MederwerkerForm_Load(object sender, EventArgs e)
        {
            rfid = new RFID();

            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.Detach += new DetachEventHandler(rfid_Detach);
            rfid.Error += new ErrorEventHandler(rfid_Error);

            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);


            //Disabled controls until Phidget is attached
            openCmdLine(rfid);

            events = administration.FindEventAll();
            cbEvents.DataSource = events;
            cbEvents.DisplayMember = "Name";

            currentEvent = (Event)cbEvents.SelectedItem;

            RefreshAll();
            

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
            //Close();
            CA.ShowDialog();
            RefreshAll();
        }

        private void btnReserveItem_Click(object sender, EventArgs e)
        {
            MedewerkerReserveItem IR = new MedewerkerReserveItem();
            IR.ShowDialog();
            RefreshAll();
        }

        private void btnReserveLocation_Click(object sender, EventArgs e)
        {
            MedewerkerReserveSpot SR = new MedewerkerReserveSpot();
            SR.ShowDialog();
            RefreshAll();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            MedewerkerEvent E = new MedewerkerEvent();
            E.ShowDialog();
            RefreshAll();
        }

        //attach event handler...display the serial number of the attached RFID phidget
        void rfid_Attach(object sender, AttachEventArgs e)
        {
            RFID attached = (RFID)sender;

            switch (attached.ID)
            {
                case Phidget.PhidgetID.RFID_2OUTPUT_READ_WRITE:
                    break;
                case Phidget.PhidgetID.RFID:
                case Phidget.PhidgetID.RFID_2OUTPUT:
                default:
                    break;
            }

            if (rfid.outputs.Count > 0)
            {
                rfid.Antenna = true;
            }
        }

        //detach event handler...clear all the fields, display the attached status, and disable the checkboxes.
        void rfid_Detach(object sender, DetachEventArgs e)
        {
            RFID detached = (RFID)sender;

            //this.Bounds = new Rectangle(this.Location, new Size(298, 433));
        }

        void rfid_Error(object sender, ErrorEventArgs e)
        {
            Console.WriteLine("Error: " + e);

        }

        //Tag event handler...we'll display the tag code in the field on the GUI
        void rfid_Tag(object sender, TagEventArgs e)
        {
            tbLetterRFID.Text = e.Tag;
        }

        //Tag lost event handler...here we simply want to clear our tag field in the GUI
        void rfid_TagLost(object sender, TagEventArgs e)
        {
            //tbLetterRFID.Text = "";
            Console.WriteLine("Lost");
            Console.WriteLine(e.ToString());
        }



        private void tbLetterRFID_MouseHover(object sender, EventArgs e)
        {
        }


        private void tbLetterRFID_Enter(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void tbLetterRFID_MouseLeave(object sender, EventArgs e)
        {

        }

        #region Command line open functions
        private void openCmdLine(Phidget p)
        {
            openCmdLine(p, null);
        }
        private void openCmdLine(Phidget p, String pass)
        {
            int serial = -1;
            String logFile = null;
            int port = 5001;
            String host = null;
            bool remote = false, remoteIP = false;
            string[] args = Environment.GetCommandLineArgs();
            String appName = args[0];

            try
            { //Parse the flags
                for (int i = 1; i < args.Length; i++)
                {
                    if (args[i].StartsWith("-"))
                        switch (args[i].Remove(0, 1).ToLower())
                        {
                            case "l":
                                logFile = (args[++i]);
                                break;
                            case "n":
                                serial = int.Parse(args[++i]);
                                break;
                            case "r":
                                remote = true;
                                break;
                            case "s":
                                remote = true;
                                host = args[++i];
                                break;
                            case "p":
                                pass = args[++i];
                                break;
                            case "i":
                                remoteIP = true;
                                host = args[++i];
                                if (host.Contains(":"))
                                {
                                    port = int.Parse(host.Split(':')[1]);
                                    host = host.Split(':')[0];
                                }
                                break;
                            default:
                                goto usage;
                        }
                    else
                        goto usage;
                }
                if (logFile != null)
                    Phidget.enableLogging(Phidget.LogLevel.PHIDGET_LOG_INFO, logFile);
                if (remoteIP)
                    p.open(serial, host, port, pass);
                else if (remote)
                    p.open(serial, host, pass);
                else
                    p.open(serial);
                return; //success
            }
            catch { }
        usage:
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Invalid Command line arguments." + Environment.NewLine);
            sb.AppendLine("Usage: " + appName + " [Flags...]");
            sb.AppendLine("Flags:\t-n   serialNumber\tSerial Number, omit for any serial");
            sb.AppendLine("\t-l   logFile\tEnable phidget21 logging to logFile.");
            sb.AppendLine("\t-r\t\tOpen remotely");
            sb.AppendLine("\t-s   serverID\tServer ID, omit for any server");
            sb.AppendLine("\t-i   ipAddress:port\tIp Address and Port. Port is optional, defaults to 5001");
            sb.AppendLine("\t-p   password\tPassword, omit for no password" + Environment.NewLine);
            sb.AppendLine("Examples: ");
            sb.AppendLine(appName + " -n 50098");
            sb.AppendLine(appName + " -r");
            sb.AppendLine(appName + " -s myphidgetserver");
            sb.AppendLine(appName + " -n 45670 -i 127.0.0.1:5001 -p paswrd");
            MessageBox.Show(sb.ToString(), "Argument Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Application.Exit();
        }
        #endregion

        private void btnLogout_Click(object sender, EventArgs e)
        {
            db.DisConnect();
            Close();
        }

        private void MederwerkerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            rfid.Attach -= new AttachEventHandler(rfid_Attach);
            rfid.Detach -= new DetachEventHandler(rfid_Detach);
            rfid.Tag -= new TagEventHandler(rfid_Tag);
            rfid.TagLost -= new TagEventHandler(rfid_TagLost);

            //run any events in the message queue - otherwise close will hang if there are any outstanding events
            Application.DoEvents();

            rfid.close();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            //btnChangePaid.Visible = false;
            //btnComplete.Visible = false;
            tbLetterName.Clear();

            int caseSwitch = 1;
            
            foreach (string check in administration.CheckReserve(Convert.ToInt32(nudReserveID.Value)))
            {
                switch (caseSwitch)
                {
                    case 1:
                        tbSpotLocation.Text = check;
                        break;
                    case 2:
                        tbLetterName.Text = check;
                        break;
                    case 3:
                        tbEmail.Text = check;
                        break;
                    case 4:
                        tbLetterGroupName.Text = check;
                        break;
                    case 5:
                        if (check == "1")
                        {
                            tbLetterStatus.Text = "Betaald";
                        }
                        else
                        {
                            tbLetterStatus.Text = "Niet Betaald";
                        }
                        break;
                    default:
                        Console.WriteLine("Check Added");
                        break;
                }
                caseSwitch++;
            }
            //try
            //{
            //    Account account = administration.FindAccount(tbEmail.Text);
            //    Reserve reserve = administration.FindReserve(Convert.ToInt32(nudReserveID.Value), account);

            //    accounts.Add(account);
            //    reserves.Add(reserve);
            //    //Check if the RFID belongs to the name
            //    //If correct fill in name and payment status
            //    if (account.Person.LastName == tbLetterName.Text && reserve.Account == account)

            //    {
            //        tbLetterScan.Text = "Succes";
            //        //if status: paid set btnComplete to true
            //        if (reserve.Paid)
            //        {
            //            //TODO check if customer already inside
            //            btnComplete.Visible = true;
            //            tbLetterStatus.Text = "Betaald";

            //        }
            //        else
            //        {
            //            btnChangePaid.Visible = true;
            //            tbLetterStatus.Text = "Nog te betalen: " + reserve.Category.Price;
            //        }
            //    }
            //    else
            //    {
            //        tbLetterScan.Text = "Failed";
            //        tbLetterStatus.Clear();
            //        tbLetterName.Clear();
            //        tbLetterRFID.Clear();
            //        tbLetterGroupName.Clear();
            //        tbSpotLocation.Clear();
            //    }
            //}
            //catch (Exception)
            //{
            //    tbLetterScan.Text = "Failed";
            //    tbLetterStatus.Clear();
            //    tbLetterName.Clear();
            //    tbLetterRFID.Clear();
            //    tbLetterGroupName.Clear();
            //    tbSpotLocation.Clear();
            //    throw;
            //}
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            //TODO checkin person

            if (tbLetterRFID.Text != "")
            {
                administration.ChainRFID(tbEmail.Text, tbLetterRFID.Text);
                AccountEvent accountEvent = administration.FindAccountEvent(administration.FindAccountID(tbEmail.Text), currentEvent.EventID);
                if (accountEvent.Present)
                {
                    MessageBox.Show("Deelnemer is al binnen");
                }
                else
                {
                    accountEvent.Present = true;
                    administration.ChangeAccountEvent(accountEvent);
                }
            }
            else
            {
                MessageBox.Show("Koppel eerst een RFID");
            }

            //Empty lists
            accounts.Clear();
            reserves.Clear();
            tbLetterStatus.Clear();
            tbLetterName.Clear();
            tbLetterRFID.Clear();
            tbLetterGroupName.Clear();
            tbSpotLocation.Clear();
        }

        private void btnChangePaid_Click(object sender, EventArgs e)
        {
            //btnComplete.Visible = true;
            //btnChangePaid.Visible = false;

            //foreach (var item in reserves)
            //{
            //    item.Paid = true;
            //}
            if (tbLetterStatus.Text != "Betaald")
            {
                if (administration.ChangePaymentStat(Convert.ToInt32(nudReserveID.Value)))
                {
                    tbLetterStatus.Text = "Betaald";
                }
                
            }
            else
            {
                MessageBox.Show("Klant heeft al betaald");
            }
        }

        private void btnChainRFID_Click(object sender, EventArgs e)
        {
            if (tbLetterRFID.Text != "")
            {
                administration.ChainRFID(tbEmail.Text, tbLetterRFID.Text);
            }
            else
            {
                MessageBox.Show("Vul RFID in");
            }

        }

        private void dgwAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwAccount_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwAccount.SelectedRows != null)
            {
                btnChangeAccount.Enabled = true;
                btnDeleteAccount.Enabled = true;
            }
            else
            {
                btnChangeAccount.Enabled = false;
                btnDeleteAccount.Enabled = false;
            }
        }

        private void dgwReserveItem_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwReserveItem.SelectedRows != null)
            {
                btnChangeReservation.Enabled = true;
                btnDeleteReservation.Enabled = true;
            }
            else
            {
                btnChangeReservation.Enabled = false;
                btnDeleteReservation.Enabled = false;
            }
        }

        private void dgwReserveSpot_SelectionChanged(object sender, EventArgs e)
        {
            if(dgwReserveSpot.SelectedRows != null)
            {
                btnChangeReservation.Enabled = true;
                btnDeleteReservation.Enabled = true;
            }
            else
            {
                btnChangeReservation.Enabled = false;
                btnDeleteReservation.Enabled = false;
            }
        }

        private void dgwEvents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwEvents.SelectedRows != null)
            {
                btnChangeEvent.Enabled = true;
            }
            else
            {
                btnChangeEvent.Enabled = false;
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            int gridCount = 0;
            string value = "";

            foreach (DataGridViewRow row in dgwAccount.SelectedRows)
                { 
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        
                        if (gridCount == 1)
                        {
                            value = cell.Value.ToString();
                        }
                        gridCount++;
                    }
                }
            administration.Delete(administration.FindAccount(value));
            RefreshAccounts();
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            administration.FindReserve(Convert.ToInt32(ItemCode.Selected.ToString()),
                administration.FindAccount(ItemRFID.Selected.ToString()));

        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            administration.Delete(administration.FindEvent(AdminEventName.Selected.ToString()));
        }

        public void RefreshAccounts()
        {
            dgwAccount.Rows.Clear();
            foreach (Account account in administration.FindAccountAll())
            {
                dgwAccount.Rows.Add(account.Person.LastName, account.Person.Email, account.RFID);
            }
           
        }

        public void RefreshItem()
        {
            dgwReserveItem.Rows.Clear();
            foreach (ReserveItem item in administration.FindReserveItemAll())
            {
                dgwReserveItem.Rows.Add(item.ReserveringsID, item.Item.Name, item.Account.Person.LastName, item.EndDate, item.StartDate, item.Account.RFID);
            }
        }
    
        public void RefreshSpot()
        {
            dgwReserveSpot.Rows.Clear();
            foreach (ReserveSpot spot in administration.FindReserveSpotsAll())
            {
                dgwReserveSpot.Rows.Add(spot.ReserveringsID, spot.ReserveringsID, spot.Account.Person.LastName, spot.StartDate, spot.EndDate);
            }
        }
        public void RefreshMedia()
        {
            dgwMedia.Rows.Clear();
            foreach (Media item in administration.FindMediaItemAll())
            {
                dgwMedia.Rows.Add(item.PostID, item.Inhoud, item.Bestandlocatie, item.AANTALREPORTS);
            }
        }

        public void RefreshPresent()
        {
            dgwPresent.Rows.Clear();
            foreach (AccountEvent item in administration.FindAllAccountEvent(currentEvent.EventID))
            {
                dgwPresent.Rows.Add(item.LastName, item.LocatieID, item.DateIn, item.DateOut);
            }
        }
        public void RefreshEvent()
        {
            dgwEvents.Rows.Clear();

            foreach (Event events in administration.FindEventAll())
            {
                dgwEvents.Rows.Add(events.Name, events.BeginTime, events.EndTime, events.MaxPerson, events.EventID);
            }
        }

        public void RefreshAll()
        {
            RefreshAccounts();
            RefreshItem();
            RefreshSpot();
            RefreshMedia();
            RefreshPresent();
            RefreshEvent();
        }

        private void lblLetterLocation_Click(object sender, EventArgs e)
        {

        }

        private void tbSpotLocation_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void tbLetterGroupName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLetterGroupName_Click(object sender, EventArgs e)
        {

        }

        private void lblLetterName_Click(object sender, EventArgs e)
        {

        }

        private void tbLetterName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLetterRFID_Click(object sender, EventArgs e)
        {

        }

        private void tbLetterRFID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChangeAccount_Click(object sender, EventArgs e)
        {
            int gridCount = 0;
            string value = "";

            foreach (DataGridViewRow row in dgwAccount.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {

                    if (gridCount == 1)
                    {
                        value = cell.Value.ToString();
                    }
                    gridCount++;
                }
            }

            MederwerkerUpdateAccount MUA = new MederwerkerUpdateAccount(administration.FindAccount(value));
            MUA.ShowDialog();
            RefreshAccounts();
            //Close();
        }

        private void btnChangeReservation_Click(object sender, EventArgs e)
        {
            int gridCount = 0;
            string value = "";

            foreach (DataGridViewRow row in dgwAccount.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {

                    if (gridCount == 1)
                    {
                        value = cell.Value.ToString();
                    }
                    gridCount++;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void MederwerkerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void cbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentEvent = (Event)cbEvents.SelectedItem;
            RefreshAll();
        }

        private void btnOpenMediaItem_Click(object sender, EventArgs e)
        {
            int gridCount = 0;
            string value = "";

            foreach (DataGridViewRow row in dgwMedia.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {

                    if (gridCount == 0)
                    {
                        value = cell.Value.ToString();
                    }
                    gridCount++;
                }
            }

            MedewerkerMedia MM = new MedewerkerMedia(administration.FindMedia(value));
            MM.ShowDialog();
            RefreshMedia();
        }

        private void btnChangeEvent_Click(object sender, EventArgs e)
        {
            int gridCount = 0;
            int value = 0;

            foreach (DataGridViewRow row in dgwEvents.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (gridCount == 4)
                    {
                        value = Convert.ToInt32(cell.Value);
                    }
                    gridCount++;
                }
            }
            
            MedewerkerEventUpdate MEU = new MedewerkerEventUpdate(administration.FindEvent(value));
            MEU.ShowDialog();
            RefreshEvent();
        }

    }
}