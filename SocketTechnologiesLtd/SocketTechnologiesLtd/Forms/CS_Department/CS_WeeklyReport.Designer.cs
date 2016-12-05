namespace SocketTechnologiesLtd
{
    partial class CS_WeeklyReport
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
            this.btn_CSExit = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FSR_tile = new MetroFramework.Controls.MetroTile();
            this.SN_tile = new MetroFramework.Controls.MetroTile();
            this.FRQ_tile = new MetroFramework.Controls.MetroTile();
            this.OE_tile = new MetroFramework.Controls.MetroTile();
            this.OR_tile = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CSExit
            // 
            this.btn_CSExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CSExit.Location = new System.Drawing.Point(561, 19);
            this.btn_CSExit.Name = "btn_CSExit";
            this.btn_CSExit.Size = new System.Drawing.Size(92, 36);
            this.btn_CSExit.TabIndex = 19;
            this.btn_CSExit.Text = "Exit";
            this.btn_CSExit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_CSExit.Click += new System.EventHandler(this.btn_CSExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33555F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel1.Controls.Add(this.FSR_tile, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.OE_tile, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.FRQ_tile, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.SN_tile, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OR_tile, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 337);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // FSR_tile
            // 
            this.FSR_tile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FSR_tile.Location = new System.Drawing.Point(215, 3);
            this.FSR_tile.Name = "FSR_tile";
            this.FSR_tile.Size = new System.Drawing.Size(205, 106);
            this.FSR_tile.Style = MetroFramework.MetroColorStyle.Orange;
            this.FSR_tile.TabIndex = 19;
            this.FSR_tile.Text = "Field Service Request";
            this.FSR_tile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FSR_tile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FSR_tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.FSR_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // SN_tile
            // 
            this.SN_tile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SN_tile.Location = new System.Drawing.Point(3, 115);
            this.SN_tile.Name = "SN_tile";
            this.SN_tile.Size = new System.Drawing.Size(206, 106);
            this.SN_tile.Style = MetroFramework.MetroColorStyle.Orange;
            this.SN_tile.TabIndex = 18;
            this.SN_tile.Text = "Scrap Notes";
            this.SN_tile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SN_tile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SN_tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.SN_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // FRQ_tile
            // 
            this.FRQ_tile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FRQ_tile.Location = new System.Drawing.Point(426, 115);
            this.FRQ_tile.Name = "FRQ_tile";
            this.FRQ_tile.Size = new System.Drawing.Size(207, 106);
            this.FRQ_tile.Style = MetroFramework.MetroColorStyle.Orange;
            this.FRQ_tile.TabIndex = 16;
            this.FRQ_tile.Text = "Request For Quotations";
            this.FRQ_tile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FRQ_tile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FRQ_tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.FRQ_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // OE_tile
            // 
            this.OE_tile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OE_tile.Location = new System.Drawing.Point(215, 115);
            this.OE_tile.Name = "OE_tile";
            this.OE_tile.Size = new System.Drawing.Size(205, 106);
            this.OE_tile.Style = MetroFramework.MetroColorStyle.Orange;
            this.OE_tile.TabIndex = 15;
            this.OE_tile.Text = "Order Enquires";
            this.OE_tile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OE_tile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OE_tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.OE_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // OR_tile
            // 
            this.OR_tile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OR_tile.Location = new System.Drawing.Point(215, 227);
            this.OR_tile.Name = "OR_tile";
            this.OR_tile.Size = new System.Drawing.Size(205, 107);
            this.OR_tile.Style = MetroFramework.MetroColorStyle.Orange;
            this.OR_tile.TabIndex = 20;
            this.OR_tile.Text = "Orders Received";
            this.OR_tile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OR_tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.OR_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // CS_WeeklyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 417);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_CSExit);
            this.Name = "CS_WeeklyReport";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Generate Weekly Reports";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_CSExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTile FSR_tile;
        private MetroFramework.Controls.MetroTile OE_tile;
        private MetroFramework.Controls.MetroTile FRQ_tile;
        private MetroFramework.Controls.MetroTile SN_tile;
        private MetroFramework.Controls.MetroTile OR_tile;
    }
}