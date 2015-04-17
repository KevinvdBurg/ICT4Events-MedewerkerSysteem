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
            this.cbRSspotnumbers = new System.Windows.Forms.ComboBox();
            this.cbRSname = new System.Windows.Forms.ComboBox();
            this.lblRSdatain = new System.Windows.Forms.Label();
            this.lblRSdataout = new System.Windows.Forms.Label();
            this.lblRSspotname = new System.Windows.Forms.Label();
            this.lblRSname = new System.Windows.Forms.Label();
            this.btnRSreserve = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.gbReserveSpot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRScancel
            // 
            this.btnRScancel.Location = new System.Drawing.Point(291, 246);
            this.btnRScancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRScancel.Name = "btnRScancel";
            this.btnRScancel.Size = new System.Drawing.Size(133, 44);
            this.btnRScancel.TabIndex = 13;
            this.btnRScancel.Text = "Annuleren";
            this.btnRScancel.UseVisualStyleBackColor = true;
            this.btnRScancel.Click += new System.EventHandler(this.btnRScancel_Click);
            // 
            // gbReserveSpot
            // 
            this.gbReserveSpot.Controls.Add(this.label1);
            this.gbReserveSpot.Controls.Add(this.numericUpDown1);
            this.gbReserveSpot.Controls.Add(this.btnRScancel);
            this.gbReserveSpot.Controls.Add(this.dtpRSdatein);
            this.gbReserveSpot.Controls.Add(this.dtpRSdateuit);
            this.gbReserveSpot.Controls.Add(this.cbRSspotnumbers);
            this.gbReserveSpot.Controls.Add(this.cbRSname);
            this.gbReserveSpot.Controls.Add(this.lblRSdatain);
            this.gbReserveSpot.Controls.Add(this.lblRSdataout);
            this.gbReserveSpot.Controls.Add(this.lblRSspotname);
            this.gbReserveSpot.Controls.Add(this.lblRSname);
            this.gbReserveSpot.Controls.Add(this.btnRSreserve);
            this.gbReserveSpot.Location = new System.Drawing.Point(16, 15);
            this.gbReserveSpot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbReserveSpot.Name = "gbReserveSpot";
            this.gbReserveSpot.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbReserveSpot.Size = new System.Drawing.Size(601, 325);
            this.gbReserveSpot.TabIndex = 3;
            this.gbReserveSpot.TabStop = false;
            this.gbReserveSpot.Text = "Plek Reserveren";
            // 
            // dtpRSdatein
            // 
            this.dtpRSdatein.Location = new System.Drawing.Point(165, 213);
            this.dtpRSdatein.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpRSdatein.Name = "dtpRSdatein";
            this.dtpRSdatein.Size = new System.Drawing.Size(400, 22);
            this.dtpRSdatein.TabIndex = 12;
            // 
            // dtpRSdateuit
            // 
            this.dtpRSdateuit.Location = new System.Drawing.Point(165, 170);
            this.dtpRSdateuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpRSdateuit.Name = "dtpRSdateuit";
            this.dtpRSdateuit.Size = new System.Drawing.Size(400, 22);
            this.dtpRSdateuit.TabIndex = 11;
            // 
            // cbRSspotnumbers
            // 
            this.cbRSspotnumbers.FormattingEnabled = true;
            this.cbRSspotnumbers.Location = new System.Drawing.Point(165, 81);
            this.cbRSspotnumbers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRSspotnumbers.Name = "cbRSspotnumbers";
            this.cbRSspotnumbers.Size = new System.Drawing.Size(400, 24);
            this.cbRSspotnumbers.TabIndex = 10;
            // 
            // cbRSname
            // 
            this.cbRSname.FormattingEnabled = true;
            this.cbRSname.Location = new System.Drawing.Point(165, 49);
            this.cbRSname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRSname.Name = "cbRSname";
            this.cbRSname.Size = new System.Drawing.Size(399, 24);
            this.cbRSname.TabIndex = 9;
            // 
            // lblRSdatain
            // 
            this.lblRSdatain.AutoSize = true;
            this.lblRSdatain.Location = new System.Drawing.Point(9, 220);
            this.lblRSdatain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRSdatain.Name = "lblRSdatain";
            this.lblRSdatain.Size = new System.Drawing.Size(68, 17);
            this.lblRSdatain.TabIndex = 8;
            this.lblRSdatain.Text = "Datum In:";
            // 
            // lblRSdataout
            // 
            this.lblRSdataout.AutoSize = true;
            this.lblRSdataout.Location = new System.Drawing.Point(9, 170);
            this.lblRSdataout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRSdataout.Name = "lblRSdataout";
            this.lblRSdataout.Size = new System.Drawing.Size(70, 17);
            this.lblRSdataout.TabIndex = 6;
            this.lblRSdataout.Text = "Datum Uit";
            // 
            // lblRSspotname
            // 
            this.lblRSspotname.AutoSize = true;
            this.lblRSspotname.Location = new System.Drawing.Point(9, 81);
            this.lblRSspotname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRSspotname.Name = "lblRSspotname";
            this.lblRSspotname.Size = new System.Drawing.Size(94, 17);
            this.lblRSspotname.TabIndex = 4;
            this.lblRSspotname.Text = "Plek nummer:";
            // 
            // lblRSname
            // 
            this.lblRSname.AutoSize = true;
            this.lblRSname.Location = new System.Drawing.Point(8, 49);
            this.lblRSname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRSname.Name = "lblRSname";
            this.lblRSname.Size = new System.Drawing.Size(49, 17);
            this.lblRSname.TabIndex = 2;
            this.lblRSname.Text = "Naam:";
            // 
            // btnRSreserve
            // 
            this.btnRSreserve.Location = new System.Drawing.Point(432, 246);
            this.btnRSreserve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRSreserve.Name = "btnRSreserve";
            this.btnRSreserve.Size = new System.Drawing.Size(133, 44);
            this.btnRSreserve.TabIndex = 0;
            this.btnRSreserve.Text = "Reserveren";
            this.btnRSreserve.UseVisualStyleBackColor = true;
            this.btnRSreserve.Click += new System.EventHandler(this.btnRSreserve_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(165, 129);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Reserveringsnummer:";
            // 
            // MedewerkerReserveSpot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 352);
            this.Controls.Add(this.gbReserveSpot);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MedewerkerReserveSpot";
            this.Text = "Plek Reserveren";
            this.gbReserveSpot.ResumeLayout(false);
            this.gbReserveSpot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRScancel;
        private System.Windows.Forms.GroupBox gbReserveSpot;
        private System.Windows.Forms.DateTimePicker dtpRSdatein;
        private System.Windows.Forms.DateTimePicker dtpRSdateuit;
        private System.Windows.Forms.ComboBox cbRSspotnumbers;
        private System.Windows.Forms.ComboBox cbRSname;
        private System.Windows.Forms.Label lblRSdatain;
        private System.Windows.Forms.Label lblRSdataout;
        private System.Windows.Forms.Label lblRSspotname;
        private System.Windows.Forms.Label lblRSname;
        private System.Windows.Forms.Button btnRSreserve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}