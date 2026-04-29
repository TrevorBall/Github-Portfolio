namespace Sports_Project_1
{
    partial class UserFavoriteTeam
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
            this.lblNfl = new System.Windows.Forms.Label();
            this.lblNhl = new System.Windows.Forms.Label();
            this.cmbNFLTeams = new System.Windows.Forms.ComboBox();
            this.cmbNHLTeams = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNfl
            // 
            this.lblNfl.AutoSize = true;
            this.lblNfl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNfl.Enabled = false;
            this.lblNfl.Location = new System.Drawing.Point(77, 267);
            this.lblNfl.Name = "lblNfl";
            this.lblNfl.Size = new System.Drawing.Size(438, 26);
            this.lblNfl.TabIndex = 1;
            this.lblNfl.Text = "Select your favorite NFL team(s) from the list below!";
            // 
            // lblNhl
            // 
            this.lblNhl.AutoSize = true;
            this.lblNhl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNhl.Enabled = false;
            this.lblNhl.Location = new System.Drawing.Point(626, 97);
            this.lblNhl.Name = "lblNhl";
            this.lblNhl.Size = new System.Drawing.Size(440, 26);
            this.lblNhl.TabIndex = 2;
            this.lblNhl.Text = "Select your favorite NHL team(s) from the list below!";
            // 
            // cmbNFLTeams
            // 
            this.cmbNFLTeams.FormattingEnabled = true;
            this.cmbNFLTeams.Location = new System.Drawing.Point(77, 294);
            this.cmbNFLTeams.Name = "cmbNFLTeams";
            this.cmbNFLTeams.Size = new System.Drawing.Size(436, 32);
            this.cmbNFLTeams.TabIndex = 3;
            // 
            // cmbNHLTeams
            // 
            this.cmbNHLTeams.FormattingEnabled = true;
            this.cmbNHLTeams.Location = new System.Drawing.Point(626, 124);
            this.cmbNHLTeams.Name = "cmbNHLTeams";
            this.cmbNHLTeams.Size = new System.Drawing.Size(438, 32);
            this.cmbNHLTeams.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(122, 507);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 37);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(438, 507);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 37);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UserFavoriteTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sports_Project_1.Properties.Resources.login_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1153, 667);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbNHLTeams);
            this.Controls.Add(this.cmbNFLTeams);
            this.Controls.Add(this.lblNhl);
            this.Controls.Add(this.lblNfl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserFavoriteTeam";
            this.Text = "UserFavoriteTeam";
            this.Load += new System.EventHandler(this.UserFavoriteTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNfl;
        private System.Windows.Forms.Label lblNhl;
        private System.Windows.Forms.ComboBox cmbNFLTeams;
        private System.Windows.Forms.ComboBox cmbNHLTeams;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}