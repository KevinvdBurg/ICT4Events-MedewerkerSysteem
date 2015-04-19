namespace MedewerkerSysteem
{
    partial class MedewerkerMedia
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
            this.gbMediaReports = new System.Windows.Forms.GroupBox();
            this.nudMreportcount = new System.Windows.Forms.NumericUpDown();
            this.btnMbrowse = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.tbMname = new System.Windows.Forms.TextBox();
            this.rtbMtext = new System.Windows.Forms.RichTextBox();
            this.btnMcancel = new System.Windows.Forms.Button();
            this.lblMreport = new System.Windows.Forms.Label();
            this.lblMFile = new System.Windows.Forms.Label();
            this.lblMtext = new System.Windows.Forms.Label();
            this.lblMname = new System.Windows.Forms.Label();
            this.btnMdelete = new System.Windows.Forms.Button();
            this.gbMediaReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMreportcount)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMediaReports
            // 
            this.gbMediaReports.Controls.Add(this.nudMreportcount);
            this.gbMediaReports.Controls.Add(this.btnMbrowse);
            this.gbMediaReports.Controls.Add(this.tbFile);
            this.gbMediaReports.Controls.Add(this.tbMname);
            this.gbMediaReports.Controls.Add(this.rtbMtext);
            this.gbMediaReports.Controls.Add(this.btnMcancel);
            this.gbMediaReports.Controls.Add(this.lblMreport);
            this.gbMediaReports.Controls.Add(this.lblMFile);
            this.gbMediaReports.Controls.Add(this.lblMtext);
            this.gbMediaReports.Controls.Add(this.lblMname);
            this.gbMediaReports.Controls.Add(this.btnMdelete);
            this.gbMediaReports.Location = new System.Drawing.Point(12, 12);
            this.gbMediaReports.Name = "gbMediaReports";
            this.gbMediaReports.Size = new System.Drawing.Size(451, 370);
            this.gbMediaReports.TabIndex = 5;
            this.gbMediaReports.TabStop = false;
            this.gbMediaReports.Text = "Media Reports";
            // 
            // nudMreportcount
            // 
            this.nudMreportcount.Location = new System.Drawing.Point(118, 214);
            this.nudMreportcount.Name = "nudMreportcount";
            this.nudMreportcount.Size = new System.Drawing.Size(306, 20);
            this.nudMreportcount.TabIndex = 22;
            // 
            // btnMbrowse
            // 
            this.btnMbrowse.Location = new System.Drawing.Point(349, 184);
            this.btnMbrowse.Name = "btnMbrowse";
            this.btnMbrowse.Size = new System.Drawing.Size(75, 23);
            this.btnMbrowse.TabIndex = 21;
            this.btnMbrowse.Text = "Zoek";
            this.btnMbrowse.UseVisualStyleBackColor = true;
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(118, 184);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(225, 20);
            this.tbFile.TabIndex = 20;
            // 
            // tbMname
            // 
            this.tbMname.Location = new System.Drawing.Point(118, 37);
            this.tbMname.Name = "tbMname";
            this.tbMname.Size = new System.Drawing.Size(306, 20);
            this.tbMname.TabIndex = 19;
            // 
            // rtbMtext
            // 
            this.rtbMtext.Location = new System.Drawing.Point(118, 74);
            this.rtbMtext.Name = "rtbMtext";
            this.rtbMtext.Size = new System.Drawing.Size(306, 96);
            this.rtbMtext.TabIndex = 18;
            this.rtbMtext.Text = "";
            // 
            // btnMcancel
            // 
            this.btnMcancel.Location = new System.Drawing.Point(219, 255);
            this.btnMcancel.Name = "btnMcancel";
            this.btnMcancel.Size = new System.Drawing.Size(100, 36);
            this.btnMcancel.TabIndex = 13;
            this.btnMcancel.Text = "Annuleren";
            this.btnMcancel.UseVisualStyleBackColor = true;
            this.btnMcancel.Click += new System.EventHandler(this.btnMcancel_Click);
            // 
            // lblMreport
            // 
            this.lblMreport.AutoSize = true;
            this.lblMreport.Location = new System.Drawing.Point(6, 216);
            this.lblMreport.Name = "lblMreport";
            this.lblMreport.Size = new System.Drawing.Size(73, 13);
            this.lblMreport.TabIndex = 8;
            this.lblMreport.Text = "Report Count:";
            this.lblMreport.Click += new System.EventHandler(this.lblMreport_Click);
            // 
            // lblMFile
            // 
            this.lblMFile.AutoSize = true;
            this.lblMFile.Location = new System.Drawing.Point(6, 187);
            this.lblMFile.Name = "lblMFile";
            this.lblMFile.Size = new System.Drawing.Size(49, 13);
            this.lblMFile.TabIndex = 6;
            this.lblMFile.Text = "Bestand:";
            this.lblMFile.Click += new System.EventHandler(this.lblMFile_Click);
            // 
            // lblMtext
            // 
            this.lblMtext.AutoSize = true;
            this.lblMtext.Location = new System.Drawing.Point(6, 77);
            this.lblMtext.Name = "lblMtext";
            this.lblMtext.Size = new System.Drawing.Size(37, 13);
            this.lblMtext.TabIndex = 4;
            this.lblMtext.Text = "Tekst:";
            // 
            // lblMname
            // 
            this.lblMname.AutoSize = true;
            this.lblMname.Location = new System.Drawing.Point(6, 40);
            this.lblMname.Name = "lblMname";
            this.lblMname.Size = new System.Drawing.Size(38, 13);
            this.lblMname.TabIndex = 2;
            this.lblMname.Text = "Naam:";
            // 
            // btnMdelete
            // 
            this.btnMdelete.Location = new System.Drawing.Point(325, 255);
            this.btnMdelete.Name = "btnMdelete";
            this.btnMdelete.Size = new System.Drawing.Size(100, 36);
            this.btnMdelete.TabIndex = 0;
            this.btnMdelete.Text = "Delete";
            this.btnMdelete.UseVisualStyleBackColor = true;
            this.btnMdelete.Click += new System.EventHandler(this.btnMdelete_Click);
            // 
            // MedewerkerMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 394);
            this.Controls.Add(this.gbMediaReports);
            this.Name = "MedewerkerMedia";
            this.Text = "Media Reports";
            this.Load += new System.EventHandler(this.MedewerkerMedia_Load);
            this.gbMediaReports.ResumeLayout(false);
            this.gbMediaReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMreportcount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMediaReports;
        private System.Windows.Forms.RichTextBox rtbMtext;
        private System.Windows.Forms.Button btnMcancel;
        private System.Windows.Forms.Label lblMreport;
        private System.Windows.Forms.Label lblMFile;
        private System.Windows.Forms.Label lblMtext;
        private System.Windows.Forms.Label lblMname;
        private System.Windows.Forms.Button btnMdelete;
        private System.Windows.Forms.NumericUpDown nudMreportcount;
        private System.Windows.Forms.Button btnMbrowse;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.TextBox tbMname;
    }
}