namespace Sports_Project_1
{
    partial class Login
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
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.butLogin = new System.Windows.Forms.Button();
            this.butCreateAcc = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.cBoxSeePass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(548, 211);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(225, 20);
            this.txtBoxUser.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(409, 206);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(106, 25);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPass.Location = new System.Drawing.Point(409, 270);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(102, 25);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password:";
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(548, 275);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PasswordChar = '*';
            this.txtBoxPass.Size = new System.Drawing.Size(225, 20);
            this.txtBoxPass.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.Location = new System.Drawing.Point(409, 339);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(112, 25);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.Visible = false;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(548, 344);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(225, 20);
            this.txtBoxFirstName.TabIndex = 4;
            this.txtBoxFirstName.Visible = false;
            // 
            // butLogin
            // 
            this.butLogin.Location = new System.Drawing.Point(399, 406);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(122, 47);
            this.butLogin.TabIndex = 6;
            this.butLogin.Text = "&Login";
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // butCreateAcc
            // 
            this.butCreateAcc.Location = new System.Drawing.Point(651, 406);
            this.butCreateAcc.Name = "butCreateAcc";
            this.butCreateAcc.Size = new System.Drawing.Size(122, 47);
            this.butCreateAcc.TabIndex = 7;
            this.butCreateAcc.Text = "&Create Account";
            this.butCreateAcc.UseVisualStyleBackColor = true;
            this.butCreateAcc.Click += new System.EventHandler(this.butCreateAcc_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(524, 457);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(122, 47);
            this.butExit.TabIndex = 8;
            this.butExit.Text = "&Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // cBoxSeePass
            // 
            this.cBoxSeePass.AutoSize = true;
            this.cBoxSeePass.Location = new System.Drawing.Point(779, 275);
            this.cBoxSeePass.Name = "cBoxSeePass";
            this.cBoxSeePass.Size = new System.Drawing.Size(91, 17);
            this.cBoxSeePass.TabIndex = 9;
            this.cBoxSeePass.Text = "see password";
            this.cBoxSeePass.UseVisualStyleBackColor = true;
            this.cBoxSeePass.CheckedChanged += new System.EventHandler(this.cBoxSeePass_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sports_Project_1.Properties.Resources.login_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 644);
            this.Controls.Add(this.cBoxSeePass);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butCreateAcc);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtBoxUser);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Button butCreateAcc;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.CheckBox cBoxSeePass;
    }
}