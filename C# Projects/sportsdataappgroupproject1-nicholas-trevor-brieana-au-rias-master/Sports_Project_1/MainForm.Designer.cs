namespace Sports_Project_1
{
    partial class MainForm
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
            this.butNFL = new System.Windows.Forms.Button();
            this.butNHL = new System.Windows.Forms.Button();
            this.butLogout = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.butFavTeams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butNFL
            // 
            this.butNFL.BackgroundImage = global::Sports_Project_1.Properties.Resources.NFL_logoCrop;
            this.butNFL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butNFL.FlatAppearance.BorderSize = 0;
            this.butNFL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNFL.Location = new System.Drawing.Point(294, 158);
            this.butNFL.Name = "butNFL";
            this.butNFL.Size = new System.Drawing.Size(242, 290);
            this.butNFL.TabIndex = 1;
            this.butNFL.UseVisualStyleBackColor = true;
            this.butNFL.Click += new System.EventHandler(this.butNFL_Click);
            // 
            // butNHL
            // 
            this.butNHL.BackgroundImage = global::Sports_Project_1.Properties.Resources.NHL_logoCrop;
            this.butNHL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butNHL.FlatAppearance.BorderSize = 0;
            this.butNHL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNHL.Location = new System.Drawing.Point(646, 158);
            this.butNHL.Name = "butNHL";
            this.butNHL.Size = new System.Drawing.Size(242, 290);
            this.butNHL.TabIndex = 2;
            this.butNHL.UseVisualStyleBackColor = true;
            this.butNHL.Click += new System.EventHandler(this.butNHL_Click);
            // 
            // butLogout
            // 
            this.butLogout.Location = new System.Drawing.Point(685, 486);
            this.butLogout.Name = "butLogout";
            this.butLogout.Size = new System.Drawing.Size(180, 49);
            this.butLogout.TabIndex = 3;
            this.butLogout.Text = "Logout";
            this.butLogout.UseVisualStyleBackColor = true;
            this.butLogout.Click += new System.EventHandler(this.butLogout_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(471, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 25);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // butFavTeams
            // 
            this.butFavTeams.Location = new System.Drawing.Point(329, 486);
            this.butFavTeams.Name = "butFavTeams";
            this.butFavTeams.Size = new System.Drawing.Size(180, 49);
            this.butFavTeams.TabIndex = 5;
            this.butFavTeams.Text = "Edit / Select Favorite Teams";
            this.butFavTeams.UseVisualStyleBackColor = true;
            this.butFavTeams.Click += new System.EventHandler(this.butFavTeams_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sports_Project_1.Properties.Resources.login_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 644);
            this.Controls.Add(this.butFavTeams);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.butLogout);
            this.Controls.Add(this.butNHL);
            this.Controls.Add(this.butNFL);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butNFL;
        private System.Windows.Forms.Button butNHL;
        private System.Windows.Forms.Button butLogout;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button butFavTeams;
    }
}