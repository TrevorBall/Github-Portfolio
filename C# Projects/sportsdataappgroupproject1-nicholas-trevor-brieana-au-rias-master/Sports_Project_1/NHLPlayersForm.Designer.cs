namespace Sports_Project_1
{
    partial class NHLPlayersForm
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
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label jersey_NumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NHLPlayersForm));
            this.PictureBoxTeamLogo = new System.Windows.Forms.PictureBox();
            this.cmbPlayers = new System.Windows.Forms.ComboBox();
            this.tbGP = new System.Windows.Forms.TextBox();
            this.tbG = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbPTS = new System.Windows.Forms.TextBox();
            this.tbPlusMinus = new System.Windows.Forms.TextBox();
            this.tbPIM = new System.Windows.Forms.TextBox();
            this.lblGP = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblPTS = new System.Windows.Forms.Label();
            this.lblPlusMinus = new System.Windows.Forms.Label();
            this.lblPIM = new System.Windows.Forms.Label();
            this.sportsDBDataSet = new Sports_Project_1.sportsDBDataSet();
            this._NHL_Players__BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._NHL_Players__TableAdapter = new Sports_Project_1.sportsDBDataSetTableAdapters._NHL_Players__TableAdapter();
            this.tableAdapterManager = new Sports_Project_1.sportsDBDataSetTableAdapters.TableAdapterManager();
            this._NHL_Players__BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._NHL_Players__BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbJerseyNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayerInformationTag = new System.Windows.Forms.Label();
            this.lblPlayerStatsTag = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            jersey_NumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTeamLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._NHL_Players__BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._NHL_Players__BindingNavigator)).BeginInit();
            this._NHL_Players__BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            first_NameLabel.Enabled = false;
            first_NameLabel.Location = new System.Drawing.Point(3, 267);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(62, 15);
            first_NameLabel.TabIndex = 15;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            last_NameLabel.Enabled = false;
            last_NameLabel.Location = new System.Drawing.Point(206, 267);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(63, 15);
            last_NameLabel.TabIndex = 17;
            last_NameLabel.Text = "Last Name:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            positionLabel.Enabled = false;
            positionLabel.Location = new System.Drawing.Point(635, 267);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(49, 15);
            positionLabel.TabIndex = 19;
            positionLabel.Text = "Position:";
            // 
            // jersey_NumberLabel
            // 
            jersey_NumberLabel.AutoSize = true;
            jersey_NumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            jersey_NumberLabel.Enabled = false;
            jersey_NumberLabel.Location = new System.Drawing.Point(412, 267);
            jersey_NumberLabel.Name = "jersey_NumberLabel";
            jersey_NumberLabel.Size = new System.Drawing.Size(82, 15);
            jersey_NumberLabel.TabIndex = 21;
            jersey_NumberLabel.Text = "Jersey Number:";
            // 
            // PictureBoxTeamLogo
            // 
            this.PictureBoxTeamLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxTeamLogo.Location = new System.Drawing.Point(12, 25);
            this.PictureBoxTeamLogo.Name = "PictureBoxTeamLogo";
            this.PictureBoxTeamLogo.Size = new System.Drawing.Size(320, 178);
            this.PictureBoxTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxTeamLogo.TabIndex = 0;
            this.PictureBoxTeamLogo.TabStop = false;
            // 
            // cmbPlayers
            // 
            this.cmbPlayers.FormattingEnabled = true;
            this.cmbPlayers.Location = new System.Drawing.Point(338, 83);
            this.cmbPlayers.Name = "cmbPlayers";
            this.cmbPlayers.Size = new System.Drawing.Size(468, 21);
            this.cmbPlayers.TabIndex = 1;
            this.cmbPlayers.SelectedIndexChanged += new System.EventHandler(this.cmbPlayers_SelectedIndexChanged);
            // 
            // tbGP
            // 
            this.tbGP.Enabled = false;
            this.tbGP.Location = new System.Drawing.Point(46, 355);
            this.tbGP.Name = "tbGP";
            this.tbGP.Size = new System.Drawing.Size(141, 20);
            this.tbGP.TabIndex = 2;
            // 
            // tbG
            // 
            this.tbG.Enabled = false;
            this.tbG.Location = new System.Drawing.Point(338, 355);
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(141, 20);
            this.tbG.TabIndex = 3;
            // 
            // tbA
            // 
            this.tbA.Enabled = false;
            this.tbA.Location = new System.Drawing.Point(624, 355);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(141, 20);
            this.tbA.TabIndex = 4;
            // 
            // tbPTS
            // 
            this.tbPTS.Enabled = false;
            this.tbPTS.Location = new System.Drawing.Point(46, 418);
            this.tbPTS.Name = "tbPTS";
            this.tbPTS.Size = new System.Drawing.Size(141, 20);
            this.tbPTS.TabIndex = 5;
            // 
            // tbPlusMinus
            // 
            this.tbPlusMinus.Enabled = false;
            this.tbPlusMinus.Location = new System.Drawing.Point(338, 418);
            this.tbPlusMinus.Name = "tbPlusMinus";
            this.tbPlusMinus.Size = new System.Drawing.Size(141, 20);
            this.tbPlusMinus.TabIndex = 6;
            // 
            // tbPIM
            // 
            this.tbPIM.Enabled = false;
            this.tbPIM.Location = new System.Drawing.Point(624, 418);
            this.tbPIM.Name = "tbPIM";
            this.tbPIM.Size = new System.Drawing.Size(141, 20);
            this.tbPIM.TabIndex = 8;
            // 
            // lblGP
            // 
            this.lblGP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGP.Enabled = false;
            this.lblGP.Location = new System.Drawing.Point(43, 329);
            this.lblGP.Name = "lblGP";
            this.lblGP.Size = new System.Drawing.Size(144, 23);
            this.lblGP.TabIndex = 9;
            this.lblGP.Text = "Games Played (GP)";
            this.lblGP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblG
            // 
            this.lblG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblG.Enabled = false;
            this.lblG.Location = new System.Drawing.Point(335, 329);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(144, 23);
            this.lblG.TabIndex = 10;
            this.lblG.Text = "Goals (G)";
            this.lblG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblA
            // 
            this.lblA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblA.Enabled = false;
            this.lblA.Location = new System.Drawing.Point(621, 329);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(144, 23);
            this.lblA.TabIndex = 11;
            this.lblA.Text = "Assist (A)";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPTS
            // 
            this.lblPTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPTS.Enabled = false;
            this.lblPTS.Location = new System.Drawing.Point(43, 392);
            this.lblPTS.Name = "lblPTS";
            this.lblPTS.Size = new System.Drawing.Size(144, 23);
            this.lblPTS.TabIndex = 12;
            this.lblPTS.Text = "Points (PTS)";
            this.lblPTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlusMinus
            // 
            this.lblPlusMinus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlusMinus.Enabled = false;
            this.lblPlusMinus.Location = new System.Drawing.Point(335, 392);
            this.lblPlusMinus.Name = "lblPlusMinus";
            this.lblPlusMinus.Size = new System.Drawing.Size(144, 23);
            this.lblPlusMinus.TabIndex = 13;
            this.lblPlusMinus.Text = "PlusMinus (+/-)";
            this.lblPlusMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPIM
            // 
            this.lblPIM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPIM.Enabled = false;
            this.lblPIM.Location = new System.Drawing.Point(621, 392);
            this.lblPIM.Name = "lblPIM";
            this.lblPIM.Size = new System.Drawing.Size(144, 23);
            this.lblPIM.TabIndex = 14;
            this.lblPIM.Text = "Penalty Minutes (PIM)";
            this.lblPIM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sportsDBDataSet
            // 
            this.sportsDBDataSet.DataSetName = "sportsDBDataSet";
            this.sportsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _NHL_Players__BindingSource
            // 
            this._NHL_Players__BindingSource.DataMember = "\'NHL Players$\'";
            this._NHL_Players__BindingSource.DataSource = this.sportsDBDataSet;
            // 
            // _NHL_Players__TableAdapter
            // 
            this._NHL_Players__TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._NFL_Player_Stats__TableAdapter = null;
            this.tableAdapterManager._NFL_Players__TableAdapter = null;
            this.tableAdapterManager._NFL_Team__TableAdapter = null;
            this.tableAdapterManager._NHL_Player_Stats__ExternalData_1TableAdapter = null;
            this.tableAdapterManager._NHL_Player_Stats__TableAdapter = null;
            this.tableAdapterManager._NHL_Players___xlnm__FilterDatabaseTableAdapter = null;
            this.tableAdapterManager._NHL_Players__TableAdapter = this._NHL_Players__TableAdapter;
            this.tableAdapterManager._NHL_Team__TableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Sports_Project_1.sportsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_TableAdapter = null;
            // 
            // _NHL_Players__BindingNavigator
            // 
            this._NHL_Players__BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this._NHL_Players__BindingNavigator.BindingSource = this._NHL_Players__BindingSource;
            this._NHL_Players__BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this._NHL_Players__BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this._NHL_Players__BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this._NHL_Players__BindingNavigatorSaveItem});
            this._NHL_Players__BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this._NHL_Players__BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this._NHL_Players__BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this._NHL_Players__BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this._NHL_Players__BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this._NHL_Players__BindingNavigator.Name = "_NHL_Players__BindingNavigator";
            this._NHL_Players__BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this._NHL_Players__BindingNavigator.Size = new System.Drawing.Size(818, 25);
            this._NHL_Players__BindingNavigator.TabIndex = 15;
            this._NHL_Players__BindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // _NHL_Players__BindingNavigatorSaveItem
            // 
            this._NHL_Players__BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._NHL_Players__BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("_NHL_Players__BindingNavigatorSaveItem.Image")));
            this._NHL_Players__BindingNavigatorSaveItem.Name = "_NHL_Players__BindingNavigatorSaveItem";
            this._NHL_Players__BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this._NHL_Players__BindingNavigatorSaveItem.Text = "Save Data";
            this._NHL_Players__BindingNavigatorSaveItem.Click += new System.EventHandler(this._NHL_Players__BindingNavigatorSaveItem_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._NHL_Players__BindingSource, "First Name", true));
            this.tbFirstName.Enabled = false;
            this.tbFirstName.Location = new System.Drawing.Point(69, 264);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 16;
            // 
            // tbLastName
            // 
            this.tbLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._NHL_Players__BindingSource, "Last Name", true));
            this.tbLastName.Enabled = false;
            this.tbLastName.Location = new System.Drawing.Point(273, 264);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 18;
            // 
            // tbPosition
            // 
            this.tbPosition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._NHL_Players__BindingSource, "Position", true));
            this.tbPosition.Enabled = false;
            this.tbPosition.Location = new System.Drawing.Point(688, 264);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(100, 20);
            this.tbPosition.TabIndex = 20;
            // 
            // tbJerseyNumber
            // 
            this.tbJerseyNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._NHL_Players__BindingSource, "Jersey Number", true));
            this.tbJerseyNumber.Enabled = false;
            this.tbJerseyNumber.Location = new System.Drawing.Point(498, 264);
            this.tbJerseyNumber.Name = "tbJerseyNumber";
            this.tbJerseyNumber.Size = new System.Drawing.Size(100, 20);
            this.tbJerseyNumber.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1099, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-83, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1099, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // lblPlayerInformationTag
            // 
            this.lblPlayerInformationTag.AutoSize = true;
            this.lblPlayerInformationTag.Enabled = false;
            this.lblPlayerInformationTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerInformationTag.Location = new System.Drawing.Point(311, 216);
            this.lblPlayerInformationTag.Name = "lblPlayerInformationTag";
            this.lblPlayerInformationTag.Size = new System.Drawing.Size(206, 20);
            this.lblPlayerInformationTag.TabIndex = 25;
            this.lblPlayerInformationTag.Text = "PLAYER INFORMATION";
            // 
            // lblPlayerStatsTag
            // 
            this.lblPlayerStatsTag.AutoSize = true;
            this.lblPlayerStatsTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerStatsTag.Location = new System.Drawing.Point(343, 300);
            this.lblPlayerStatsTag.Name = "lblPlayerStatsTag";
            this.lblPlayerStatsTag.Size = new System.Drawing.Size(140, 20);
            this.lblPlayerStatsTag.TabIndex = 26;
            this.lblPlayerStatsTag.Text = "PLAYER STATS";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.Location = new System.Drawing.Point(338, 177);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 23);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit Player Stats";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbTeamName
            // 
            this.tbTeamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTeamName.Enabled = false;
            this.tbTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTeamName.ForeColor = System.Drawing.Color.Black;
            this.tbTeamName.Location = new System.Drawing.Point(538, 179);
            this.tbTeamName.Name = "tbTeamName";
            this.tbTeamName.Size = new System.Drawing.Size(209, 26);
            this.tbTeamName.TabIndex = 28;
            this.tbTeamName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(575, 156);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(112, 20);
            this.lblTeamName.TabIndex = 29;
            this.lblTeamName.Text = "TEAM NAME";
            // 
            // NHLPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(818, 458);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.tbTeamName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPlayerStatsTag);
            this.Controls.Add(this.lblPlayerInformationTag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(jersey_NumberLabel);
            this.Controls.Add(this.tbJerseyNumber);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this._NHL_Players__BindingNavigator);
            this.Controls.Add(this.lblPIM);
            this.Controls.Add(this.lblPlusMinus);
            this.Controls.Add(this.lblPTS);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblGP);
            this.Controls.Add(this.tbPIM);
            this.Controls.Add(this.tbPlusMinus);
            this.Controls.Add(this.tbPTS);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.tbG);
            this.Controls.Add(this.tbGP);
            this.Controls.Add(this.cmbPlayers);
            this.Controls.Add(this.PictureBoxTeamLogo);
            this.DoubleBuffered = true;
            this.Name = "NHLPlayersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHLPlayersForm";
            this.Load += new System.EventHandler(this.NHLPlayersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTeamLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._NHL_Players__BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._NHL_Players__BindingNavigator)).EndInit();
            this._NHL_Players__BindingNavigator.ResumeLayout(false);
            this._NHL_Players__BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxTeamLogo;
        private System.Windows.Forms.ComboBox cmbPlayers;
        private System.Windows.Forms.TextBox tbGP;
        private System.Windows.Forms.TextBox tbG;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbPTS;
        private System.Windows.Forms.TextBox tbPlusMinus;
        private System.Windows.Forms.TextBox tbPIM;
        private System.Windows.Forms.Label lblGP;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblPTS;
        private System.Windows.Forms.Label lblPlusMinus;
        private System.Windows.Forms.Label lblPIM;
        private sportsDBDataSet sportsDBDataSet;
        private System.Windows.Forms.BindingSource _NHL_Players__BindingSource;
        private sportsDBDataSetTableAdapters._NHL_Players__TableAdapter _NHL_Players__TableAdapter;
        private sportsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator _NHL_Players__BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton _NHL_Players__BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbJerseyNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayerInformationTag;
        private System.Windows.Forms.Label lblPlayerStatsTag;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbTeamName;
        private System.Windows.Forms.Label lblTeamName;
    }
}