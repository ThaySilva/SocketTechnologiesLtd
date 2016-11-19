namespace SocketTechnologiesLtd
{
    partial class SPARes_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPARes_Form));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_viewRequest = new MetroFramework.Controls.MetroTile();
            this.btn_approve = new MetroFramework.Controls.MetroTile();
            this.btn_disapprove = new MetroFramework.Controls.MetroTile();
            this.btn_Cancel = new MetroFramework.Controls.MetroTile();
            this.btn_Exit = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btn_Cancel);
            this.metroPanel1.Controls.Add(this.btn_disapprove);
            this.metroPanel1.Controls.Add(this.btn_approve);
            this.metroPanel1.Controls.Add(this.btn_viewRequest);
            this.metroPanel1.Controls.Add(this.dataGridView1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.axAcroPDF1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(950, 506);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(44, 33);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(363, 25);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Supplier Payment Authorisation Request:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(514, 33);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(422, 413);
            this.axAcroPDF1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(44, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 47);
            this.dataGridView1.TabIndex = 29;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "SPA Request ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Supplier ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Invoice Amount";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // btn_viewRequest
            // 
            this.btn_viewRequest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_viewRequest.Location = new System.Drawing.Point(359, 154);
            this.btn_viewRequest.Name = "btn_viewRequest";
            this.btn_viewRequest.Size = new System.Drawing.Size(113, 38);
            this.btn_viewRequest.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_viewRequest.TabIndex = 38;
            this.btn_viewRequest.Text = "View Request";
            this.btn_viewRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_viewRequest.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_viewRequest.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // btn_approve
            // 
            this.btn_approve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_approve.Location = new System.Drawing.Point(514, 452);
            this.btn_approve.Name = "btn_approve";
            this.btn_approve.Size = new System.Drawing.Size(140, 38);
            this.btn_approve.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_approve.TabIndex = 39;
            this.btn_approve.Text = "Approve Payment";
            this.btn_approve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_approve.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_approve.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // btn_disapprove
            // 
            this.btn_disapprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_disapprove.Location = new System.Drawing.Point(660, 452);
            this.btn_disapprove.Name = "btn_disapprove";
            this.btn_disapprove.Size = new System.Drawing.Size(157, 38);
            this.btn_disapprove.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_disapprove.TabIndex = 40;
            this.btn_disapprove.Text = "Disapprove Payment";
            this.btn_disapprove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_disapprove.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_disapprove.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(823, 452);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(113, 38);
            this.btn_Cancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Cancel.TabIndex = 41;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Cancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.Location = new System.Drawing.Point(878, 18);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(92, 36);
            this.btn_Exit.TabIndex = 43;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // SPARes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 586);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.metroPanel1);
            this.Movable = false;
            this.Name = "SPARes_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Supplier Payment Authorisation Response";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private MetroFramework.Controls.MetroTile btn_Cancel;
        private MetroFramework.Controls.MetroTile btn_disapprove;
        private MetroFramework.Controls.MetroTile btn_approve;
        private MetroFramework.Controls.MetroTile btn_viewRequest;
        private MetroFramework.Controls.MetroButton btn_Exit;
    }
}