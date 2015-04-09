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
            this.tbCAname = new System.Windows.Forms.TextBox();
            this.lblCAName = new System.Windows.Forms.Label();
            this.lblCAEmail = new System.Windows.Forms.Label();
            this.tbCAemail = new System.Windows.Forms.TextBox();
            this.lblCApassword = new System.Windows.Forms.Label();
            this.tbCApassword = new System.Windows.Forms.TextBox();
            this.lblCArepassword = new System.Windows.Forms.Label();
            this.tbCArepassword = new System.Windows.Forms.TextBox();
            this.lblCAGroup = new System.Windows.Forms.Label();
            this.cbCAGroup = new System.Windows.Forms.ComboBox();
            this.lbCAeventlist = new System.Windows.Forms.ListBox();
            this.cbCAaddevent = new System.Windows.Forms.ComboBox();
            this.cbCApaymentstat = new System.Windows.Forms.ComboBox();
            this.lblCApaymentstat = new System.Windows.Forms.Label();
            this.lblCAaddEvent = new System.Windows.Forms.Label();
            this.lblCAeventlist = new System.Windows.Forms.Label();
            btnCAaddevent = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCAcreate
            // 
            this.btnCAcreate.Location = new System.Drawing.Point(324, 406);
            this.btnCAcreate.Name = "btnCAcreate";
            this.btnCAcreate.Size = new System.Drawing.Size(100, 36);
            this.btnCAcreate.TabIndex = 0;
            this.btnCAcreate.Text = "Create";
            this.btnCAcreate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Controls.Add(this.lblCAName);
            this.groupBox1.Controls.Add(this.tbCAname);
            this.groupBox1.Controls.Add(this.btnCAcreate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 465);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Aanmaken";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbCAname
            // 
            this.tbCAname.Location = new System.Drawing.Point(114, 37);
            this.tbCAname.Name = "tbCAname";
            this.tbCAname.Size = new System.Drawing.Size(310, 20);
            this.tbCAname.TabIndex = 1;
            // 
            // lblCAName
            // 
            this.lblCAName.AutoSize = true;
            this.lblCAName.Location = new System.Drawing.Point(6, 40);
            this.lblCAName.Name = "lblCAName";
            this.lblCAName.Size = new System.Drawing.Size(38, 13);
            this.lblCAName.TabIndex = 2;
            this.lblCAName.Text = "Naam:";
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
            // lblCAGroup
            // 
            this.lblCAGroup.AutoSize = true;
            this.lblCAGroup.Location = new System.Drawing.Point(6, 190);
            this.lblCAGroup.Name = "lblCAGroup";
            this.lblCAGroup.Size = new System.Drawing.Size(39, 13);
            this.lblCAGroup.TabIndex = 9;
            this.lblCAGroup.Text = "Groep:";
            // 
            // cbCAGroup
            // 
            this.cbCAGroup.FormattingEnabled = true;
            this.cbCAGroup.Location = new System.Drawing.Point(114, 187);
            this.cbCAGroup.Name = "cbCAGroup";
            this.cbCAGroup.Size = new System.Drawing.Size(310, 21);
            this.cbCAGroup.TabIndex = 10;
            // 
            // lbCAeventlist
            // 
            this.lbCAeventlist.FormattingEnabled = true;
            this.lbCAeventlist.Location = new System.Drawing.Point(114, 262);
            this.lbCAeventlist.Name = "lbCAeventlist";
            this.lbCAeventlist.Size = new System.Drawing.Size(310, 82);
            this.lbCAeventlist.TabIndex = 11;
            // 
            // cbCAaddevent
            // 
            this.cbCAaddevent.FormattingEnabled = true;
            this.cbCAaddevent.Location = new System.Drawing.Point(114, 226);
            this.cbCAaddevent.Name = "cbCAaddevent";
            this.cbCAaddevent.Size = new System.Drawing.Size(227, 21);
            this.cbCAaddevent.TabIndex = 12;
            // 
            // btnCAaddevent
            // 
            btnCAaddevent.Location = new System.Drawing.Point(347, 226);
            btnCAaddevent.Name = "btnCAaddevent";
            btnCAaddevent.Size = new System.Drawing.Size(77, 23);
            btnCAaddevent.TabIndex = 13;
            btnCAaddevent.Text = "Toevoegen";
            btnCAaddevent.UseVisualStyleBackColor = true;
            // 
            // cbCApaymentstat
            // 
            this.cbCApaymentstat.FormattingEnabled = true;
            this.cbCApaymentstat.Location = new System.Drawing.Point(114, 367);
            this.cbCApaymentstat.Name = "cbCApaymentstat";
            this.cbCApaymentstat.Size = new System.Drawing.Size(310, 21);
            this.cbCApaymentstat.TabIndex = 15;
            // 
            // lblCApaymentstat
            // 
            this.lblCApaymentstat.AutoSize = true;
            this.lblCApaymentstat.Location = new System.Drawing.Point(6, 370);
            this.lblCApaymentstat.Name = "lblCApaymentstat";
            this.lblCApaymentstat.Size = new System.Drawing.Size(86, 13);
            this.lblCApaymentstat.TabIndex = 14;
            this.lblCApaymentstat.Text = "Betalings Status:";
            // 
            // lblCAaddEvent
            // 
            this.lblCAaddEvent.AutoSize = true;
            this.lblCAaddEvent.Location = new System.Drawing.Point(6, 231);
            this.lblCAaddEvent.Name = "lblCAaddEvent";
            this.lblCAaddEvent.Size = new System.Drawing.Size(96, 13);
            this.lblCAaddEvent.TabIndex = 16;
            this.lblCAaddEvent.Text = "Event Toevoegen:";
            // 
            // lblCAeventlist
            // 
            this.lblCAeventlist.AutoSize = true;
            this.lblCAeventlist.Location = new System.Drawing.Point(6, 262);
            this.lblCAeventlist.Name = "lblCAeventlist";
            this.lblCAeventlist.Size = new System.Drawing.Size(59, 13);
            this.lblCAeventlist.TabIndex = 17;
            this.lblCAeventlist.Text = "Event Lijst:";
            // 
            // MederwerkerCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 494);
            this.Controls.Add(this.groupBox1);
            this.Name = "MederwerkerCreateAccount";
            this.Text = "MederwerkerCreateAccount";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCAcreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCAName;
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
    }
}