namespace MedewerkerSysteem
{
    partial class MedewerkerReserveItem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIRcancel = new System.Windows.Forms.Button();
            this.dtpIRdatein = new System.Windows.Forms.DateTimePicker();
            this.dtpIRdateuit = new System.Windows.Forms.DateTimePicker();
            this.cbIRitemname = new System.Windows.Forms.ComboBox();
            this.cbIRname = new System.Windows.Forms.ComboBox();
            this.lblIRdatain = new System.Windows.Forms.Label();
            this.lblIRdataout = new System.Windows.Forms.Label();
            this.lblIRitemname = new System.Windows.Forms.Label();
            this.lblIRname = new System.Windows.Forms.Label();
            this.btnIRreserve = new System.Windows.Forms.Button();
            this.cbRIpaid = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRIpaid);
            this.groupBox1.Controls.Add(this.btnIRcancel);
            this.groupBox1.Controls.Add(this.dtpIRdatein);
            this.groupBox1.Controls.Add(this.dtpIRdateuit);
            this.groupBox1.Controls.Add(this.cbIRitemname);
            this.groupBox1.Controls.Add(this.cbIRname);
            this.groupBox1.Controls.Add(this.lblIRdatain);
            this.groupBox1.Controls.Add(this.lblIRdataout);
            this.groupBox1.Controls.Add(this.lblIRitemname);
            this.groupBox1.Controls.Add(this.lblIRname);
            this.groupBox1.Controls.Add(this.btnIRreserve);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(601, 325);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Reserveren";
            // 
            // btnIRcancel
            // 
            this.btnIRcancel.Location = new System.Drawing.Point(290, 258);
            this.btnIRcancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIRcancel.Name = "btnIRcancel";
            this.btnIRcancel.Size = new System.Drawing.Size(133, 44);
            this.btnIRcancel.TabIndex = 13;
            this.btnIRcancel.Text = "Annuleren";
            this.btnIRcancel.UseVisualStyleBackColor = true;
            this.btnIRcancel.Click += new System.EventHandler(this.btnIRcancel_Click);
            // 
            // dtpIRdatein
            // 
            this.dtpIRdatein.Location = new System.Drawing.Point(156, 187);
            this.dtpIRdatein.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpIRdatein.Name = "dtpIRdatein";
            this.dtpIRdatein.Size = new System.Drawing.Size(408, 22);
            this.dtpIRdatein.TabIndex = 12;
            // 
            // dtpIRdateuit
            // 
            this.dtpIRdateuit.Location = new System.Drawing.Point(156, 144);
            this.dtpIRdateuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpIRdateuit.Name = "dtpIRdateuit";
            this.dtpIRdateuit.Size = new System.Drawing.Size(408, 22);
            this.dtpIRdateuit.TabIndex = 11;
            // 
            // cbIRitemname
            // 
            this.cbIRitemname.FormattingEnabled = true;
            this.cbIRitemname.Location = new System.Drawing.Point(156, 95);
            this.cbIRitemname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbIRitemname.Name = "cbIRitemname";
            this.cbIRitemname.Size = new System.Drawing.Size(408, 24);
            this.cbIRitemname.TabIndex = 10;
            // 
            // cbIRname
            // 
            this.cbIRname.FormattingEnabled = true;
            this.cbIRname.Location = new System.Drawing.Point(156, 49);
            this.cbIRname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbIRname.Name = "cbIRname";
            this.cbIRname.Size = new System.Drawing.Size(408, 24);
            this.cbIRname.TabIndex = 9;
            // 
            // lblIRdatain
            // 
            this.lblIRdatain.AutoSize = true;
            this.lblIRdatain.Location = new System.Drawing.Point(8, 194);
            this.lblIRdatain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIRdatain.Name = "lblIRdatain";
            this.lblIRdatain.Size = new System.Drawing.Size(68, 17);
            this.lblIRdatain.TabIndex = 8;
            this.lblIRdatain.Text = "Datum In:";
            // 
            // lblIRdataout
            // 
            this.lblIRdataout.AutoSize = true;
            this.lblIRdataout.Location = new System.Drawing.Point(8, 144);
            this.lblIRdataout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIRdataout.Name = "lblIRdataout";
            this.lblIRdataout.Size = new System.Drawing.Size(70, 17);
            this.lblIRdataout.TabIndex = 6;
            this.lblIRdataout.Text = "Datum Uit";
            // 
            // lblIRitemname
            // 
            this.lblIRitemname.AutoSize = true;
            this.lblIRitemname.Location = new System.Drawing.Point(8, 95);
            this.lblIRitemname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIRitemname.Name = "lblIRitemname";
            this.lblIRitemname.Size = new System.Drawing.Size(79, 17);
            this.lblIRitemname.TabIndex = 4;
            this.lblIRitemname.Text = "Item Naam:";
            // 
            // lblIRname
            // 
            this.lblIRname.AutoSize = true;
            this.lblIRname.Location = new System.Drawing.Point(8, 49);
            this.lblIRname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIRname.Name = "lblIRname";
            this.lblIRname.Size = new System.Drawing.Size(46, 17);
            this.lblIRname.TabIndex = 2;
            this.lblIRname.Text = "Email:";
            // 
            // btnIRreserve
            // 
            this.btnIRreserve.Location = new System.Drawing.Point(431, 258);
            this.btnIRreserve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIRreserve.Name = "btnIRreserve";
            this.btnIRreserve.Size = new System.Drawing.Size(133, 44);
            this.btnIRreserve.TabIndex = 0;
            this.btnIRreserve.Text = "Create";
            this.btnIRreserve.UseVisualStyleBackColor = true;
            this.btnIRreserve.Click += new System.EventHandler(this.btnIRreserve_Click);
            // 
            // cbRIpaid
            // 
            this.cbRIpaid.AutoSize = true;
            this.cbRIpaid.Location = new System.Drawing.Point(466, 216);
            this.cbRIpaid.Name = "cbRIpaid";
            this.cbRIpaid.Size = new System.Drawing.Size(78, 21);
            this.cbRIpaid.TabIndex = 14;
            this.cbRIpaid.Text = "Betaald";
            this.cbRIpaid.UseVisualStyleBackColor = true;
            // 
            // MedewerkerReserveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 356);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MedewerkerReserveItem";
            this.Text = "Item Reserveren";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIRcancel;
        private System.Windows.Forms.DateTimePicker dtpIRdatein;
        private System.Windows.Forms.DateTimePicker dtpIRdateuit;
        private System.Windows.Forms.ComboBox cbIRitemname;
        private System.Windows.Forms.ComboBox cbIRname;
        private System.Windows.Forms.Label lblIRdatain;
        private System.Windows.Forms.Label lblIRdataout;
        private System.Windows.Forms.Label lblIRitemname;
        private System.Windows.Forms.Label lblIRname;
        private System.Windows.Forms.Button btnIRreserve;
        private System.Windows.Forms.CheckBox cbRIpaid;
    }
}