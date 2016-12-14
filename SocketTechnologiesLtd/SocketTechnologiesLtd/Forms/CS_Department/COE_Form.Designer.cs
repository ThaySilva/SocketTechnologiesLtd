namespace SocketTechnologiesLtd
{
    partial class COE_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COE_Form));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.comboBox_coe = new MetroFramework.Controls.MetroComboBox();
            this.btn_Cancel = new MetroFramework.Controls.MetroTile();
            this.btn_Create = new MetroFramework.Controls.MetroTile();
            this.CPOid_label = new MetroFramework.Controls.MetroLabel();
            this.custID_tb = new MetroFramework.Controls.MetroTextBox();
            this.custID_label = new MetroFramework.Controls.MetroLabel();
            this.btn_Exit = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroPanel1.Controls.Add(this.comboBox_coe);
            this.metroPanel1.Controls.Add(this.btn_Cancel);
            this.metroPanel1.Controls.Add(this.btn_Create);
            this.metroPanel1.Controls.Add(this.CPOid_label);
            this.metroPanel1.Controls.Add(this.custID_tb);
            this.metroPanel1.Controls.Add(this.custID_label);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(975, 443);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // comboBox_coe
            // 
            this.comboBox_coe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_coe.FormattingEnabled = true;
            this.comboBox_coe.ItemHeight = 23;
            this.comboBox_coe.Location = new System.Drawing.Point(419, 99);
            this.comboBox_coe.Name = "comboBox_coe";
            this.comboBox_coe.Size = new System.Drawing.Size(150, 29);
            this.comboBox_coe.TabIndex = 61;
            this.comboBox_coe.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.comboBox_coe.SelectedIndexChanged += new System.EventHandler(this.comboBox_coe_SelectedIndexChanged);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(777, 376);
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
            this.btn_Create.Location = new System.Drawing.Point(595, 376);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(152, 46);
            this.btn_Create.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Create.TabIndex = 57;
            this.btn_Create.Text = "Get Status";
            this.btn_Create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Create.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Create.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // CPOid_label
            // 
            this.CPOid_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CPOid_label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.CPOid_label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.CPOid_label.Location = new System.Drawing.Point(100, 99);
            this.CPOid_label.Name = "CPOid_label";
            this.CPOid_label.Size = new System.Drawing.Size(170, 30);
            this.CPOid_label.TabIndex = 8;
            this.CPOid_label.Text = "Work Order ID:";
            this.CPOid_label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // custID_tb
            // 
            this.custID_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.custID_tb.Location = new System.Drawing.Point(419, 175);
            this.custID_tb.Name = "custID_tb";
            this.custID_tb.ReadOnly = true;
            this.custID_tb.Size = new System.Drawing.Size(150, 30);
            this.custID_tb.TabIndex = 7;
            this.custID_tb.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // custID_label
            // 
            this.custID_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.custID_label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.custID_label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.custID_label.Location = new System.Drawing.Point(100, 175);
            this.custID_label.Name = "custID_label";
            this.custID_label.Size = new System.Drawing.Size(123, 30);
            this.custID_label.TabIndex = 4;
            this.custID_label.Text = "Customer ID:";
            this.custID_label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.Location = new System.Drawing.Point(903, 20);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(92, 34);
            this.btn_Exit.TabIndex = 59;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // COE_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 523);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.metroPanel1);
            this.Name = "COE_Form";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Issue Customer Order Enquiry";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel CPOid_label;
        private MetroFramework.Controls.MetroTextBox custID_tb;
        private MetroFramework.Controls.MetroLabel custID_label;
        private MetroFramework.Controls.MetroTile btn_Cancel;
        private MetroFramework.Controls.MetroTile btn_Create;
        private MetroFramework.Controls.MetroButton btn_Exit;
        private MetroFramework.Controls.MetroComboBox comboBox_coe;
    }
}