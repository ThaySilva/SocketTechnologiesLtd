namespace SocketTechnologiesLtd
{
    partial class QO_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QO_Form));
            this.btn_Exit = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_Cancel = new MetroFramework.Controls.MetroTile();
            this.btn_Issue = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.gridView_standard = new System.Windows.Forms.DataGridView();
            this.gridView_custom = new System.Windows.Forms.DataGridView();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_custName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_orderTotal = new MetroFramework.Controls.MetroTextBox();
            this.comboBox_rfq = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_standard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_custom)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.Location = new System.Drawing.Point(1122, 19);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(92, 34);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.comboBox_rfq);
            this.metroPanel1.Controls.Add(this.txt_orderTotal);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.txt_custName);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.gridView_custom);
            this.metroPanel1.Controls.Add(this.gridView_standard);
            this.metroPanel1.Controls.Add(this.btn_Cancel);
            this.metroPanel1.Controls.Add(this.btn_Issue);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1197, 638);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(1062, 578);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(122, 46);
            this.btn_Cancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Cancel.TabIndex = 22;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Cancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // btn_Issue
            // 
            this.btn_Issue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Issue.Location = new System.Drawing.Point(923, 578);
            this.btn_Issue.Name = "btn_Issue";
            this.btn_Issue.Size = new System.Drawing.Size(122, 46);
            this.btn_Issue.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Issue.TabIndex = 15;
            this.btn_Issue.Text = "Issue Quotation";
            this.btn_Issue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Issue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Issue.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(63, 291);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(128, 25);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Custom Items";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(63, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(141, 25);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Standard Items";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(63, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(232, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Request for Quotation ID:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // gridView_standard
            // 
            this.gridView_standard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridView_standard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridView_standard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView_standard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_standard.Location = new System.Drawing.Point(63, 139);
            this.gridView_standard.Name = "gridView_standard";
            this.gridView_standard.Size = new System.Drawing.Size(793, 130);
            this.gridView_standard.TabIndex = 23;
            // 
            // gridView_custom
            // 
            this.gridView_custom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridView_custom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridView_custom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView_custom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_custom.Location = new System.Drawing.Point(63, 330);
            this.gridView_custom.Name = "gridView_custom";
            this.gridView_custom.Size = new System.Drawing.Size(793, 130);
            this.gridView_custom.TabIndex = 24;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(585, 39);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(153, 25);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Customer Name:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_custName
            // 
            this.txt_custName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_custName.Location = new System.Drawing.Point(767, 39);
            this.txt_custName.Name = "txt_custName";
            this.txt_custName.Size = new System.Drawing.Size(246, 27);
            this.txt_custName.TabIndex = 27;
            this.txt_custName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(635, 480);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(113, 25);
            this.metroLabel5.TabIndex = 28;
            this.metroLabel5.Text = "Order Total:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_orderTotal
            // 
            this.txt_orderTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_orderTotal.Location = new System.Drawing.Point(767, 478);
            this.txt_orderTotal.Name = "txt_orderTotal";
            this.txt_orderTotal.Size = new System.Drawing.Size(246, 27);
            this.txt_orderTotal.TabIndex = 29;
            this.txt_orderTotal.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // comboBox_rfq
            // 
            this.comboBox_rfq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_rfq.FormattingEnabled = true;
            this.comboBox_rfq.ItemHeight = 23;
            this.comboBox_rfq.Location = new System.Drawing.Point(311, 39);
            this.comboBox_rfq.Name = "comboBox_rfq";
            this.comboBox_rfq.Size = new System.Drawing.Size(247, 29);
            this.comboBox_rfq.TabIndex = 40;
            this.comboBox_rfq.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.comboBox_rfq.SelectedIndexChanged += new System.EventHandler(this.comboBox_rfq_SelectedIndexChanged);
            // 
            // QO_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 718);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btn_Exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "QO_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Issue Quotation Out";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_standard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_custom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_Exit;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile btn_Issue;
        private MetroFramework.Controls.MetroTile btn_Cancel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridView gridView_custom;
        private System.Windows.Forms.DataGridView gridView_standard;
        private MetroFramework.Controls.MetroTextBox txt_orderTotal;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_custName;
        private MetroFramework.Controls.MetroComboBox comboBox_rfq;
    }
}