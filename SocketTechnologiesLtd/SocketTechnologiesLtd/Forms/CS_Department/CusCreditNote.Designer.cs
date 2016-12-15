namespace SocketTechnologiesLtd
{
    partial class CusCreditNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CusCreditNote));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_Cancel = new MetroFramework.Controls.MetroTile();
            this.btn_Create = new MetroFramework.Controls.MetroTile();
            this.date_labal = new MetroFramework.Controls.MetroLabel();
            this.ccnID_label = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lineitems_DGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_label = new MetroFramework.Controls.MetroLabel();
            this.total_tb = new MetroFramework.Controls.MetroTextBox();
            this.ccnID_tb = new MetroFramework.Controls.MetroTextBox();
            this.custID_tb = new MetroFramework.Controls.MetroTextBox();
            this.cpoID_label = new MetroFramework.Controls.MetroLabel();
            this.custID_label = new MetroFramework.Controls.MetroLabel();
            this.btn_Exit = new MetroFramework.Controls.MetroButton();
            this.comboBox_ccn = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineitems_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroPanel1.Controls.Add(this.comboBox_ccn);
            this.metroPanel1.Controls.Add(this.datePicker);
            this.metroPanel1.Controls.Add(this.btn_Cancel);
            this.metroPanel1.Controls.Add(this.btn_Create);
            this.metroPanel1.Controls.Add(this.date_labal);
            this.metroPanel1.Controls.Add(this.ccnID_label);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.lineitems_DGV);
            this.metroPanel1.Controls.Add(this.total_label);
            this.metroPanel1.Controls.Add(this.total_tb);
            this.metroPanel1.Controls.Add(this.ccnID_tb);
            this.metroPanel1.Controls.Add(this.custID_tb);
            this.metroPanel1.Controls.Add(this.cpoID_label);
            this.metroPanel1.Controls.Add(this.custID_label);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(947, 474);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // datePicker
            // 
            this.datePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePicker.Location = new System.Drawing.Point(704, 65);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 59;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(704, 398);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(152, 46);
            this.btn_Cancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Cancel.TabIndex = 58;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Cancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Create.Location = new System.Drawing.Point(522, 398);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(152, 46);
            this.btn_Create.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Create.TabIndex = 57;
            this.btn_Create.Text = "Create Note";
            this.btn_Create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Create.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Create.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // date_labal
            // 
            this.date_labal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_labal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.date_labal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.date_labal.Location = new System.Drawing.Point(533, 62);
            this.date_labal.Name = "date_labal";
            this.date_labal.Size = new System.Drawing.Size(100, 23);
            this.date_labal.TabIndex = 29;
            this.date_labal.Text = "Date:";
            this.date_labal.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ccnID_label
            // 
            this.ccnID_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccnID_label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ccnID_label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ccnID_label.Location = new System.Drawing.Point(29, 62);
            this.ccnID_label.Name = "ccnID_label";
            this.ccnID_label.Size = new System.Drawing.Size(232, 23);
            this.ccnID_label.TabIndex = 28;
            this.ccnID_label.Text = "Customer Credit Note ID:";
            this.ccnID_label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(29, 268);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(136, 19);
            this.metroLabel5.TabIndex = 25;
            this.metroLabel5.Text = "Line Items:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lineitems_DGV
            // 
            this.lineitems_DGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineitems_DGV.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.lineitems_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lineitems_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.lineitems_DGV.Location = new System.Drawing.Point(29, 290);
            this.lineitems_DGV.Name = "lineitems_DGV";
            this.lineitems_DGV.Size = new System.Drawing.Size(712, 58);
            this.lineitems_DGV.TabIndex = 24;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Line No.";
            this.Column1.Name = "Column1";
            this.Column1.Width = 67;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cust P/N";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "QTY";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Unit Price";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Line Price";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "VAT";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total Line Price";
            this.Column7.Name = "Column7";
            // 
            // total_label
            // 
            this.total_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.total_label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.total_label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.total_label.Location = new System.Drawing.Point(522, 124);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(155, 30);
            this.total_label.TabIndex = 23;
            this.total_label.Text = "Total Value:";
            this.total_label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // total_tb
            // 
            this.total_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.total_tb.Location = new System.Drawing.Point(704, 124);
            this.total_tb.Name = "total_tb";
            this.total_tb.Size = new System.Drawing.Size(200, 30);
            this.total_tb.TabIndex = 22;
            this.total_tb.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ccnID_tb
            // 
            this.ccnID_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccnID_tb.Location = new System.Drawing.Point(267, 65);
            this.ccnID_tb.Name = "ccnID_tb";
            this.ccnID_tb.Size = new System.Drawing.Size(200, 30);
            this.ccnID_tb.TabIndex = 19;
            this.ccnID_tb.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // custID_tb
            // 
            this.custID_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.custID_tb.Location = new System.Drawing.Point(267, 185);
            this.custID_tb.Name = "custID_tb";
            this.custID_tb.Size = new System.Drawing.Size(200, 30);
            this.custID_tb.TabIndex = 18;
            this.custID_tb.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cpoID_label
            // 
            this.cpoID_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpoID_label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.cpoID_label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.cpoID_label.Location = new System.Drawing.Point(29, 124);
            this.cpoID_label.Name = "cpoID_label";
            this.cpoID_label.Size = new System.Drawing.Size(176, 30);
            this.cpoID_label.TabIndex = 17;
            this.cpoID_label.Text = "Work Order ID:";
            this.cpoID_label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // custID_label
            // 
            this.custID_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.custID_label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.custID_label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.custID_label.Location = new System.Drawing.Point(29, 185);
            this.custID_label.Name = "custID_label";
            this.custID_label.Size = new System.Drawing.Size(145, 23);
            this.custID_label.TabIndex = 16;
            this.custID_label.Text = "Customer ID:";
            this.custID_label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.Location = new System.Drawing.Point(872, 20);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(92, 34);
            this.btn_Exit.TabIndex = 60;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // comboBox_ccn
            // 
            this.comboBox_ccn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_ccn.FormattingEnabled = true;
            this.comboBox_ccn.ItemHeight = 23;
            this.comboBox_ccn.Location = new System.Drawing.Point(267, 124);
            this.comboBox_ccn.Name = "comboBox_ccn";
            this.comboBox_ccn.Size = new System.Drawing.Size(200, 29);
            this.comboBox_ccn.TabIndex = 60;
            this.comboBox_ccn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.comboBox_ccn.SelectedIndexChanged += new System.EventHandler(this.comboBox_ccn_SelectedIndexChanged);
            // 
            // CusCreditNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 554);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.metroPanel1);
            this.Name = "CusCreditNote";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Create Customer Credit Note";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineitems_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox ccnID_tb;
        private MetroFramework.Controls.MetroTextBox custID_tb;
        private MetroFramework.Controls.MetroLabel cpoID_label;
        private MetroFramework.Controls.MetroLabel custID_label;
        private MetroFramework.Controls.MetroLabel total_label;
        private MetroFramework.Controls.MetroTextBox total_tb;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DataGridView lineitems_DGV;
        private MetroFramework.Controls.MetroLabel date_labal;
        private MetroFramework.Controls.MetroLabel ccnID_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private MetroFramework.Controls.MetroTile btn_Cancel;
        private MetroFramework.Controls.MetroTile btn_Create;
        private MetroFramework.Controls.MetroButton btn_Exit;
        private System.Windows.Forms.DateTimePicker datePicker;
        private MetroFramework.Controls.MetroComboBox comboBox_ccn;
    }
}