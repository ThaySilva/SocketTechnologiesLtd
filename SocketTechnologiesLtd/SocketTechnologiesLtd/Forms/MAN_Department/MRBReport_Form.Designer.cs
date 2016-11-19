namespace SocketTechnologiesLtd
{
    partial class MRBReport_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MRBReport_Form));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_PONo = new MetroFramework.Controls.MetroTextBox();
            this.btn_Cancel = new MetroFramework.Controls.MetroTile();
            this.btn_Create = new MetroFramework.Controls.MetroTile();
            this.txt_MRBReportId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox8 = new MetroFramework.Controls.MetroTextBox();
            this.btn_Exit = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroPanel1.Controls.Add(this.dataGridView1);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.txt_PONo);
            this.metroPanel1.Controls.Add(this.btn_Cancel);
            this.metroPanel1.Controls.Add(this.btn_Create);
            this.metroPanel1.Controls.Add(this.txt_MRBReportId);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroTextBox8);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1051, 616);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroPanel1.TabIndex = 14;
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
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(36, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 48);
            this.dataGridView1.TabIndex = 41;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Line No.";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Supplier P/N";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity Ordered";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Discrepancy";
            this.Column4.Name = "Column4";
            this.Column4.Width = 300;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(27, 113);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(136, 25);
            this.metroLabel7.TabIndex = 40;
            this.metroLabel7.Text = "Supplier Parts:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_PONo
            // 
            this.txt_PONo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_PONo.Location = new System.Drawing.Point(276, 43);
            this.txt_PONo.Name = "txt_PONo";
            this.txt_PONo.Size = new System.Drawing.Size(216, 27);
            this.txt_PONo.TabIndex = 39;
            this.txt_PONo.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.btn_Create.Text = "Create Report";
            this.btn_Create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Create.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Create.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // txt_MRBReportId
            // 
            this.txt_MRBReportId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MRBReportId.Enabled = false;
            this.txt_MRBReportId.Location = new System.Drawing.Point(833, 43);
            this.txt_MRBReportId.Name = "txt_MRBReportId";
            this.txt_MRBReportId.ReadOnly = true;
            this.txt_MRBReportId.Size = new System.Drawing.Size(184, 27);
            this.txt_MRBReportId.TabIndex = 33;
            this.txt_MRBReportId.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(27, 314);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(323, 25);
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "Materials Review Board Report Text:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(507, 43);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(306, 25);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Materials Review Board Report ID:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(27, 43);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(223, 25);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Purchase Order Number:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox8
            // 
            this.metroTextBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTextBox8.Enabled = false;
            this.metroTextBox8.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox8.Location = new System.Drawing.Point(27, 362);
            this.metroTextBox8.Multiline = true;
            this.metroTextBox8.Name = "metroTextBox8";
            this.metroTextBox8.ReadOnly = true;
            this.metroTextBox8.Size = new System.Drawing.Size(990, 104);
            this.metroTextBox8.TabIndex = 24;
            this.metroTextBox8.Text = resources.GetString("metroTextBox8.Text");
            this.metroTextBox8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.Location = new System.Drawing.Point(976, 18);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(92, 36);
            this.btn_Exit.TabIndex = 42;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // MRBReport_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 696);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.metroPanel1);
            this.Movable = false;
            this.Name = "MRBReport_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Materials Review Board Report";
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
        private MetroFramework.Controls.MetroTextBox txt_PONo;
        private MetroFramework.Controls.MetroTile btn_Cancel;
        private MetroFramework.Controls.MetroTile btn_Create;
        private MetroFramework.Controls.MetroTextBox txt_MRBReportId;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private MetroFramework.Controls.MetroButton btn_Exit;
    }
}