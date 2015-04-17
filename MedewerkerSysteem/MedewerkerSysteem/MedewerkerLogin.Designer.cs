namespace MedewerkerSysteem
{
    partial class MedewerkerLogin
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
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Location = new System.Drawing.Point(213, 260);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.Size = new System.Drawing.Size(166, 20);
            this.tbWachtwoord.TabIndex = 17;
            this.tbWachtwoord.Text = "keviniscool";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(213, 202);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(166, 20);
            this.tbEmail.TabIndex = 16;
            this.tbEmail.Text = "kevin@email.com";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(213, 306);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Location = new System.Drawing.Point(211, 244);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(68, 13);
            this.lblWachtwoord.TabIndex = 14;
            this.lblWachtwoord.Text = "Wachtwoord";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(211, 186);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(36, 13);
            this.lblemail.TabIndex = 13;
            this.lblemail.Text = "E-Mail";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(206, 123);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(149, 39);
            this.lblLogin.TabIndex = 12;
            this.lblLogin.Text = "Inloggen";
            // 
            // MedewerkerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 453);
            this.Controls.Add(this.tbWachtwoord);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblWachtwoord);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblLogin);
            this.Name = "MedewerkerLogin";
            this.Text = "MedewerkerLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWachtwoord;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblWachtwoord;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblLogin;

    }
}