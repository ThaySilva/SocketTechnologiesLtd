namespace SocketTechnologiesLtd
{
    partial class TE_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TE_Form));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dataView_parts = new System.Windows.Forms.DataGridView();
            this.btn_Cancel = new MetroFramework.Controls.MetroTile();
            this.btn_Create = new MetroFramework.Controls.MetroTile();
            this.txt_TEtext = new MetroFramework.Controls.MetroTextBox();
            this.txt_CustomerAdd = new MetroFramework.Controls.MetroTextBox();
            this.txt_CutomerName = new MetroFramework.Controls.MetroTextBox();
            this.txt_customerId = new MetroFramework.Controls.MetroTextBox();
            this.txt_referenceId = new MetroFramework.Controls.MetroTextBox();
            this.txt_TEId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lbl_parts = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lbl_reference = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btn_Exit = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView_parts)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroPanel1.Controls.Add(this.dataView_parts);
            this.metroPanel1.Controls.Add(this.btn_Cancel);
            this.metroPanel1.Controls.Add(this.btn_Create);
            this.metroPanel1.Controls.Add(this.txt_TEtext);
            this.metroPanel1.Controls.Add(this.txt_CustomerAdd);
            this.metroPanel1.Controls.Add(this.txt_CutomerName);
            this.metroPanel1.Controls.Add(this.txt_customerId);
            this.metroPanel1.Controls.Add(this.txt_referenceId);
            this.metroPanel1.Controls.Add(this.txt_TEId);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.lbl_parts);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.lbl_reference);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1144, 636);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dataView_parts
            // 
            this.dataView_parts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataView_parts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dataView_parts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataView_parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView_parts.Location = new System.Drawing.Point(69, 208);
            this.dataView_parts.Name = "dataView_parts";
            this.dataView_parts.Size = new System.Drawing.Size(493, 103);
            this.dataView_parts.TabIndex = 23;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(997, 557);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(122, 46);
            this.btn_Cancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Cancel.TabIndex = 22;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Cancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Create.Location = new System.Drawing.Point(837, 557);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(122, 46);
            this.btn_Create.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Create.TabIndex = 19;
            this.btn_Create.Text = "Create Enquiry";
            this.btn_Create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Create.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Create.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // txt_TEtext
            // 
            this.txt_TEtext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TEtext.Location = new System.Drawing.Point(69, 375);
            this.txt_TEtext.Multiline = true;
            this.txt_TEtext.Name = "txt_TEtext";
            this.txt_TEtext.Size = new System.Drawing.Size(995, 161);
            this.txt_TEtext.TabIndex = 17;
            this.txt_TEtext.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_CustomerAdd
            // 
            this.txt_CustomerAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CustomerAdd.Enabled = false;
            this.txt_CustomerAdd.Location = new System.Drawing.Point(819, 165);
            this.txt_CustomerAdd.Multiline = true;
            this.txt_CustomerAdd.Name = "txt_CustomerAdd";
            this.txt_CustomerAdd.ReadOnly = true;
            this.txt_CustomerAdd.Size = new System.Drawing.Size(245, 105);
            this.txt_CustomerAdd.TabIndex = 14;
            this.txt_CustomerAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_CutomerName
            // 
            this.txt_CutomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CutomerName.Enabled = false;
            this.txt_CutomerName.Location = new System.Drawing.Point(819, 104);
            this.txt_CutomerName.Name = "txt_CutomerName";
            this.txt_CutomerName.ReadOnly = true;
            this.txt_CutomerName.Size = new System.Drawing.Size(245, 27);
            this.txt_CutomerName.TabIndex = 13;
            this.txt_CutomerName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_customerId
            // 
            this.txt_customerId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_customerId.Enabled = false;
            this.txt_customerId.Location = new System.Drawing.Point(819, 39);
            this.txt_customerId.Name = "txt_customerId";
            this.txt_customerId.ReadOnly = true;
            this.txt_customerId.Size = new System.Drawing.Size(245, 27);
            this.txt_customerId.TabIndex = 12;
            this.txt_customerId.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_referenceId
            // 
            this.txt_referenceId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_referenceId.Enabled = false;
            this.txt_referenceId.Location = new System.Drawing.Point(317, 39);
            this.txt_referenceId.Name = "txt_referenceId";
            this.txt_referenceId.ReadOnly = true;
            this.txt_referenceId.Size = new System.Drawing.Size(245, 27);
            this.txt_referenceId.TabIndex = 11;
            this.txt_referenceId.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_TEId
            // 
            this.txt_TEId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TEId.Enabled = false;
            this.txt_TEId.Location = new System.Drawing.Point(317, 104);
            this.txt_TEId.Name = "txt_TEId";
            this.txt_TEId.ReadOnly = true;
            this.txt_TEId.Size = new System.Drawing.Size(245, 27);
            this.txt_TEId.TabIndex = 10;
            this.txt_TEId.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(69, 332);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(208, 25);
            this.metroLabel7.TabIndex = 9;
            this.metroLabel7.Text = "Technical Enquiry Text:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_parts
            // 
            this.lbl_parts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_parts.AutoSize = true;
            this.lbl_parts.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_parts.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_parts.Location = new System.Drawing.Point(69, 165);
            this.lbl_parts.Name = "lbl_parts";
            this.lbl_parts.Size = new System.Drawing.Size(125, 25);
            this.lbl_parts.TabIndex = 8;
            this.lbl_parts.Text = "Custom Parts";
            this.lbl_parts.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(637, 39);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(122, 25);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Customer ID:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(637, 165);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(171, 25);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Customer Address:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(637, 104);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(153, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Customer Name:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_reference
            // 
            this.lbl_reference.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_reference.AutoSize = true;
            this.lbl_reference.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_reference.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_reference.Location = new System.Drawing.Point(69, 39);
            this.lbl_reference.Name = "lbl_reference";
            this.lbl_reference.Size = new System.Drawing.Size(232, 25);
            this.lbl_reference.TabIndex = 4;
            this.lbl_reference.Text = "Request for Quotation ID:";
            this.lbl_reference.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(69, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(191, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Technical Enquiry ID:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.Location = new System.Drawing.Point(1072, 20);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(92, 34);
            this.btn_Exit.TabIndex = 25;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // TE_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 716);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "TE_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Technical Enquiry";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView_parts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btn_Exit;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_TEId;
        private MetroFramework.Controls.MetroTextBox txt_CustomerAdd;
        private MetroFramework.Controls.MetroTextBox txt_CutomerName;
        private MetroFramework.Controls.MetroTextBox txt_referenceId;
        private MetroFramework.Controls.MetroTile btn_Create;
        private MetroFramework.Controls.MetroTile btn_Cancel;
        public MetroFramework.Controls.MetroTextBox txt_TEtext;
        private System.Windows.Forms.DataGridView dataView_parts;
        public MetroFramework.Controls.MetroLabel lbl_reference;
        public MetroFramework.Controls.MetroLabel lbl_parts;
        public MetroFramework.Controls.MetroTextBox txt_customerId;
    }
}