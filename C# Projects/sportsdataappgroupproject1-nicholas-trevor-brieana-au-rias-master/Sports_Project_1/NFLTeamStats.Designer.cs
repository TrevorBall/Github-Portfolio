namespace Sports_Project_1
{
    partial class NFLTeamStats
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NFLTeamStats));
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.butExit = new System.Windows.Forms.Button();
            this.lblConference = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.lblTies = new System.Windows.Forms.Label();
            this._NFL_Players__BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this._NFL_Players__BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this._NFL_Players__DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._NFL_Players__BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportsDBDataSet = new Sports_Project_1.sportsDBDataSet();
            this._NFL_Players__TableAdapter = new Sports_Project_1.sportsDBDataSetTableAdapters._NFL_Players__TableAdapter();
            this.tableAdapterManager = new Sports_Project_1.sportsDBDataSetTableAdapters.TableAdapterManager();
            this.lblPlayers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._NFL_Players__BindingNavigator)).BeginInit();
            this._NFL_Players__BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._NFL_Players__DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._NFL_Players__BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pBoxLogo.Location = new System.Drawing.Point(30, 40);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(273, 235);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLogo.TabIndex = 0;
            this.pBoxLogo.TabStop = false;
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(62, 584);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(156, 48);
            this.butExit.TabIndex = 1;
            this.butExit.Text = "&Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // lblConference
            // 
            this.lblConference.AutoSize = true;
            this.lblConference.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblConference.Location = new System.Drawing.Point(75, 313);
            this.lblConference.Name = "lblConference";
            this.lblConference.Size = new System.Drawing.Size(129, 25);
            this.lblConference.TabIndex = 2;
            this.lblConference.Text = "Conference : ";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblWins.Location = new System.Drawing.Point(75, 363);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(71, 25);
            this.lblWins.TabIndex = 3;
            this.lblWins.Text = "Wins : ";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblLosses.Location = new System.Drawing.Point(75, 413);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(83, 25);
            this.lblLosses.TabIndex = 4;
            this.lblLosses.Text = "Losses : ";
            // 
            // lblTies
            // 
            this.lblTies.AutoSize = true;
            this.lblTies.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTies.Location = new System.Drawing.Point(75, 463);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(61, 25);
            this.lblTies.TabIndex = 5;
            this.lblTies.Text = "Ties : ";
            // 
            // _NFL_Players__BindingNavigator
            // 
            this._NFL_Players__BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this._NFL_Players__BindingNavigator.BindingSource = this._NFL_Players__BindingSource;
            this._NFL_Players__BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this._NFL_Players__BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this._NFL_Players__BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this._NFL_Players__BindingNavigatorSaveItem});
            this._NFL_Players__BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this._NFL_Players__BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this._NFL_Players__BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this._NFL_Players__BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this._NFL_Players__BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this._NFL_Players__BindingNavigator.Name = "_NFL_Players__BindingNavigator";
            this._NFL_Players__BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this._NFL_Players__BindingNavigator.Size = new System.Drawing.Size(1152, 25);
            this._NFL_Players__BindingNavigator.TabIndex = 6;
            this._NFL_Players__BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // _NFL_Players__BindingNavigatorSaveItem
            // 
            this._NFL_Players__BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._NFL_Players__BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("_NFL_Players__BindingNavigatorSaveItem.Image")));
            this._NFL_Players__BindingNavigatorSaveItem.Name = "_NFL_Players__BindingNavigatorSaveItem";
            this._NFL_Players__BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this._NFL_Players__BindingNavigatorSaveItem.Text = "Save Data";
            this._NFL_Players__BindingNavigatorSaveItem.Click += new System.EventHandler(this._NFL_Players__BindingNavigatorSaveItem_Click);
            // 
            // _NFL_Players__DataGridView
            // 
            this._NFL_Players__DataGridView.AutoGenerateColumns = false;
            this._NFL_Players__DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._NFL_Players__DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this._NFL_Players__DataGridView.DataSource = this._NFL_Players__BindingSource;
            this._NFL_Players__DataGridView.Location = new System.Drawing.Point(429, 105);
            this._NFL_Players__DataGridView.Name = "_NFL_Players__DataGridView";
            this._NFL_Players__DataGridView.Size = new System.Drawing.Size(642, 456);
            this._NFL_Players__DataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PlayerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PlayerID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TeamID";
            this.dataGridViewTextBoxColumn4.HeaderText = "TeamID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn5.HeaderText = "Position";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Jersey Number";
            this.dataGridViewTextBoxColumn6.HeaderText = "Jersey Number";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // _NFL_Players__BindingSource
            // 
            this._NFL_Players__BindingSource.DataMember = "\'NFL Players$\'";
            this._NFL_Players__BindingSource.DataSource = this.sportsDBDataSet;
            // 
            // sportsDBDataSet
            // 
            this.sportsDBDataSet.DataSetName = "sportsDBDataSet";
            this.sportsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _NFL_Players__TableAdapter
            // 
            this._NFL_Players__TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._NFL_Player_Stats__TableAdapter = null;
            this.tableAdapterManager._NFL_Players__TableAdapter = this._NFL_Players__TableAdapter;
            this.tableAdapterManager._NFL_Team__TableAdapter = null;
            this.tableAdapterManager._NHL_Player_Stats__ExternalData_1TableAdapter = null;
            this.tableAdapterManager._NHL_Player_Stats__TableAdapter = null;
            this.tableAdapterManager._NHL_Players___xlnm__FilterDatabaseTableAdapter = null;
            this.tableAdapterManager._NHL_Players__TableAdapter = null;
            this.tableAdapterManager._NHL_Team__TableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Sports_Project_1.sportsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_TableAdapter = null;
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayers.Location = new System.Drawing.Point(729, 72);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(82, 30);
            this.lblPlayers.TabIndex = 8;
            this.lblPlayers.Text = "Players";
            // 
            // NFLStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sports_Project_1.Properties.Resources.NFL_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 652);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this._NFL_Players__DataGridView);
            this.Controls.Add(this._NFL_Players__BindingNavigator);
            this.Controls.Add(this.lblTies);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.lblConference);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.pBoxLogo);
            this.Name = "NFLStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NFLStats";
            this.Load += new System.EventHandler(this.NFLStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._NFL_Players__BindingNavigator)).EndInit();
            this._NFL_Players__BindingNavigator.ResumeLayout(false);
            this._NFL_Players__BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._NFL_Players__DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._NFL_Players__BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxLogo;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Label lblConference;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label lblTies;
        private sportsDBDataSet sportsDBDataSet;
        private System.Windows.Forms.BindingSource _NFL_Players__BindingSource;
        private sportsDBDataSetTableAdapters._NFL_Players__TableAdapter _NFL_Players__TableAdapter;
        private sportsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator _NFL_Players__BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton _NFL_Players__BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView _NFL_Players__DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lblPlayers;
    }
}