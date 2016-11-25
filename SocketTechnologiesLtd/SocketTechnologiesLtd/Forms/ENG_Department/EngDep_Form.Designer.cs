namespace SocketTechnologiesLtd
{
    partial class EngDep_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EngDep_Form));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_AddCustomProduct = new MetroFramework.Controls.MetroTile();
            this.btn_ViewTE = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(867, 26);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(92, 34);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Log Out";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn_AddCustomProduct, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_ViewTE, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(936, 499);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btn_AddCustomProduct
            // 
            this.btn_AddCustomProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddCustomProduct.Location = new System.Drawing.Point(315, 127);
            this.btn_AddCustomProduct.Name = "btn_AddCustomProduct";
            this.btn_AddCustomProduct.Size = new System.Drawing.Size(306, 118);
            this.btn_AddCustomProduct.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_AddCustomProduct.TabIndex = 4;
            this.btn_AddCustomProduct.Text = "Add Custom Product";
            this.btn_AddCustomProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AddCustomProduct.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_AddCustomProduct.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddCustomProduct.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_AddCustomProduct.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_AddCustomProduct.UseTileImage = true;
            this.btn_AddCustomProduct.Click += new System.EventHandler(this.btn_AddCustomProduct_Click);
            // 
            // btn_ViewTE
            // 
            this.btn_ViewTE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ViewTE.Location = new System.Drawing.Point(315, 251);
            this.btn_ViewTE.Name = "btn_ViewTE";
            this.btn_ViewTE.Size = new System.Drawing.Size(306, 118);
            this.btn_ViewTE.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_ViewTE.TabIndex = 5;
            this.btn_ViewTE.Text = "View Technical Enquiry";
            this.btn_ViewTE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ViewTE.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_ViewTE.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ViewTE.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_ViewTE.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_ViewTE.UseTileImage = true;
            this.btn_ViewTE.Click += new System.EventHandler(this.btn_ViewTE_Click);
            // 
            // EngDep_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 585);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.metroButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "EngDep_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Engineering Department";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTile btn_AddCustomProduct;
        private MetroFramework.Controls.MetroTile btn_ViewTE;
    }
}