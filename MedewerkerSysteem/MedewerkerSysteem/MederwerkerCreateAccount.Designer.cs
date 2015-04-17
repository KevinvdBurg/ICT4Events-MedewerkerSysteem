namespace MedewerkerSysteem
{
    partial class MederwerkerCreateAccount
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
            System.Windows.Forms.Button btnCAaddevent;
            this.btnCAcreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCAlastname = new System.Windows.Forms.TextBox();
            this.lblCAlastname = new System.Windows.Forms.Label();
            this.lblCAcountry = new System.Windows.Forms.Label();
            this.tbCAcountry = new System.Windows.Forms.TextBox();
            this.tbCAcity = new System.Windows.Forms.TextBox();
            this.lblCAcity = new System.Windows.Forms.Label();
            this.lblCAzipcode = new System.Windows.Forms.Label();
            this.tbCAzipcode = new System.Windows.Forms.TextBox();
            this.tbCAstreetname = new System.Windows.Forms.TextBox();
            this.lblCAstreetname = new System.Windows.Forms.Label();
            this.btnCAcancel = new System.Windows.Forms.Button();
            this.lblCAeventlist = new System.Windows.Forms.Label();
            this.lblCAaddEvent = new System.Windows.Forms.Label();
            this.cbCApaymentstat = new System.Windows.Forms.ComboBox();
            this.lblCApaymentstat = new System.Windows.Forms.Label();
            this.cbCAaddevent = new System.Windows.Forms.ComboBox();
            this.lbCAeventlist = new System.Windows.Forms.ListBox();
            this.cbCAGroup = new System.Windows.Forms.ComboBox();
            this.lblCAGroup = new System.Windows.Forms.Label();
            this.lblCArepassword = new System.Windows.Forms.Label();
            this.tbCArepassword = new System.Windows.Forms.TextBox();
            this.lblCApassword = new System.Windows.Forms.Label();
            this.tbCApassword = new System.Windows.Forms.TextBox();
            this.lblCAEmail = new System.Windows.Forms.Label();
            this.tbCAemail = new System.Windows.Forms.TextBox();
            this.lblCAfirstname = new System.Windows.Forms.Label();
            this.tbCAname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCARFID = new System.Windows.Forms.TextBox();
            btnCAaddevent = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCAaddevent
            // 
            btnCAaddevent.Location = new System.Drawing.Point(347, 314);
            btnCAaddevent.Name = "btnCAaddevent";
            btnCAaddevent.Size = new System.Drawing.Size(77, 23);
            btnCAaddevent.TabIndex = 13;
            btnCAaddevent.Text = "Toevoegen";
            btnCAaddevent.UseVisualStyleBackColor = true;
            btnCAaddevent.Click += new System.EventHandler(this.btnCAaddevent_Click);
            // 
            // btnCAcreate
            // 
            this.btnCAcreate.Location = new System.Drawing.Point(324, 511);
            this.btnCAcreate.Name = "btnCAcreate";
            this.btnCAcreate.Size = new System.Drawing.Size(100, 36);
            this.btnCAcreate.TabIndex = 0;
            this.btnCAcreate.Text = "Aanmaken";
            this.btnCAcreate.UseVisualStyleBackColor = true;
            this.btnCAcreate.Click += new System.EventHandler(this.btnCAcreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbCARFID);
            this.groupBox1.Controls.Add(this.tbCAlastname);
            this.groupBox1.Controls.Add(this.lblCAlastname);
            this.groupBox1.Controls.Add(this.lblCAcountry);
            this.groupBox1.Controls.Add(this.tbCAcountry);
            this.groupBox1.Controls.Add(this.tbCAcity);
            this.groupBox1.Controls.Add(this.lblCAcity);
            this.groupBox1.Controls.Add(this.lblCAzipcode);
            this.groupBox1.Controls.Add(this.tbCAzipcode);
            this.groupBox1.Controls.Add(this.tbCAstreetname);
            this.groupBox1.Controls.Add(this.lblCAstreetname);
            this.groupBox1.Controls.Add(this.btnCAcancel);
            this.groupBox1.Controls.Add(this.lblCAeventlist);
            this.groupBox1.Controls.Add(this.lblCAaddEvent);
            this.groupBox1.Controls.Add(this.cbCApaymentstat);
            this.groupBox1.Controls.Add(this.lblCApaymentstat);
            this.groupBox1.Controls.Add(btnCAaddevent);
            this.groupBox1.Controls.Add(this.cbCAaddevent);
            this.groupBox1.Controls.Add(this.lbCAeventlist);
            this.groupBox1.Controls.Add(this.cbCAGroup);
            this.groupBox1.Controls.Add(this.lblCAGroup);
            this.groupBox1.Controls.Add(this.lblCArepassword);
            this.groupBox1.Controls.Add(this.tbCArepassword);
            this.groupBox1.Controls.Add(this.lblCApassword);
            this.groupBox1.Controls.Add(this.tbCApassword);
            this.groupBox1.Controls.Add(this.lblCAEmail);
            this.groupBox1.Controls.Add(this.tbCAemail);
            this.groupBox1.Controls.Add(this.lblCAfirstname);
            this.groupBox1.Controls.Add(this.tbCAname);
            this.groupBox1.Controls.Add(this.btnCAcreate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 553);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Aanmaken";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbCAlastname
            // 
            this.tbCAlastname.Location = new System.Drawing.Point(299, 36);
            this.tbCAlastname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCAlastname.Name = "tbCAlastname";
            this.tbCAlastname.Size = new System.Drawing.Size(125, 20);
            this.tbCAlastname.TabIndex = 28;
            // 
            // lblCAlastname
            // 
            this.lblCAlastname.AutoSize = true;
            this.lblCAlastname.Location = new System.Drawing.Point(228, 40);
            this.lblCAlastname.Name = "lblCAlastname";
            this.lblCAlastname.Size = new System.Drawing.Size(67, 13);
            this.lblCAlastname.TabIndex = 27;
            this.lblCAlastname.Text = "Achternaam:";
            // 
            // lblCAcountry
            // 
            this.lblCAcountry.AutoSize = true;
            this.lblCAcountry.Location = new System.Drawing.Point(10, 245);
            this.lblCAcountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCAcountry.Name = "lblCAcountry";
            this.lblCAcountry.Size = new System.Drawing.Size(34, 13);
            this.lblCAcountry.TabIndex = 26;
            this.lblCAcountry.Text = "Land:";
            // 
            // tbCAcountry
            // 
            this.tbCAcountry.Location = new System.Drawing.Point(114, 241);
            this.tbCAcountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCAcountry.Name = "tbCAcountry";
            this.tbCAcountry.Size = new System.Drawing.Size(310, 20);
            this.tbCAcountry.TabIndex = 25;
            // 
            // tbCAcity
            // 
            this.tbCAcity.Location = new System.Drawing.Point(114, 210);
            this.tbCAcity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCAcity.Name = "tbCAcity";
            this.tbCAcity.Size = new System.Drawing.Size(310, 20);
            this.tbCAcity.TabIndex = 24;
            // 
            // lblCAcity
            // 
            this.lblCAcity.AutoSize = true;
            this.lblCAcity.Location = new System.Drawing.Point(8, 214);
            this.lblCAcity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCAcity.Name = "lblCAcity";
            this.lblCAcity.Size = new System.Drawing.Size(32, 13);
            this.lblCAcity.TabIndex = 23;
            this.lblCAcity.Text = "Stad:";
            // 
            // lblCAzipcode
            // 
            this.lblCAzipcode.AutoSize = true;
            this.lblCAzipcode.Location = new System.Drawing.Point(262, 190);
            this.lblCAzipcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCAzipcode.Name = "lblCAzipcode";
            this.lblCAzipcode.Size = new System.Drawing.Size(55, 13);
            this.lblCAzipcode.TabIndex = 22;
            this.lblCAzipcode.Text = "Postcode:";
            // 
            // tbCAzipcode
            // 
            this.tbCAzipcode.Location = new System.Drawing.Point(310, 186);
            this.tbCAzipcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCAzipcode.Name = "tbCAzipcode";
            this.tbCAzipcode.Size = new System.Drawing.Size(114, 20);
            this.tbCAzipcode.TabIndex = 21;
            // 
            // tbCAstreetname
            // 
            this.tbCAstreetname.Location = new System.Drawing.Point(114, 186);
            this.tbCAstreetname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCAstreetname.Name = "tbCAstreetname";
            this.tbCAstreetname.Size = new System.Drawing.Size(144, 20);
            this.tbCAstreetname.TabIndex = 20;
            // 
            // lblCAstreetname
            // 
            this.lblCAstreetname.AutoSize = true;
            this.lblCAstreetname.Location = new System.Drawing.Point(8, 186);
            this.lblCAstreetname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCAstreetname.Name = "lblCAstreetname";
            this.lblCAstreetname.Size = new System.Drawing.Size(37, 13);
            this.lblCAstreetname.TabIndex = 19;
            this.lblCAstreetname.Text = "Adres:";
            // 
            // btnCAcancel
            // 
            this.btnCAcancel.Location = new System.Drawing.Point(218, 511);
            this.btnCAcancel.Name = "btnCAcancel";
            this.btnCAcancel.Size = new System.Drawing.Size(100, 36);
            this.btnCAcancel.TabIndex = 18;
            this.btnCAcancel.Text = "Annuleren";
            this.btnCAcancel.UseVisualStyleBackColor = true;
            this.btnCAcancel.Click += new System.EventHandler(this.btnCAcancel_Click);
            // 
            // lblCAeventlist
            // 
            this.lblCAeventlist.AutoSize = true;
            this.lblCAeventlist.Location = new System.Drawing.Point(6, 349);
            this.lblCAeventlist.Name = "lblCAeventlist";
            this.lblCAeventlist.Size = new System.Drawing.Size(59, 13);
            this.lblCAeventlist.TabIndex = 17;
            this.lblCAeventlist.Text = "Event Lijst:";
            // 
            // lblCAaddEvent
            // 
            this.lblCAaddEvent.AutoSize = true;
            this.lblCAaddEvent.Location = new System.Drawing.Point(6, 318);
            this.lblCAaddEvent.Name = "lblCAaddEvent";
            this.lblCAaddEvent.Size = new System.Drawing.Size(96, 13);
            this.lblCAaddEvent.TabIndex = 16;
            this.lblCAaddEvent.Text = "Event Toevoegen:";
            // 
            // cbCApaymentstat
            // 
            this.cbCApaymentstat.FormattingEnabled = true;
            this.cbCApaymentstat.Location = new System.Drawing.Point(114, 472);
            this.cbCApaymentstat.Name = "cbCApaymentstat";
            this.cbCApaymentstat.Size = new System.Drawing.Size(310, 21);
            this.cbCApaymentstat.TabIndex = 15;
            // 
            // lblCApaymentstat
            // 
            this.lblCApaymentstat.AutoSize = true;
            this.lblCApaymentstat.Location = new System.Drawing.Point(6, 474);
            this.lblCApaymentstat.Name = "lblCApaymentstat";
            this.lblCApaymentstat.Size = new System.Drawing.Size(86, 13);
            this.lblCApaymentstat.TabIndex = 14;
            this.lblCApaymentstat.Text = "Betalings Status:";
            // 
            // cbCAaddevent
            // 
            this.cbCAaddevent.FormattingEnabled = true;
            this.cbCAaddevent.Location = new System.Drawing.Point(114, 314);
            this.cbCAaddevent.Name = "cbCAaddevent";
            this.cbCAaddevent.Size = new System.Drawing.Size(227, 21);
            this.cbCAaddevent.TabIndex = 12;
            // 
            // lbCAeventlist
            // 
            this.lbCAeventlist.FormattingEnabled = true;
            this.lbCAeventlist.Location = new System.Drawing.Point(114, 349);
            this.lbCAeventlist.Name = "lbCAeventlist";
            this.lbCAeventlist.Size = new System.Drawing.Size(310, 82);
            this.lbCAeventlist.TabIndex = 11;
            // 
            // cbCAGroup
            // 
            this.cbCAGroup.FormattingEnabled = true;
            this.cbCAGroup.Location = new System.Drawing.Point(114, 275);
            this.cbCAGroup.Name = "cbCAGroup";
            this.cbCAGroup.Size = new System.Drawing.Size(310, 21);
            this.cbCAGroup.TabIndex = 10;
            // 
            // lblCAGroup
            // 
            this.lblCAGroup.AutoSize = true;
            this.lblCAGroup.Location = new System.Drawing.Point(6, 280);
            this.lblCAGroup.Name = "lblCAGroup";
            this.lblCAGroup.Size = new System.Drawing.Size(39, 13);
            this.lblCAGroup.TabIndex = 9;
            this.lblCAGroup.Text = "Groep:";
            // 
            // lblCArepassword
            // 
            this.lblCArepassword.AutoSize = true;
            this.lblCArepassword.Location = new System.Drawing.Point(6, 158);
            this.lblCArepassword.Name = "lblCArepassword";
            this.lblCArepassword.Size = new System.Drawing.Size(91, 13);
            this.lblCArepassword.TabIndex = 8;
            this.lblCArepassword.Text = "Her-Wachtwoord:";
            // 
            // tbCArepassword
            // 
            this.tbCArepassword.Location = new System.Drawing.Point(114, 155);
            this.tbCArepassword.Name = "tbCArepassword";
            this.tbCArepassword.Size = new System.Drawing.Size(310, 20);
            this.tbCArepassword.TabIndex = 7;
            // 
            // lblCApassword
            // 
            this.lblCApassword.AutoSize = true;
            this.lblCApassword.Location = new System.Drawing.Point(6, 117);
            this.lblCApassword.Name = "lblCApassword";
            this.lblCApassword.Size = new System.Drawing.Size(71, 13);
            this.lblCApassword.TabIndex = 6;
            this.lblCApassword.Text = "Wachtwoord:";
            // 
            // tbCApassword
            // 
            this.tbCApassword.Location = new System.Drawing.Point(114, 114);
            this.tbCApassword.Name = "tbCApassword";
            this.tbCApassword.Size = new System.Drawing.Size(310, 20);
            this.tbCApassword.TabIndex = 5;
            // 
            // lblCAEmail
            // 
            this.lblCAEmail.AutoSize = true;
            this.lblCAEmail.Location = new System.Drawing.Point(6, 77);
            this.lblCAEmail.Name = "lblCAEmail";
            this.lblCAEmail.Size = new System.Drawing.Size(38, 13);
            this.lblCAEmail.TabIndex = 4;
            this.lblCAEmail.Text = "E-mail:";
            // 
            // tbCAemail
            // 
            this.tbCAemail.Location = new System.Drawing.Point(114, 74);
            this.tbCAemail.Name = "tbCAemail";
            this.tbCAemail.Size = new System.Drawing.Size(310, 20);
            this.tbCAemail.TabIndex = 3;
            // 
            // lblCAfirstname
            // 
            this.lblCAfirstname.AutoSize = true;
            this.lblCAfirstname.Location = new System.Drawing.Point(6, 40);
            this.lblCAfirstname.Name = "lblCAfirstname";
            this.lblCAfirstname.Size = new System.Drawing.Size(58, 13);
            this.lblCAfirstname.TabIndex = 2;
            this.lblCAfirstname.Text = "Voornaam:";
            // 
            // tbCAname
            // 
            this.tbCAname.Location = new System.Drawing.Point(114, 37);
            this.tbCAname.Name = "tbCAname";
            this.tbCAname.Size = new System.Drawing.Size(109, 20);
            this.tbCAname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "RFID:";
            // 
            // tbCARFID
            // 
            this.tbCARFID.Location = new System.Drawing.Point(114, 437);
            this.tbCARFID.Name = "tbCARFID";
            this.tbCARFID.Size = new System.Drawing.Size(310, 20);
            this.tbCARFID.TabIndex = 29;
            // 
            // MederwerkerCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 577);
            this.Controls.Add(this.groupBox1);
            this.Name = "MederwerkerCreateAccount";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.MederwerkerCreateAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCAcreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCAfirstname;
        private System.Windows.Forms.TextBox tbCAname;
        private System.Windows.Forms.Label lblCArepassword;
        private System.Windows.Forms.TextBox tbCArepassword;
        private System.Windows.Forms.Label lblCApassword;
        private System.Windows.Forms.TextBox tbCApassword;
        private System.Windows.Forms.Label lblCAEmail;
        private System.Windows.Forms.TextBox tbCAemail;
        private System.Windows.Forms.Label lblCAeventlist;
        private System.Windows.Forms.Label lblCAaddEvent;
        private System.Windows.Forms.ComboBox cbCApaymentstat;
        private System.Windows.Forms.Label lblCApaymentstat;
        private System.Windows.Forms.ComboBox cbCAaddevent;
        private System.Windows.Forms.ListBox lbCAeventlist;
        private System.Windows.Forms.ComboBox cbCAGroup;
        private System.Windows.Forms.Label lblCAGroup;
        private System.Windows.Forms.Button btnCAcancel;
        private System.Windows.Forms.Label lblCAstreetname;
        private System.Windows.Forms.Label lblCAzipcode;
        private System.Windows.Forms.TextBox tbCAzipcode;
        private System.Windows.Forms.TextBox tbCAstreetname;
        private System.Windows.Forms.Label lblCAcountry;
        private System.Windows.Forms.TextBox tbCAcountry;
        private System.Windows.Forms.TextBox tbCAcity;
        private System.Windows.Forms.Label lblCAcity;
        private System.Windows.Forms.TextBox tbCAlastname;
        private System.Windows.Forms.Label lblCAlastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCARFID;
    }
}