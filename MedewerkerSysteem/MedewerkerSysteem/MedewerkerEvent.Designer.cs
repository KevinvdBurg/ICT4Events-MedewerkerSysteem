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
            this.btnRScancel = new System.Windows.Forms.Button();
            this.dtpEdatein = new System.Windows.Forms.DateTimePicker();
            this.dtpEdateuit = new System.Windows.Forms.DateTimePicker();
            this.cbEitemname = new System.Windows.Forms.ComboBox();
            this.cbEname = new System.Windows.Forms.ComboBox();
            this.lblEdatain = new System.Windows.Forms.Label();
            this.lblEdataout = new System.Windows.Forms.Label();
            this.lblEeventname = new System.Windows.Forms.Label();
            this.lblEname = new System.Windows.Forms.Label();
            this.btnRSreserve = new System.Windows.Forms.Button();
            this.tbElocation = new System.Windows.Forms.TextBox();
            this.nudEmaxvisitors = new System.Windows.Forms.NumericUpDown();
            this.lblElocation = new System.Windows.Forms.Label();
            this.lblEmaxvisitors = new System.Windows.Forms.Label();
            this.gbReserveSpot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmaxvisitors)).BeginInit();
            this.SuspendLayout();
            // 
            // gbReserveSpot
            // 
            this.gbReserveSpot.Controls.Add(this.lblEmaxvisitors);
            this.gbReserveSpot.Controls.Add(this.lblElocation);
            this.gbReserveSpot.Controls.Add(this.nudEmaxvisitors);
            this.gbReserveSpot.Controls.Add(this.tbElocation);
            this.gbReserveSpot.Controls.Add(this.btnRScancel);
            this.gbReserveSpot.Controls.Add(this.dtpEdatein);
            this.gbReserveSpot.Controls.Add(this.dtpEdateuit);
            this.gbReserveSpot.Controls.Add(this.cbEitemname);
            this.gbReserveSpot.Controls.Add(this.cbEname);
            this.gbReserveSpot.Controls.Add(this.lblEdatain);
            this.gbReserveSpot.Controls.Add(this.lblEdataout);
            this.gbReserveSpot.Controls.Add(this.lblEeventname);
            this.gbReserveSpot.Controls.Add(this.lblEname);
            this.gbReserveSpot.Controls.Add(this.btnRSreserve);
            this.gbReserveSpot.Location = new System.Drawing.Point(12, 12);
            this.gbReserveSpot.Name = "gbReserveSpot";
            this.gbReserveSpot.Size = new System.Drawing.Size(451, 325);
            this.gbReserveSpot.TabIndex = 4;
            this.gbReserveSpot.TabStop = false;
            this.gbReserveSpot.Text = "Event";
            // 
            // btnRScancel
            // 
            this.btnRScancel.Location = new System.Drawing.Point(218, 270);
            this.btnRScancel.Name = "btnRScancel";
            this.btnRScancel.Size = new System.Drawing.Size(100, 36);
            this.btnRScancel.TabIndex = 13;
            this.btnRScancel.Text = "Annuleren";
            this.btnRScancel.UseVisualStyleBackColor = true;
            this.btnRScancel.Click += new System.EventHandler(this.btnRScancel_Click);
            // 
            // dtpEdatein
            // 
            this.dtpEdatein.Location = new System.Drawing.Point(117, 152);
            this.dtpEdatein.Name = "dtpEdatein";
            this.dtpEdatein.Size = new System.Drawing.Size(307, 20);
            this.dtpEdatein.TabIndex = 12;
            // 
            // dtpEdateuit
            // 
            this.dtpEdateuit.Location = new System.Drawing.Point(117, 117);
            this.dtpEdateuit.Name = "dtpEdateuit";
            this.dtpEdateuit.Size = new System.Drawing.Size(307, 20);
            this.dtpEdateuit.TabIndex = 11;
            // 
            // cbEitemname
            // 
            this.cbEitemname.FormattingEnabled = true;
            this.cbEitemname.Location = new System.Drawing.Point(117, 77);
            this.cbEitemname.Name = "cbEitemname";
            this.cbEitemname.Size = new System.Drawing.Size(307, 21);
            this.cbEitemname.TabIndex = 10;
            // 
            // cbEname
            // 
            this.cbEname.FormattingEnabled = true;
            this.cbEname.Location = new System.Drawing.Point(117, 40);
            this.cbEname.Name = "cbEname";
            this.cbEname.Size = new System.Drawing.Size(307, 21);
            this.cbEname.TabIndex = 9;
            // 
            // lblEdatain
            // 
            this.lblEdatain.AutoSize = true;
            this.lblEdatain.Location = new System.Drawing.Point(6, 158);
            this.lblEdatain.Name = "lblEdatain";
            this.lblEdatain.Size = new System.Drawing.Size(53, 13);
            this.lblEdatain.TabIndex = 8;
            this.lblEdatain.Text = "Datum In:";
            // 
            // lblEdataout
            // 
            this.lblEdataout.AutoSize = true;
            this.lblEdataout.Location = new System.Drawing.Point(6, 117);
            this.lblEdataout.Name = "lblEdataout";
            this.lblEdataout.Size = new System.Drawing.Size(54, 13);
            this.lblEdataout.TabIndex = 6;
            this.lblEdataout.Text = "Datum Uit";
            // 
            // lblEeventname
            // 
            this.lblEeventname.AutoSize = true;
            this.lblEeventname.Location = new System.Drawing.Point(6, 77);
            this.lblEeventname.Name = "lblEeventname";
            this.lblEeventname.Size = new System.Drawing.Size(62, 13);
            this.lblEeventname.TabIndex = 4;
            this.lblEeventname.Text = "Plek Naam:";
            // 
            // lblEname
            // 
            this.lblEname.AutoSize = true;
            this.lblEname.Location = new System.Drawing.Point(6, 40);
            this.lblEname.Name = "lblEname";
            this.lblEname.Size = new System.Drawing.Size(38, 13);
            this.lblEname.TabIndex = 2;
            this.lblEname.Text = "Naam:";
            // 
            // btnRSreserve
            // 
            this.btnRSreserve.Location = new System.Drawing.Point(324, 270);
            this.btnRSreserve.Name = "btnRSreserve";
            this.btnRSreserve.Size = new System.Drawing.Size(100, 36);
            this.btnRSreserve.TabIndex = 0;
            this.btnRSreserve.Text = "Reserveren";
            this.btnRSreserve.UseVisualStyleBackColor = true;
            this.btnRSreserve.Click += new System.EventHandler(this.btnRSreserve_Click);
            // 
            // tbElocation
            // 
            this.tbElocation.Location = new System.Drawing.Point(117, 192);
            this.tbElocation.Name = "tbElocation";
            this.tbElocation.Size = new System.Drawing.Size(307, 20);
            this.tbElocation.TabIndex = 14;
            this.tbElocation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nudEmaxvisitors
            // 
            this.nudEmaxvisitors.Location = new System.Drawing.Point(117, 230);
            this.nudEmaxvisitors.Name = "nudEmaxvisitors";
            this.nudEmaxvisitors.Size = new System.Drawing.Size(307, 20);
            this.nudEmaxvisitors.TabIndex = 15;
            // 
            // lblElocation
            // 
            this.lblElocation.AutoSize = true;
            this.lblElocation.Location = new System.Drawing.Point(7, 199);
            this.lblElocation.Name = "lblElocation";
            this.lblElocation.Size = new System.Drawing.Size(51, 13);
            this.lblElocation.TabIndex = 16;
            this.lblElocation.Text = "Location:";
            // 
            // lblEmaxvisitors
            // 
            this.lblEmaxvisitors.AutoSize = true;
            this.lblEmaxvisitors.Location = new System.Drawing.Point(6, 232);
            this.lblEmaxvisitors.Name = "lblEmaxvisitors";
            this.lblEmaxvisitors.Size = new System.Drawing.Size(86, 13);
            this.lblEmaxvisitors.TabIndex = 17;
            this.lblEmaxvisitors.Text = "Max. Bezoekers:";
            // 
            // MedewerkerEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 344);
            this.Controls.Add(this.gbReserveSpot);
            this.Name = "MedewerkerEvent";
            this.Text = "Event";
            this.gbReserveSpot.ResumeLayout(false);
            this.gbReserveSpot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmaxvisitors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReserveSpot;
        private System.Windows.Forms.TextBox tbElocation;
        private System.Windows.Forms.Button btnRScancel;
        private System.Windows.Forms.DateTimePicker dtpEdatein;
        private System.Windows.Forms.DateTimePicker dtpEdateuit;
        private System.Windows.Forms.ComboBox cbEitemname;
        private System.Windows.Forms.ComboBox cbEname;
        private System.Windows.Forms.Label lblEdatain;
        private System.Windows.Forms.Label lblEdataout;
        private System.Windows.Forms.Label lblEeventname;
        private System.Windows.Forms.Label lblEname;
        private System.Windows.Forms.Button btnRSreserve;
        private System.Windows.Forms.Label lblEmaxvisitors;
        private System.Windows.Forms.Label lblElocation;
        private System.Windows.Forms.NumericUpDown nudEmaxvisitors;
    }
}