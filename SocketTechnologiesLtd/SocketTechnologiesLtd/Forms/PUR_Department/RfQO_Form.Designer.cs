namespace SocketTechnologiesLtd
{
    partial class RfQO_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RfQO_Form));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_SupplierAddress = new MetroFramework.Controls.MetroTextBox();
            this.btn_Cancel = new MetroFramework.Controls.MetroTile();
            this.btn_Create = new MetroFramework.Controls.MetroTile();
            this.txt_SupplierName = new MetroFramework.Controls.MetroTextBox();
            this.txt_QuotationRequired = new MetroFramework.Controls.MetroTextBox();
            this.txt_SupplierId = new MetroFramework.Controls.MetroTextBox();
            this.txt_GRNId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btn_Exit = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txt_DeliveryRequired = new MetroFramework.Controls.MetroTextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroPanel1.Controls.Add(this.txt_DeliveryRequired);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.dataGridView1);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.txt_SupplierAddress);
            this.metroPanel1.Controls.Add(this.btn_Cancel);
            this.metroPanel1.Controls.Add(this.btn_Create);
            this.metroPanel1.Controls.Add(this.txt_SupplierName);
            this.metroPanel1.Controls.Add(this.txt_QuotationRequired);
            this.metroPanel1.Controls.Add(this.txt_SupplierId);
            this.metroPanel1.Controls.Add(this.txt_GRNId);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1051, 616);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroPanel1.TabIndex = 13;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(27, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 48);
            this.dataGridView1.TabIndex = 41;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(27, 287);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(61, 25);
            this.metroLabel7.TabIndex = 40;
            this.metroLabel7.Text = "Parts:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_SupplierAddress
            // 
            this.txt_SupplierAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SupplierAddress.Enabled = false;
            this.txt_SupplierAddress.Location = new System.Drawing.Point(801, 195);
            this.txt_SupplierAddress.Multiline = true;
            this.txt_SupplierAddress.Name = "txt_SupplierAddress";
            this.txt_SupplierAddress.ReadOnly = true;
            this.txt_SupplierAddress.Size = new System.Drawing.Size(216, 72);
            this.txt_SupplierAddress.TabIndex = 39;
            this.txt_SupplierAddress.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(895, 538);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(122, 46);
            this.btn_Cancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Cancel.TabIndex = 38;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Cancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // btn_Create
            // 
            this.btn_Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Create.Location = new System.Drawing.Point(731, 538);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(122, 46);
            this.btn_Create.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Create.TabIndex = 37;
            this.btn_Create.Text = "Create Request";
            this.btn_Create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Create.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Create.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // txt_SupplierName
            // 
            this.txt_SupplierName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SupplierName.Enabled = false;
            this.txt_SupplierName.Location = new System.Drawing.Point(801, 122);
            this.txt_SupplierName.Name = "txt_SupplierName";
            this.txt_SupplierName.ReadOnly = true;
            this.txt_SupplierName.Size = new System.Drawing.Size(216, 27);
            this.txt_SupplierName.TabIndex = 36;
            this.txt_SupplierName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_QuotationRequired
            // 
            this.txt_QuotationRequired.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_QuotationRequired.Location = new System.Drawing.Point(287, 122);
            this.txt_QuotationRequired.Name = "txt_QuotationRequired";
            this.txt_QuotationRequired.Size = new System.Drawing.Size(247, 27);
            this.txt_QuotationRequired.TabIndex = 35;
            this.txt_QuotationRequired.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_SupplierId
            // 
            this.txt_SupplierId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SupplierId.Location = new System.Drawing.Point(801, 41);
            this.txt_SupplierId.Name = "txt_SupplierId";
            this.txt_SupplierId.Size = new System.Drawing.Size(216, 27);
            this.txt_SupplierId.TabIndex = 34;
            this.txt_SupplierId.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_GRNId
            // 
            this.txt_GRNId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_GRNId.Enabled = false;
            this.txt_GRNId.Location = new System.Drawing.Point(287, 43);
            this.txt_GRNId.Name = "txt_GRNId";
            this.txt_GRNId.ReadOnly = true;
            this.txt_GRNId.Size = new System.Drawing.Size(247, 27);
            this.txt_GRNId.TabIndex = 33;
            this.txt_GRNId.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(567, 195);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(160, 25);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "Supplier Address:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(27, 43);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 25);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "RfQO ID:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Enabled = false;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(567, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(142, 25);
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "Supplier Name:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(27, 122);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(213, 25);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Quotation Required By:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(567, 43);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 25);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Supplier ID:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.Location = new System.Drawing.Point(979, 20);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(92, 34);
            this.btn_Exit.TabIndex = 14;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(27, 195);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(197, 25);
            this.metroLabel8.TabIndex = 42;
            this.metroLabel8.Text = "Delivery Required By:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_DeliveryRequired
            // 
            this.txt_DeliveryRequired.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DeliveryRequired.Location = new System.Drawing.Point(287, 195);
            this.txt_DeliveryRequired.Name = "txt_DeliveryRequired";
            this.txt_DeliveryRequired.Size = new System.Drawing.Size(247, 27);
            this.txt_DeliveryRequired.TabIndex = 43;
            this.txt_DeliveryRequired.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Line No.";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Supplier P/N";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // RfQO_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 696);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.metroPanel1);
            this.Name = "RfQO_Form";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Request For Quotation Out";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txt_SupplierAddress;
        private MetroFramework.Controls.MetroTile btn_Cancel;
        private MetroFramework.Controls.MetroTile btn_Create;
        private MetroFramework.Controls.MetroTextBox txt_SupplierName;
        private MetroFramework.Controls.MetroTextBox txt_QuotationRequired;
        private MetroFramework.Controls.MetroTextBox txt_SupplierId;
        private MetroFramework.Controls.MetroTextBox txt_GRNId;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btn_Exit;
        private MetroFramework.Controls.MetroTextBox txt_DeliveryRequired;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}