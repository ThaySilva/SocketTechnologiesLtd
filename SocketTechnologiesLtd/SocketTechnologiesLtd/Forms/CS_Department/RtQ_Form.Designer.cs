namespace SocketTechnologiesLtd
{
    partial class RtQ_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RtQ_Form));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.comboBox_rfq = new MetroFramework.Controls.MetroComboBox();
            this.btn_Cancel = new MetroFramework.Controls.MetroTile();
            this.btn_Create = new MetroFramework.Controls.MetroTile();
            this.txt_custAdd = new MetroFramework.Controls.MetroTextBox();
            this.txt_CustomerName = new MetroFramework.Controls.MetroTextBox();
            this.txt_RtQId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_rtqTxt = new MetroFramework.Controls.MetroTextBox();
            this.btn_Exit = new MetroFramework.Controls.MetroButton();
            this.lst_customItems = new System.Windows.Forms.DataGridView();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_customItems)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroPanel1.Controls.Add(this.lst_customItems);
            this.metroPanel1.Controls.Add(this.comboBox_rfq);
            this.metroPanel1.Controls.Add(this.btn_Cancel);
            this.metroPanel1.Controls.Add(this.btn_Create);
            this.metroPanel1.Controls.Add(this.txt_custAdd);
            this.metroPanel1.Controls.Add(this.txt_CustomerName);
            this.metroPanel1.Controls.Add(this.txt_RtQId);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txt_rtqTxt);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1051, 616);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // comboBox_rfq
            // 
            this.comboBox_rfq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_rfq.FormattingEnabled = true;
            this.comboBox_rfq.ItemHeight = 23;
            this.comboBox_rfq.Location = new System.Drawing.Point(287, 43);
            this.comboBox_rfq.Name = "comboBox_rfq";
            this.comboBox_rfq.Size = new System.Drawing.Size(247, 29);
            this.comboBox_rfq.TabIndex = 39;
            this.comboBox_rfq.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.comboBox_rfq.SelectedIndexChanged += new System.EventHandler(this.comboBox_rfq_SelectedIndexChanged);
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
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Create.Location = new System.Drawing.Point(731, 538);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(122, 46);
            this.btn_Create.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Create.TabIndex = 37;
            this.btn_Create.Text = "Create Refusal";
            this.btn_Create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Create.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Create.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // txt_custAdd
            // 
            this.txt_custAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_custAdd.Enabled = false;
            this.txt_custAdd.Location = new System.Drawing.Point(772, 103);
            this.txt_custAdd.Multiline = true;
            this.txt_custAdd.Name = "txt_custAdd";
            this.txt_custAdd.ReadOnly = true;
            this.txt_custAdd.Size = new System.Drawing.Size(245, 120);
            this.txt_custAdd.TabIndex = 36;
            this.txt_custAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CustomerName.Enabled = false;
            this.txt_CustomerName.Location = new System.Drawing.Point(287, 103);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.ReadOnly = true;
            this.txt_CustomerName.Size = new System.Drawing.Size(247, 27);
            this.txt_CustomerName.TabIndex = 35;
            this.txt_CustomerName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_RtQId
            // 
            this.txt_RtQId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_RtQId.Enabled = false;
            this.txt_RtQId.Location = new System.Drawing.Point(772, 43);
            this.txt_RtQId.Name = "txt_RtQId";
            this.txt_RtQId.ReadOnly = true;
            this.txt_RtQId.Size = new System.Drawing.Size(245, 27);
            this.txt_RtQId.TabIndex = 34;
            this.txt_RtQId.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(27, 175);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(133, 25);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "Custom Items:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(27, 359);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(202, 25);
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "Refusal to Quote Text:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(27, 43);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(232, 25);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Request for Quotation ID:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(567, 103);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(171, 25);
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "Customer Address:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(27, 103);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(153, 25);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Customer Name:";
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
            this.metroLabel2.Size = new System.Drawing.Size(185, 25);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Refusal to Quote ID:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_rtqTxt
            // 
            this.txt_rtqTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_rtqTxt.Enabled = false;
            this.txt_rtqTxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_rtqTxt.Location = new System.Drawing.Point(27, 400);
            this.txt_rtqTxt.Multiline = true;
            this.txt_rtqTxt.Name = "txt_rtqTxt";
            this.txt_rtqTxt.ReadOnly = true;
            this.txt_rtqTxt.Size = new System.Drawing.Size(990, 104);
            this.txt_rtqTxt.TabIndex = 24;
            this.txt_rtqTxt.Text = resources.GetString("txt_rtqTxt.Text");
            this.txt_rtqTxt.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.Location = new System.Drawing.Point(963, 20);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(92, 34);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lst_customItems
            // 
            this.lst_customItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lst_customItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lst_customItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst_customItems.Enabled = false;
            this.lst_customItems.Location = new System.Drawing.Point(38, 203);
            this.lst_customItems.Name = "lst_customItems";
            this.lst_customItems.Size = new System.Drawing.Size(496, 150);
            this.lst_customItems.TabIndex = 40;
            // 
            // RtQ_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 696);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "RtQ_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Refusal to Quote";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_customItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txt_rtqTxt;
        private MetroFramework.Controls.MetroButton btn_Exit;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_custAdd;
        private MetroFramework.Controls.MetroTextBox txt_CustomerName;
        private MetroFramework.Controls.MetroTextBox txt_RtQId;
        private MetroFramework.Controls.MetroTile btn_Create;
        private MetroFramework.Controls.MetroTile btn_Cancel;
        private MetroFramework.Controls.MetroComboBox comboBox_rfq;
        private System.Windows.Forms.DataGridView lst_customItems;
    }
}