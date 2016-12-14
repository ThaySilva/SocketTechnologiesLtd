namespace SocketTechnologiesLtd
{
    partial class RfQ_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RfQ_Form));
            this.btn_Exit = new MetroFramework.Controls.MetroButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_selectCust = new MetroFramework.Controls.MetroTile();
            this.btn_searchCust = new MetroFramework.Controls.MetroTile();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txt_custAdd = new MetroFramework.Controls.MetroTextBox();
            this.txt_custName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txt_custId = new MetroFramework.Controls.MetroTextBox();
            this.gridView_cust = new System.Windows.Forms.DataGridView();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.btn_addSItem = new MetroFramework.Controls.MetroTile();
            this.btn_searchPart = new MetroFramework.Controls.MetroTile();
            this.txt_quantity = new MetroFramework.Controls.MetroTextBox();
            this.txt_partId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.gridView_parts = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_SDate = new MetroFramework.Controls.MetroTextBox();
            this.txt_CDate = new MetroFramework.Controls.MetroTextBox();
            this.dtPicker_qDate = new System.Windows.Forms.DateTimePicker();
            this.txt_customPartName = new MetroFramework.Controls.MetroTextBox();
            this.lbl_PartName = new MetroFramework.Controls.MetroLabel();
            this.btn_Cancel = new MetroFramework.Controls.MetroTile();
            this.btn_Create = new MetroFramework.Controls.MetroTile();
            this.btn_AddCustom = new MetroFramework.Controls.MetroTile();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txt_CustomQty = new MetroFramework.Controls.MetroTextBox();
            this.txt_CustomSpecs = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_cust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_parts)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.Location = new System.Drawing.Point(1280, 20);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(92, 34);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_selectCust);
            this.splitContainer1.Panel1.Controls.Add(this.btn_searchCust);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel14);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel13);
            this.splitContainer1.Panel1.Controls.Add(this.txt_custAdd);
            this.splitContainer1.Panel1.Controls.Add(this.txt_custName);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel12);
            this.splitContainer1.Panel1.Controls.Add(this.txt_custId);
            this.splitContainer1.Panel1.Controls.Add(this.gridView_cust);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel11);
            this.splitContainer1.Panel1.Controls.Add(this.btn_addSItem);
            this.splitContainer1.Panel1.Controls.Add(this.btn_searchPart);
            this.splitContainer1.Panel1.Controls.Add(this.txt_quantity);
            this.splitContainer1.Panel1.Controls.Add(this.txt_partId);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel3);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.gridView_parts);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txt_SDate);
            this.splitContainer1.Panel2.Controls.Add(this.txt_CDate);
            this.splitContainer1.Panel2.Controls.Add(this.dtPicker_qDate);
            this.splitContainer1.Panel2.Controls.Add(this.txt_customPartName);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_PartName);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Cancel);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Create);
            this.splitContainer1.Panel2.Controls.Add(this.btn_AddCustom);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel10);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel9);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel8);
            this.splitContainer1.Panel2.Controls.Add(this.txt_CustomQty);
            this.splitContainer1.Panel2.Controls.Add(this.txt_CustomSpecs);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel7);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel6);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel4);
            this.splitContainer1.Size = new System.Drawing.Size(1352, 727);
            this.splitContainer1.SplitterDistance = 718;
            this.splitContainer1.TabIndex = 6;
            // 
            // btn_selectCust
            // 
            this.btn_selectCust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_selectCust.Location = new System.Drawing.Point(463, 327);
            this.btn_selectCust.Name = "btn_selectCust";
            this.btn_selectCust.Size = new System.Drawing.Size(146, 41);
            this.btn_selectCust.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_selectCust.TabIndex = 23;
            this.btn_selectCust.Text = "Select Customer";
            this.btn_selectCust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_selectCust.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_selectCust.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_selectCust.Click += new System.EventHandler(this.btn_selectCust_Click);
            // 
            // btn_searchCust
            // 
            this.btn_searchCust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_searchCust.Location = new System.Drawing.Point(463, 90);
            this.btn_searchCust.Name = "btn_searchCust";
            this.btn_searchCust.Size = new System.Drawing.Size(146, 41);
            this.btn_searchCust.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_searchCust.TabIndex = 22;
            this.btn_searchCust.Text = "Search Customer";
            this.btn_searchCust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_searchCust.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_searchCust.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_searchCust.Click += new System.EventHandler(this.btn_searchCust_Click);
            // 
            // metroLabel14
            // 
            this.metroLabel14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.Location = new System.Drawing.Point(38, 29);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(93, 25);
            this.metroLabel14.TabIndex = 21;
            this.metroLabel14.Text = "Customer";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel13
            // 
            this.metroLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(364, 226);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(171, 25);
            this.metroLabel13.TabIndex = 20;
            this.metroLabel13.Text = "Customer Address:";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_custAdd
            // 
            this.txt_custAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_custAdd.Enabled = false;
            this.txt_custAdd.Location = new System.Drawing.Point(365, 254);
            this.txt_custAdd.Multiline = true;
            this.txt_custAdd.Name = "txt_custAdd";
            this.txt_custAdd.ReadOnly = true;
            this.txt_custAdd.Size = new System.Drawing.Size(246, 61);
            this.txt_custAdd.TabIndex = 19;
            this.txt_custAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_custName
            // 
            this.txt_custName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_custName.Enabled = false;
            this.txt_custName.Location = new System.Drawing.Point(365, 184);
            this.txt_custName.Name = "txt_custName";
            this.txt_custName.ReadOnly = true;
            this.txt_custName.Size = new System.Drawing.Size(246, 27);
            this.txt_custName.TabIndex = 18;
            this.txt_custName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel12
            // 
            this.metroLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(363, 156);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(153, 25);
            this.metroLabel12.TabIndex = 17;
            this.metroLabel12.Text = "Customer Name:";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_custId
            // 
            this.txt_custId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_custId.Location = new System.Drawing.Point(363, 57);
            this.txt_custId.Name = "txt_custId";
            this.txt_custId.Size = new System.Drawing.Size(246, 27);
            this.txt_custId.TabIndex = 16;
            this.txt_custId.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_custId.Click += new System.EventHandler(this.txt_custId_Click);
            // 
            // gridView_cust
            // 
            this.gridView_cust.AllowUserToAddRows = false;
            this.gridView_cust.AllowUserToDeleteRows = false;
            this.gridView_cust.AllowUserToResizeColumns = false;
            this.gridView_cust.AllowUserToResizeRows = false;
            this.gridView_cust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridView_cust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridView_cust.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridView_cust.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridView_cust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_cust.Location = new System.Drawing.Point(38, 57);
            this.gridView_cust.MultiSelect = false;
            this.gridView_cust.Name = "gridView_cust";
            this.gridView_cust.ReadOnly = true;
            this.gridView_cust.Size = new System.Drawing.Size(307, 232);
            this.gridView_cust.TabIndex = 13;
            this.gridView_cust.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_cust_CellClick);
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(364, 29);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(122, 25);
            this.metroLabel11.TabIndex = 12;
            this.metroLabel11.Text = "Customer ID:";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_addSItem
            // 
            this.btn_addSItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addSItem.Location = new System.Drawing.Point(464, 625);
            this.btn_addSItem.Name = "btn_addSItem";
            this.btn_addSItem.Size = new System.Drawing.Size(147, 41);
            this.btn_addSItem.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_addSItem.TabIndex = 11;
            this.btn_addSItem.Text = "Add Standard Item";
            this.btn_addSItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_addSItem.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_addSItem.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_addSItem.Click += new System.EventHandler(this.btn_addSItem_Click);
            // 
            // btn_searchPart
            // 
            this.btn_searchPart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_searchPart.Location = new System.Drawing.Point(465, 493);
            this.btn_searchPart.Name = "btn_searchPart";
            this.btn_searchPart.Size = new System.Drawing.Size(146, 41);
            this.btn_searchPart.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_searchPart.TabIndex = 10;
            this.btn_searchPart.Text = "Search Part";
            this.btn_searchPart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_searchPart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_searchPart.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_searchPart.Click += new System.EventHandler(this.btn_searchPart_Click);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_quantity.Location = new System.Drawing.Point(366, 590);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(245, 27);
            this.txt_quantity.TabIndex = 9;
            this.txt_quantity.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_partId
            // 
            this.txt_partId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_partId.Location = new System.Drawing.Point(364, 460);
            this.txt_partId.Name = "txt_partId";
            this.txt_partId.Size = new System.Drawing.Size(246, 27);
            this.txt_partId.TabIndex = 8;
            this.txt_partId.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_partId.Click += new System.EventHandler(this.txt_partId_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(364, 557);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(92, 25);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Quantity:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(364, 432);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Part ID:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // gridView_parts
            // 
            this.gridView_parts.AllowUserToAddRows = false;
            this.gridView_parts.AllowUserToDeleteRows = false;
            this.gridView_parts.AllowUserToResizeColumns = false;
            this.gridView_parts.AllowUserToResizeRows = false;
            this.gridView_parts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridView_parts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridView_parts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridView_parts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridView_parts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView_parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_parts.Location = new System.Drawing.Point(38, 460);
            this.gridView_parts.MultiSelect = false;
            this.gridView_parts.Name = "gridView_parts";
            this.gridView_parts.ReadOnly = true;
            this.gridView_parts.Size = new System.Drawing.Size(307, 234);
            this.gridView_parts.TabIndex = 1;
            this.gridView_parts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_parts_CellClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(38, 432);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(141, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Standard Items";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_SDate
            // 
            this.txt_SDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SDate.Location = new System.Drawing.Point(348, 592);
            this.txt_SDate.Name = "txt_SDate";
            this.txt_SDate.Size = new System.Drawing.Size(200, 27);
            this.txt_SDate.TabIndex = 26;
            this.txt_SDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_CDate
            // 
            this.txt_CDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CDate.Location = new System.Drawing.Point(348, 525);
            this.txt_CDate.Name = "txt_CDate";
            this.txt_CDate.Size = new System.Drawing.Size(200, 27);
            this.txt_CDate.TabIndex = 25;
            this.txt_CDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dtPicker_qDate
            // 
            this.dtPicker_qDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtPicker_qDate.Location = new System.Drawing.Point(348, 462);
            this.dtPicker_qDate.Name = "dtPicker_qDate";
            this.dtPicker_qDate.Size = new System.Drawing.Size(200, 20);
            this.dtPicker_qDate.TabIndex = 24;
            // 
            // txt_customPartName
            // 
            this.txt_customPartName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_customPartName.Location = new System.Drawing.Point(303, 77);
            this.txt_customPartName.Name = "txt_customPartName";
            this.txt_customPartName.Size = new System.Drawing.Size(245, 27);
            this.txt_customPartName.TabIndex = 23;
            this.txt_customPartName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_PartName
            // 
            this.lbl_PartName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_PartName.AutoSize = true;
            this.lbl_PartName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_PartName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_PartName.Location = new System.Drawing.Point(78, 77);
            this.lbl_PartName.Name = "lbl_PartName";
            this.lbl_PartName.Size = new System.Drawing.Size(108, 25);
            this.lbl_PartName.TabIndex = 22;
            this.lbl_PartName.Text = "Part Name:";
            this.lbl_PartName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(474, 650);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(122, 46);
            this.btn_Cancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Cancel.TabIndex = 21;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Cancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Create.Location = new System.Drawing.Point(329, 650);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(122, 46);
            this.btn_Create.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Create.TabIndex = 12;
            this.btn_Create.Text = "Create Request";
            this.btn_Create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Create.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Create.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_AddCustom
            // 
            this.btn_AddCustom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddCustom.Location = new System.Drawing.Point(415, 361);
            this.btn_AddCustom.Name = "btn_AddCustom";
            this.btn_AddCustom.Size = new System.Drawing.Size(133, 41);
            this.btn_AddCustom.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_AddCustom.TabIndex = 20;
            this.btn_AddCustom.Text = "Add Custom Item";
            this.btn_AddCustom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AddCustom.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_AddCustom.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_AddCustom.Click += new System.EventHandler(this.btn_AddCustom_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(78, 592);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(259, 25);
            this.metroLabel10.TabIndex = 18;
            this.metroLabel10.Text = "Standard Item Delivery Date:";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(78, 525);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(246, 25);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Custom Item Delivery Date:";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(78, 462);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(231, 25);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Quotation Required Date:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_CustomQty
            // 
            this.txt_CustomQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CustomQty.Location = new System.Drawing.Point(303, 143);
            this.txt_CustomQty.Name = "txt_CustomQty";
            this.txt_CustomQty.Size = new System.Drawing.Size(245, 27);
            this.txt_CustomQty.TabIndex = 13;
            this.txt_CustomQty.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_CustomSpecs
            // 
            this.txt_CustomSpecs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CustomSpecs.Location = new System.Drawing.Point(78, 254);
            this.txt_CustomSpecs.Multiline = true;
            this.txt_CustomSpecs.Name = "txt_CustomSpecs";
            this.txt_CustomSpecs.Size = new System.Drawing.Size(470, 61);
            this.txt_CustomSpecs.TabIndex = 8;
            this.txt_CustomSpecs.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(78, 212);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(135, 25);
            this.metroLabel7.TabIndex = 7;
            this.metroLabel7.Text = "Specifications:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(78, 143);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(92, 25);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Quantity:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(78, 29);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(128, 25);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Custom Items";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RfQ_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 807);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btn_Exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "RfQ_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Request For Quotation";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_cust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_parts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_Exit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView gridView_parts;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_CustomSpecs;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_quantity;
        private MetroFramework.Controls.MetroTextBox txt_partId;
        private MetroFramework.Controls.MetroTextBox txt_CustomQty;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTile btn_addSItem;
        private MetroFramework.Controls.MetroTile btn_searchPart;
        private MetroFramework.Controls.MetroTile btn_Cancel;
        private MetroFramework.Controls.MetroTile btn_Create;
        private MetroFramework.Controls.MetroTile btn_AddCustom;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txt_custName;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txt_custId;
        private System.Windows.Forms.DataGridView gridView_cust;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTile btn_searchCust;
        private MetroFramework.Controls.MetroTile btn_selectCust;
        private MetroFramework.Controls.MetroTextBox txt_custAdd;
        private MetroFramework.Controls.MetroTextBox txt_customPartName;
        private MetroFramework.Controls.MetroLabel lbl_PartName;
        private System.Windows.Forms.DateTimePicker dtPicker_qDate;
        private MetroFramework.Controls.MetroTextBox txt_SDate;
        private MetroFramework.Controls.MetroTextBox txt_CDate;
    }
}