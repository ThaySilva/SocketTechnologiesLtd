namespace SocketTechnologiesLtd
{
    partial class FGTN_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGTN_Form));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_Cancel = new MetroFramework.Controls.MetroTile();
            this.btn_Create = new MetroFramework.Controls.MetroTile();
            this.txt_FGTNId = new MetroFramework.Controls.MetroTextBox();
            this.txt_LTNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_FGTNText = new MetroFramework.Controls.MetroTextBox();
            this.btn_Exit = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroPanel1.Controls.Add(this.btn_Cancel);
            this.metroPanel1.Controls.Add(this.btn_Create);
            this.metroPanel1.Controls.Add(this.txt_FGTNId);
            this.metroPanel1.Controls.Add(this.txt_LTNo);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.dataGridView1);
            this.metroPanel1.Controls.Add(this.txt_FGTNText);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1051, 616);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroPanel1.TabIndex = 12;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
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
            this.btn_Create.Text = "Create Note";
            this.btn_Create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Create.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Create.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // txt_FGTNId
            // 
            this.txt_FGTNId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_FGTNId.Enabled = false;
            this.txt_FGTNId.Location = new System.Drawing.Point(772, 43);
            this.txt_FGTNId.Name = "txt_FGTNId";
            this.txt_FGTNId.ReadOnly = true;
            this.txt_FGTNId.Size = new System.Drawing.Size(245, 27);
            this.txt_FGTNId.TabIndex = 34;
            this.txt_FGTNId.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_LTNo
            // 
            this.txt_LTNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_LTNo.Location = new System.Drawing.Point(287, 43);
            this.txt_LTNo.Name = "txt_LTNo";
            this.txt_LTNo.Size = new System.Drawing.Size(247, 27);
            this.txt_LTNo.TabIndex = 33;
            this.txt_LTNo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(27, 117);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(146, 25);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "Finished Goods:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(27, 280);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(309, 25);
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "Finished Goods Transfer Note Text:";
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
            this.metroLabel4.Size = new System.Drawing.Size(198, 25);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Lot Traveller Number:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(567, 43);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(139, 25);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "FGTN Number:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.description,
            this.Column4,
            this.SerialNos});
            this.dataGridView1.Location = new System.Drawing.Point(27, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(997, 58);
            this.dataGridView1.TabIndex = 26;
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
            this.Column2.HeaderText = "STL P/N";
            this.Column2.Name = "Column2";
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.Width = 170;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.Width = 170;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date Required";
            this.Column4.Name = "Column4";
            this.Column4.Width = 170;
            // 
            // SerialNos
            // 
            this.SerialNos.HeaderText = "Serial Numbers:";
            this.SerialNos.Name = "SerialNos";
            this.SerialNos.Width = 200;
            // 
            // txt_FGTNText
            // 
            this.txt_FGTNText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_FGTNText.Enabled = false;
            this.txt_FGTNText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_FGTNText.Location = new System.Drawing.Point(27, 323);
            this.txt_FGTNText.Multiline = true;
            this.txt_FGTNText.Name = "txt_FGTNText";
            this.txt_FGTNText.ReadOnly = true;
            this.txt_FGTNText.Size = new System.Drawing.Size(990, 104);
            this.txt_FGTNText.TabIndex = 24;
            this.txt_FGTNText.Text = "The Following goods have been manufactured and tested with the appropriate Serial" +
    " No. applied. These require shipment to customer by the required date (below).";
            this.txt_FGTNText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.Location = new System.Drawing.Point(976, 18);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(92, 36);
            this.btn_Exit.TabIndex = 19;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // FGTN_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 696);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FGTN_Form";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Finished Goods Transfer Note";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile btn_Cancel;
        private MetroFramework.Controls.MetroTile btn_Create;
        private MetroFramework.Controls.MetroTextBox txt_FGTNId;
        private MetroFramework.Controls.MetroTextBox txt_LTNo;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox txt_FGTNText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNos;
        private MetroFramework.Controls.MetroButton btn_Exit;
    }
}