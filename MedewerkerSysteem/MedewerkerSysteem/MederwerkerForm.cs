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
        RFID rfid = new RFID(); //Declare an RFID object

        public MederwerkerForm()
        {
            InitializeComponent();
            //initialize our Phidgets RFID reader and hook the event handlers
            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.Detach += new DetachEventHandler(rfid_Detach);
            rfid.Error += new ErrorEventHandler(rfid_Error);

            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);
            rfid.open();
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

        //attach event handler...display the serial number of the attached RFID phidget
        private static void rfid_Attach(object sender, AttachEventArgs e)
        {
            Console.WriteLine("RFIDReader {0} attached!",
                e.Device.SerialNumber.ToString());
        }

        //detach event handler...display the serial number of the detached RFID phidget
        private static void rfid_Detach(object sender, DetachEventArgs e)
        {
            Console.WriteLine("RFID reader {0} detached!", e.Device.SerialNumber.ToString());
        }

        //Error event handler...display the error description string
        private static void rfid_Error(object sender, ErrorEventArgs e)
        {
            Console.WriteLine(e.Description);
        }

        //Print the tag code of the scanned tag
        private static void rfid_Tag(object sender, TagEventArgs e)
        {
            Console.WriteLine("Tag {0} scanned", e.Tag);
        }

        //print the tag code for the tag that was just lost
        private static void rfid_TagLost(object sender, TagEventArgs e)
        {
            Console.WriteLine("Tag {0} lost", e.Tag);
        }

        private void tbLetterRFID_MouseHover(object sender, EventArgs e)
        {
        }


        private void tbLetterRFID_Enter(object sender, EventArgs e)
        {
            /*MessageBox.Show("Focus");
            timer.Interval = 50;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();*/

            

            //Wait for a Phidget RFID to be attached before doing anything with 
            //the object
            //Console.WriteLine("waiting for attachment...");
            rfid.waitForAttachment();

            //turn on the antenna and the led to show everything is working
            rfid.Antenna = true;
            rfid.LED = true;

            

          

            //keep waiting and outputting events until keyboard input is entered
            //Console.WriteLine("Press any key to end...");
            //Console.Read();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           
        }

        private void tbLetterRFID_MouseLeave(object sender, EventArgs e)
        {
            if (rfid.LED != true )
            {
                rfid.LED = false;
            }
            //close the phidget and dispose of the object
            rfid = null;
            Console.WriteLine("ok");
        }
    }
}