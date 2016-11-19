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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RfQID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StandarItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardItemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customItemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StandardPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QStandardQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qvat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btn_QStandard = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Qcustom = new MetroFramework.Controls.MetroTile();
            this.btn_Issue = new MetroFramework.Controls.MetroTile();
            this.btn_Cancel = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.Location = new System.Drawing.Point(974, 19);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(92, 34);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btn_Cancel);
            this.metroPanel1.Controls.Add(this.btn_Issue);
            this.metroPanel1.Controls.Add(this.btn_Qcustom);
            this.metroPanel1.Controls.Add(this.dataGridView3);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.btn_QStandard);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.dataGridView2);
            this.metroPanel1.Controls.Add(this.dataGridView1);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1049, 575);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(35, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(216, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Request for Quotations:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RfQID,
            this.StandarItemId,
            this.standardItemQty,
            this.customItemId,
            this.customItemQty});
            this.dataGridView1.Location = new System.Drawing.Point(35, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 45);
            this.dataGridView1.TabIndex = 3;
            // 
            // RfQID
            // 
            this.RfQID.HeaderText = "RfQ ID";
            this.RfQID.Name = "RfQID";
            this.RfQID.Width = 150;
            // 
            // StandarItemId
            // 
            this.StandarItemId.HeaderText = "Standard Item ID";
            this.StandarItemId.Name = "StandarItemId";
            this.StandarItemId.Width = 150;
            // 
            // standardItemQty
            // 
            this.standardItemQty.HeaderText = "Standard Item Quantity";
            this.standardItemQty.Name = "standardItemQty";
            this.standardItemQty.Width = 150;
            // 
            // customItemId
            // 
            this.customItemId.HeaderText = "Custom Item ID";
            this.customItemId.Name = "customItemId";
            this.customItemId.Width = 150;
            // 
            // customItemQty
            // 
            this.customItemQty.HeaderText = "Custom Item Quantity";
            this.customItemQty.Name = "customItemQty";
            this.customItemQty.Width = 150;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LineNo,
            this.StandardPN,
            this.QStandardQty,
            this.UnitPrice,
            this.LinePrice,
            this.Qvat,
            this.LineTotal});
            this.dataGridView2.Location = new System.Drawing.Point(35, 322);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(743, 43);
            this.dataGridView2.TabIndex = 4;
            // 
            // LineNo
            // 
            this.LineNo.HeaderText = "Line No.";
            this.LineNo.Name = "LineNo";
            // 
            // StandardPN
            // 
            this.StandardPN.HeaderText = "STL P/N";
            this.StandardPN.Name = "StandardPN";
            // 
            // QStandardQty
            // 
            this.QStandardQty.HeaderText = "Quantity";
            this.QStandardQty.Name = "QStandardQty";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // LinePrice
            // 
            this.LinePrice.HeaderText = "Line Price";
            this.LinePrice.Name = "LinePrice";
            // 
            // Qvat
            // 
            this.Qvat.HeaderText = "VAT";
            this.Qvat.Name = "Qvat";
            // 
            // LineTotal
            // 
            this.LineTotal.HeaderText = "Line Total";
            this.LineTotal.Name = "LineTotal";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(35, 281);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(141, 25);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Standard Items";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_QStandard
            // 
            this.btn_QStandard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_QStandard.Location = new System.Drawing.Point(838, 322);
            this.btn_QStandard.Name = "btn_QStandard";
            this.btn_QStandard.Size = new System.Drawing.Size(165, 41);
            this.btn_QStandard.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_QStandard.TabIndex = 11;
            this.btn_QStandard.Text = "Quote Standard Items";
            this.btn_QStandard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_QStandard.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_QStandard.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(35, 389);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(128, 25);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Custom Items";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView3.Location = new System.Drawing.Point(35, 429);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(743, 43);
            this.dataGridView3.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Line No.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Custom P/N";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Line Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "VAT";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Line Total";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // btn_Qcustom
            // 
            this.btn_Qcustom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Qcustom.Location = new System.Drawing.Point(838, 429);
            this.btn_Qcustom.Name = "btn_Qcustom";
            this.btn_Qcustom.Size = new System.Drawing.Size(165, 41);
            this.btn_Qcustom.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Qcustom.TabIndex = 14;
            this.btn_Qcustom.Text = "Quote Custom Items";
            this.btn_Qcustom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Qcustom.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Qcustom.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // btn_Issue
            // 
            this.btn_Issue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Issue.Location = new System.Drawing.Point(737, 498);
            this.btn_Issue.Name = "btn_Issue";
            this.btn_Issue.Size = new System.Drawing.Size(122, 46);
            this.btn_Issue.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Issue.TabIndex = 15;
            this.btn_Issue.Text = "Issue Quotation";
            this.btn_Issue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Issue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Issue.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(893, 498);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(122, 46);
            this.btn_Cancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Cancel.TabIndex = 22;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Cancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // QO_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 655);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_Exit;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StandardPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn QStandardQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qvat;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RfQID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StandarItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardItemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn customItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn customItemQty;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile btn_Qcustom;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile btn_QStandard;
        private MetroFramework.Controls.MetroTile btn_Issue;
        private MetroFramework.Controls.MetroTile btn_Cancel;
    }
}