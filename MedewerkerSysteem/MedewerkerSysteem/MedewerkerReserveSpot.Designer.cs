namespace MedewerkerSysteem
{
    partial class MedewerkerReserveSpot
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
            this.btnRScancel = new System.Windows.Forms.Button();
            this.gbReserveSpot = new System.Windows.Forms.GroupBox();
            this.dtpRSdatein = new System.Windows.Forms.DateTimePicker();
            this.dtpRSdateuit = new System.Windows.Forms.DateTimePicker();
            this.cbRSitemname = new System.Windows.Forms.ComboBox();
            this.cbRSname = new System.Windows.Forms.ComboBox();
            this.lblRSdatain = new System.Windows.Forms.Label();
            this.lblRSdataout = new System.Windows.Forms.Label();
            this.lblRSspotname = new System.Windows.Forms.Label();
            this.lblRSname = new System.Windows.Forms.Label();
            this.btnRSreserve = new System.Windows.Forms.Button();
            this.gbReserveSpot.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRScancel
            // 
            this.btnRScancel.Location = new System.Drawing.Point(218, 200);
            this.btnRScancel.Name = "btnRScancel";
            this.btnRScancel.Size = new System.Drawing.Size(100, 36);
            this.btnRScancel.TabIndex = 13;
            this.btnRScancel.Text = "Annuleren";
            this.btnRScancel.UseVisualStyleBackColor = true;
            this.btnRScancel.Click += new System.EventHandler(this.btnRScancel_Click);
            // 
            // gbReserveSpot
            // 
            this.gbReserveSpot.Controls.Add(this.btnRScancel);
            this.gbReserveSpot.Controls.Add(this.dtpRSdatein);
            this.gbReserveSpot.Controls.Add(this.dtpRSdateuit);
            this.gbReserveSpot.Controls.Add(this.cbRSitemname);
            this.gbReserveSpot.Controls.Add(this.cbRSname);
            this.gbReserveSpot.Controls.Add(this.lblRSdatain);
            this.gbReserveSpot.Controls.Add(this.lblRSdataout);
            this.gbReserveSpot.Controls.Add(this.lblRSspotname);
            this.gbReserveSpot.Controls.Add(this.lblRSname);
            this.gbReserveSpot.Controls.Add(this.btnRSreserve);
            this.gbReserveSpot.Location = new System.Drawing.Point(12, 12);
            this.gbReserveSpot.Name = "gbReserveSpot";
            this.gbReserveSpot.Size = new System.Drawing.Size(451, 264);
            this.gbReserveSpot.TabIndex = 3;
            this.gbReserveSpot.TabStop = false;
            this.gbReserveSpot.Text = "Plek Reserveren";
            // 
            // dtpRSdatein
            // 
            this.dtpRSdatein.Location = new System.Drawing.Point(117, 152);
            this.dtpRSdatein.Name = "dtpRSdatein";
            this.dtpRSdatein.Size = new System.Drawing.Size(307, 20);
            this.dtpRSdatein.TabIndex = 12;
            // 
            // dtpRSdateuit
            // 
            this.dtpRSdateuit.Location = new System.Drawing.Point(117, 117);
            this.dtpRSdateuit.Name = "dtpRSdateuit";
            this.dtpRSdateuit.Size = new System.Drawing.Size(307, 20);
            this.dtpRSdateuit.TabIndex = 11;
            // 
            // cbRSitemname
            // 
            this.cbRSitemname.FormattingEnabled = true;
            this.cbRSitemname.Location = new System.Drawing.Point(117, 77);
            this.cbRSitemname.Name = "cbRSitemname";
            this.cbRSitemname.Size = new System.Drawing.Size(307, 21);
            this.cbRSitemname.TabIndex = 10;
            // 
            // cbRSname
            // 
            this.cbRSname.FormattingEnabled = true;
            this.cbRSname.Location = new System.Drawing.Point(117, 40);
            this.cbRSname.Name = "cbRSname";
            this.cbRSname.Size = new System.Drawing.Size(307, 21);
            this.cbRSname.TabIndex = 9;
            // 
            // lblRSdatain
            // 
            this.lblRSdatain.AutoSize = true;
            this.lblRSdatain.Location = new System.Drawing.Point(6, 158);
            this.lblRSdatain.Name = "lblRSdatain";
            this.lblRSdatain.Size = new System.Drawing.Size(53, 13);
            this.lblRSdatain.TabIndex = 8;
            this.lblRSdatain.Text = "Datum In:";
            // 
            // lblRSdataout
            // 
            this.lblRSdataout.AutoSize = true;
            this.lblRSdataout.Location = new System.Drawing.Point(6, 117);
            this.lblRSdataout.Name = "lblRSdataout";
            this.lblRSdataout.Size = new System.Drawing.Size(54, 13);
            this.lblRSdataout.TabIndex = 6;
            this.lblRSdataout.Text = "Datum Uit";
            // 
            // lblRSspotname
            // 
            this.lblRSspotname.AutoSize = true;
            this.lblRSspotname.Location = new System.Drawing.Point(6, 77);
            this.lblRSspotname.Name = "lblRSspotname";
            this.lblRSspotname.Size = new System.Drawing.Size(62, 13);
            this.lblRSspotname.TabIndex = 4;
            this.lblRSspotname.Text = "Plek Naam:";
            // 
            // lblRSname
            // 
            this.lblRSname.AutoSize = true;
            this.lblRSname.Location = new System.Drawing.Point(6, 40);
            this.lblRSname.Name = "lblRSname";
            this.lblRSname.Size = new System.Drawing.Size(38, 13);
            this.lblRSname.TabIndex = 2;
            this.lblRSname.Text = "Naam:";
            // 
            // btnRSreserve
            // 
            this.btnRSreserve.Location = new System.Drawing.Point(324, 200);
            this.btnRSreserve.Name = "btnRSreserve";
            this.btnRSreserve.Size = new System.Drawing.Size(100, 36);
            this.btnRSreserve.TabIndex = 0;
            this.btnRSreserve.Text = "Reserveren";
            this.btnRSreserve.UseVisualStyleBackColor = true;
            // 
            // MedewerkerReserveSpot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 286);
            this.Controls.Add(this.gbReserveSpot);
            this.Name = "MedewerkerReserveSpot";
            this.Text = "Plek Reserveren";
            this.gbReserveSpot.ResumeLayout(false);
            this.gbReserveSpot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRScancel;
        private System.Windows.Forms.GroupBox gbReserveSpot;
        private System.Windows.Forms.DateTimePicker dtpRSdatein;
        private System.Windows.Forms.DateTimePicker dtpRSdateuit;
        private System.Windows.Forms.ComboBox cbRSitemname;
        private System.Windows.Forms.ComboBox cbRSname;
        private System.Windows.Forms.Label lblRSdatain;
        private System.Windows.Forms.Label lblRSdataout;
        private System.Windows.Forms.Label lblRSspotname;
        private System.Windows.Forms.Label lblRSname;
        private System.Windows.Forms.Button btnRSreserve;
    }
}