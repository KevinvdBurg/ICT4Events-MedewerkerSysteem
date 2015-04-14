namespace MedewerkerSysteem
{
    partial class MedewerkerEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbReserveSpot = new System.Windows.Forms.GroupBox();
            this.lblCAcountry = new System.Windows.Forms.Label();
            this.tbEcountry = new System.Windows.Forms.TextBox();
            this.tbEcity = new System.Windows.Forms.TextBox();
            this.lblCAcity = new System.Windows.Forms.Label();
            this.lblCAzipcode = new System.Windows.Forms.Label();
            this.tbEzipcode = new System.Windows.Forms.TextBox();
            this.tbEstreetname = new System.Windows.Forms.TextBox();
            this.lblCAstreetname = new System.Windows.Forms.Label();
            this.tbEname = new System.Windows.Forms.TextBox();
            this.lblEmaxvisitors = new System.Windows.Forms.Label();
            this.lblElocationname = new System.Windows.Forms.Label();
            this.nudEmaxvisitors = new System.Windows.Forms.NumericUpDown();
            this.tbElocation = new System.Windows.Forms.TextBox();
            this.btnECancel = new System.Windows.Forms.Button();
            this.dtpEdatein = new System.Windows.Forms.DateTimePicker();
            this.dtpEdateuit = new System.Windows.Forms.DateTimePicker();
            this.lblEdatain = new System.Windows.Forms.Label();
            this.lblEdataout = new System.Windows.Forms.Label();
            this.lblEname = new System.Windows.Forms.Label();
            this.btnECreateEvent = new System.Windows.Forms.Button();
            this.lblCAid = new System.Windows.Forms.Label();
            this.nudEid = new System.Windows.Forms.NumericUpDown();
            this.gbReserveSpot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmaxvisitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEid)).BeginInit();
            this.SuspendLayout();
            // 
            // gbReserveSpot
            // 
            this.gbReserveSpot.Controls.Add(this.nudEid);
            this.gbReserveSpot.Controls.Add(this.lblCAid);
            this.gbReserveSpot.Controls.Add(this.lblCAcountry);
            this.gbReserveSpot.Controls.Add(this.tbEcountry);
            this.gbReserveSpot.Controls.Add(this.tbEcity);
            this.gbReserveSpot.Controls.Add(this.lblCAcity);
            this.gbReserveSpot.Controls.Add(this.lblCAzipcode);
            this.gbReserveSpot.Controls.Add(this.tbEzipcode);
            this.gbReserveSpot.Controls.Add(this.tbEstreetname);
            this.gbReserveSpot.Controls.Add(this.lblCAstreetname);
            this.gbReserveSpot.Controls.Add(this.tbEname);
            this.gbReserveSpot.Controls.Add(this.lblEmaxvisitors);
            this.gbReserveSpot.Controls.Add(this.lblElocationname);
            this.gbReserveSpot.Controls.Add(this.nudEmaxvisitors);
            this.gbReserveSpot.Controls.Add(this.tbElocation);
            this.gbReserveSpot.Controls.Add(this.btnECancel);
            this.gbReserveSpot.Controls.Add(this.dtpEdatein);
            this.gbReserveSpot.Controls.Add(this.dtpEdateuit);
            this.gbReserveSpot.Controls.Add(this.lblEdatain);
            this.gbReserveSpot.Controls.Add(this.lblEdataout);
            this.gbReserveSpot.Controls.Add(this.lblEname);
            this.gbReserveSpot.Controls.Add(this.btnECreateEvent);
            this.gbReserveSpot.Location = new System.Drawing.Point(16, 15);
            this.gbReserveSpot.Margin = new System.Windows.Forms.Padding(4);
            this.gbReserveSpot.Name = "gbReserveSpot";
            this.gbReserveSpot.Padding = new System.Windows.Forms.Padding(4);
            this.gbReserveSpot.Size = new System.Drawing.Size(601, 416);
            this.gbReserveSpot.TabIndex = 4;
            this.gbReserveSpot.TabStop = false;
            this.gbReserveSpot.Text = "Event";
            // 
            // lblCAcountry
            // 
            this.lblCAcountry.AutoSize = true;
            this.lblCAcountry.Location = new System.Drawing.Point(13, 193);
            this.lblCAcountry.Name = "lblCAcountry";
            this.lblCAcountry.Size = new System.Drawing.Size(44, 17);
            this.lblCAcountry.TabIndex = 36;
            this.lblCAcountry.Text = "Land:";
            // 
            // tbEcountry
            // 
            this.tbEcountry.Location = new System.Drawing.Point(152, 188);
            this.tbEcountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEcountry.Name = "tbEcountry";
            this.tbEcountry.Size = new System.Drawing.Size(412, 22);
            this.tbEcountry.TabIndex = 35;
            // 
            // tbEcity
            // 
            this.tbEcity.Location = new System.Drawing.Point(152, 149);
            this.tbEcity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEcity.Name = "tbEcity";
            this.tbEcity.Size = new System.Drawing.Size(412, 22);
            this.tbEcity.TabIndex = 34;
            // 
            // lblCAcity
            // 
            this.lblCAcity.AutoSize = true;
            this.lblCAcity.Location = new System.Drawing.Point(11, 154);
            this.lblCAcity.Name = "lblCAcity";
            this.lblCAcity.Size = new System.Drawing.Size(41, 17);
            this.lblCAcity.TabIndex = 33;
            this.lblCAcity.Text = "Stad:";
            // 
            // lblCAzipcode
            // 
            this.lblCAzipcode.AutoSize = true;
            this.lblCAzipcode.Location = new System.Drawing.Point(349, 125);
            this.lblCAzipcode.Name = "lblCAzipcode";
            this.lblCAzipcode.Size = new System.Drawing.Size(71, 17);
            this.lblCAzipcode.TabIndex = 32;
            this.lblCAzipcode.Text = "Postcode:";
            // 
            // tbEzipcode
            // 
            this.tbEzipcode.Location = new System.Drawing.Point(413, 120);
            this.tbEzipcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEzipcode.Name = "tbEzipcode";
            this.tbEzipcode.Size = new System.Drawing.Size(151, 22);
            this.tbEzipcode.TabIndex = 31;
            // 
            // tbEstreetname
            // 
            this.tbEstreetname.Location = new System.Drawing.Point(152, 120);
            this.tbEstreetname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEstreetname.Name = "tbEstreetname";
            this.tbEstreetname.Size = new System.Drawing.Size(191, 22);
            this.tbEstreetname.TabIndex = 30;
            // 
            // lblCAstreetname
            // 
            this.lblCAstreetname.AutoSize = true;
            this.lblCAstreetname.Location = new System.Drawing.Point(11, 120);
            this.lblCAstreetname.Name = "lblCAstreetname";
            this.lblCAstreetname.Size = new System.Drawing.Size(49, 17);
            this.lblCAstreetname.TabIndex = 29;
            this.lblCAstreetname.Text = "Adres:";
            // 
            // tbEname
            // 
            this.tbEname.Location = new System.Drawing.Point(156, 43);
            this.tbEname.Name = "tbEname";
            this.tbEname.Size = new System.Drawing.Size(187, 22);
            this.tbEname.TabIndex = 18;
            // 
            // lblEmaxvisitors
            // 
            this.lblEmaxvisitors.AutoSize = true;
            this.lblEmaxvisitors.Location = new System.Drawing.Point(8, 324);
            this.lblEmaxvisitors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmaxvisitors.Name = "lblEmaxvisitors";
            this.lblEmaxvisitors.Size = new System.Drawing.Size(112, 17);
            this.lblEmaxvisitors.TabIndex = 17;
            this.lblEmaxvisitors.Text = "Max. Bezoekers:";
            // 
            // lblElocationname
            // 
            this.lblElocationname.AutoSize = true;
            this.lblElocationname.Location = new System.Drawing.Point(8, 86);
            this.lblElocationname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblElocationname.Name = "lblElocationname";
            this.lblElocationname.Size = new System.Drawing.Size(97, 17);
            this.lblElocationname.TabIndex = 16;
            this.lblElocationname.Text = "Locatie naam:";
            // 
            // nudEmaxvisitors
            // 
            this.nudEmaxvisitors.Location = new System.Drawing.Point(156, 321);
            this.nudEmaxvisitors.Margin = new System.Windows.Forms.Padding(4);
            this.nudEmaxvisitors.Name = "nudEmaxvisitors";
            this.nudEmaxvisitors.Size = new System.Drawing.Size(409, 22);
            this.nudEmaxvisitors.TabIndex = 15;
            // 
            // tbElocation
            // 
            this.tbElocation.Location = new System.Drawing.Point(155, 77);
            this.tbElocation.Margin = new System.Windows.Forms.Padding(4);
            this.tbElocation.Name = "tbElocation";
            this.tbElocation.Size = new System.Drawing.Size(408, 22);
            this.tbElocation.TabIndex = 14;
            // 
            // btnECancel
            // 
            this.btnECancel.Location = new System.Drawing.Point(290, 361);
            this.btnECancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnECancel.Name = "btnECancel";
            this.btnECancel.Size = new System.Drawing.Size(133, 44);
            this.btnECancel.TabIndex = 13;
            this.btnECancel.Text = "Annuleren";
            this.btnECancel.UseVisualStyleBackColor = true;
            this.btnECancel.Click += new System.EventHandler(this.btnRScancel_Click);
            // 
            // dtpEdatein
            // 
            this.dtpEdatein.Location = new System.Drawing.Point(156, 269);
            this.dtpEdatein.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEdatein.Name = "dtpEdatein";
            this.dtpEdatein.Size = new System.Drawing.Size(408, 22);
            this.dtpEdatein.TabIndex = 12;
            // 
            // dtpEdateuit
            // 
            this.dtpEdateuit.Location = new System.Drawing.Point(156, 226);
            this.dtpEdateuit.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEdateuit.Name = "dtpEdateuit";
            this.dtpEdateuit.Size = new System.Drawing.Size(408, 22);
            this.dtpEdateuit.TabIndex = 11;
            // 
            // lblEdatain
            // 
            this.lblEdatain.AutoSize = true;
            this.lblEdatain.Location = new System.Drawing.Point(8, 276);
            this.lblEdatain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdatain.Name = "lblEdatain";
            this.lblEdatain.Size = new System.Drawing.Size(92, 17);
            this.lblEdatain.TabIndex = 8;
            this.lblEdatain.Text = "Datum einde:";
            // 
            // lblEdataout
            // 
            this.lblEdataout.AutoSize = true;
            this.lblEdataout.Location = new System.Drawing.Point(8, 226);
            this.lblEdataout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdataout.Name = "lblEdataout";
            this.lblEdataout.Size = new System.Drawing.Size(92, 17);
            this.lblEdataout.TabIndex = 6;
            this.lblEdataout.Text = "Datum begin:";
            // 
            // lblEname
            // 
            this.lblEname.AutoSize = true;
            this.lblEname.Location = new System.Drawing.Point(8, 49);
            this.lblEname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEname.Name = "lblEname";
            this.lblEname.Size = new System.Drawing.Size(49, 17);
            this.lblEname.TabIndex = 2;
            this.lblEname.Text = "Naam:";
            // 
            // btnECreateEvent
            // 
            this.btnECreateEvent.Location = new System.Drawing.Point(431, 361);
            this.btnECreateEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnECreateEvent.Name = "btnECreateEvent";
            this.btnECreateEvent.Size = new System.Drawing.Size(133, 44);
            this.btnECreateEvent.TabIndex = 0;
            this.btnECreateEvent.Text = "Plan event";
            this.btnECreateEvent.UseVisualStyleBackColor = true;
            this.btnECreateEvent.Click += new System.EventHandler(this.btnRSreserve_Click);
            // 
            // lblCAid
            // 
            this.lblCAid.AutoSize = true;
            this.lblCAid.Location = new System.Drawing.Point(352, 48);
            this.lblCAid.Name = "lblCAid";
            this.lblCAid.Size = new System.Drawing.Size(65, 17);
            this.lblCAid.TabIndex = 37;
            this.lblCAid.Text = "Nummer:";
            // 
            // nudEid
            // 
            this.nudEid.Location = new System.Drawing.Point(424, 43);
            this.nudEid.Name = "nudEid";
            this.nudEid.Size = new System.Drawing.Size(120, 22);
            this.nudEid.TabIndex = 38;
            this.nudEid.ThousandsSeparator = true;
            this.nudEid.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MedewerkerEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 437);
            this.Controls.Add(this.gbReserveSpot);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MedewerkerEvent";
            this.Text = "Event";
            this.gbReserveSpot.ResumeLayout(false);
            this.gbReserveSpot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmaxvisitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReserveSpot;
        private System.Windows.Forms.TextBox tbElocation;
        private System.Windows.Forms.Button btnECancel;
        private System.Windows.Forms.DateTimePicker dtpEdatein;
        private System.Windows.Forms.DateTimePicker dtpEdateuit;
        private System.Windows.Forms.Label lblEdatain;
        private System.Windows.Forms.Label lblEdataout;
        private System.Windows.Forms.Label lblEname;
        private System.Windows.Forms.Button btnECreateEvent;
        private System.Windows.Forms.Label lblEmaxvisitors;
        private System.Windows.Forms.Label lblElocationname;
        private System.Windows.Forms.NumericUpDown nudEmaxvisitors;
        private System.Windows.Forms.TextBox tbEname;
        private System.Windows.Forms.Label lblCAcountry;
        private System.Windows.Forms.TextBox tbEcountry;
        private System.Windows.Forms.TextBox tbEcity;
        private System.Windows.Forms.Label lblCAcity;
        private System.Windows.Forms.Label lblCAzipcode;
        private System.Windows.Forms.TextBox tbEzipcode;
        private System.Windows.Forms.TextBox tbEstreetname;
        private System.Windows.Forms.Label lblCAstreetname;
        private System.Windows.Forms.NumericUpDown nudEid;
        private System.Windows.Forms.Label lblCAid;
    }
}