namespace SocketTechnologiesLtd
{
    partial class ViewCustomerDetails
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
            this.gbCustomerDetails = new System.Windows.Forms.GroupBox();
            this.btnAddCustomerViewCust = new System.Windows.Forms.Button();
            this.btnEditCustomerViewCust = new System.Windows.Forms.Button();
            this.btnDeleteCustomerViewCust = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCustomerSearch = new System.Windows.Forms.TextBox();
            this.btnBackViewCust = new System.Windows.Forms.Button();
            this.groupBoxViewCustomers = new System.Windows.Forms.GroupBox();
            this.dataGrid_Customer1 = new System.Windows.Forms.DataGridView();
            this.customerTableAdapter3 = new SocketTechnologiesLtd.stldb2DataSet2TableAdapters.CustomerTableAdapter();
            this.btn_Search = new MetroFramework.Controls.MetroTile();
            this.groupBoxViewCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Customer1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCustomerDetails
            // 
            this.gbCustomerDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomerDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbCustomerDetails.Location = new System.Drawing.Point(750, 81);
            this.gbCustomerDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gbCustomerDetails.Name = "gbCustomerDetails";
            this.gbCustomerDetails.Padding = new System.Windows.Forms.Padding(2);
            this.gbCustomerDetails.Size = new System.Drawing.Size(340, 548);
            this.gbCustomerDetails.TabIndex = 87;
            this.gbCustomerDetails.TabStop = false;
            this.gbCustomerDetails.Text = "Customer Details";
            this.gbCustomerDetails.Enter += new System.EventHandler(this.gbCustomerDetails_Enter);
            // 
            // btnAddCustomerViewCust
            // 
            this.btnAddCustomerViewCust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCustomerViewCust.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddCustomerViewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomerViewCust.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddCustomerViewCust.Location = new System.Drawing.Point(550, 187);
            this.btnAddCustomerViewCust.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCustomerViewCust.Name = "btnAddCustomerViewCust";
            this.btnAddCustomerViewCust.Size = new System.Drawing.Size(172, 45);
            this.btnAddCustomerViewCust.TabIndex = 86;
            this.btnAddCustomerViewCust.Text = "ADD";
            this.btnAddCustomerViewCust.UseVisualStyleBackColor = false;
            this.btnAddCustomerViewCust.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnEditCustomerViewCust
            // 
            this.btnEditCustomerViewCust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditCustomerViewCust.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditCustomerViewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomerViewCust.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditCustomerViewCust.Location = new System.Drawing.Point(550, 288);
            this.btnEditCustomerViewCust.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCustomerViewCust.Name = "btnEditCustomerViewCust";
            this.btnEditCustomerViewCust.Size = new System.Drawing.Size(172, 45);
            this.btnEditCustomerViewCust.TabIndex = 82;
            this.btnEditCustomerViewCust.Text = "EDIT";
            this.btnEditCustomerViewCust.UseVisualStyleBackColor = false;
            this.btnEditCustomerViewCust.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnDeleteCustomerViewCust
            // 
            this.btnDeleteCustomerViewCust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteCustomerViewCust.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteCustomerViewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomerViewCust.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteCustomerViewCust.Location = new System.Drawing.Point(550, 392);
            this.btnDeleteCustomerViewCust.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteCustomerViewCust.Name = "btnDeleteCustomerViewCust";
            this.btnDeleteCustomerViewCust.Size = new System.Drawing.Size(172, 45);
            this.btnDeleteCustomerViewCust.TabIndex = 81;
            this.btnDeleteCustomerViewCust.Text = "DELETE";
            this.btnDeleteCustomerViewCust.UseVisualStyleBackColor = false;
            this.btnDeleteCustomerViewCust.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(163, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 80;
            this.label2.Text = "Search/Filter:";
            // 
            // tbCustomerSearch
            // 
            this.tbCustomerSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCustomerSearch.BackColor = System.Drawing.Color.DimGray;
            this.tbCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerSearch.Location = new System.Drawing.Point(299, 81);
            this.tbCustomerSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerSearch.Name = "tbCustomerSearch";
            this.tbCustomerSearch.Size = new System.Drawing.Size(231, 28);
            this.tbCustomerSearch.TabIndex = 79;
            this.tbCustomerSearch.Click += new System.EventHandler(this.tbCustomerSearch_Click);
            // 
            // btnBackViewCust
            // 
            this.btnBackViewCust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackViewCust.BackColor = System.Drawing.Color.White;
            this.btnBackViewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackViewCust.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackViewCust.Location = new System.Drawing.Point(918, 661);
            this.btnBackViewCust.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackViewCust.Name = "btnBackViewCust";
            this.btnBackViewCust.Size = new System.Drawing.Size(172, 45);
            this.btnBackViewCust.TabIndex = 88;
            this.btnBackViewCust.Text = "BACK";
            this.btnBackViewCust.UseVisualStyleBackColor = false;
            this.btnBackViewCust.Click += new System.EventHandler(this.btnBackViewCust_Click);
            // 
            // groupBoxViewCustomers
            // 
            this.groupBoxViewCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxViewCustomers.Controls.Add(this.dataGrid_Customer1);
            this.groupBoxViewCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.groupBoxViewCustomers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxViewCustomers.Location = new System.Drawing.Point(23, 136);
            this.groupBoxViewCustomers.Name = "groupBoxViewCustomers";
            this.groupBoxViewCustomers.Size = new System.Drawing.Size(507, 515);
            this.groupBoxViewCustomers.TabIndex = 91;
            this.groupBoxViewCustomers.TabStop = false;
            this.groupBoxViewCustomers.Text = "List of Customers";
            // 
            // dataGrid_Customer1
            // 
            this.dataGrid_Customer1.AllowUserToAddRows = false;
            this.dataGrid_Customer1.AllowUserToDeleteRows = false;
            this.dataGrid_Customer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGrid_Customer1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dataGrid_Customer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_Customer1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Customer1.Location = new System.Drawing.Point(20, 51);
            this.dataGrid_Customer1.MultiSelect = false;
            this.dataGrid_Customer1.Name = "dataGrid_Customer1";
            this.dataGrid_Customer1.ReadOnly = true;
            this.dataGrid_Customer1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrid_Customer1.Size = new System.Drawing.Size(481, 366);
            this.dataGrid_Customer1.TabIndex = 68;
            this.dataGrid_Customer1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Customer1_CellContentClick);
            // 
            // customerTableAdapter3
            // 
            this.customerTableAdapter3.ClearBeforeFill = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.Location = new System.Drawing.Point(550, 81);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(172, 32);
            this.btn_Search.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Search.TabIndex = 92;
            this.btn_Search.Text = "Search ";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Search.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Search.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // ViewCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1112, 728);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.groupBoxViewCustomers);
            this.Controls.Add(this.btnBackViewCust);
            this.Controls.Add(this.gbCustomerDetails);
            this.Controls.Add(this.btnAddCustomerViewCust);
            this.Controls.Add(this.tbCustomerSearch);
            this.Controls.Add(this.btnDeleteCustomerViewCust);
            this.Controls.Add(this.btnEditCustomerViewCust);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "ViewCustomerDetails";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "View Customer Details";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.groupBoxViewCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Customer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCustomerDetails;
        private System.Windows.Forms.Button btnAddCustomerViewCust;
        private System.Windows.Forms.Button btnEditCustomerViewCust;
        private System.Windows.Forms.Button btnDeleteCustomerViewCust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCustomerSearch;
        private System.Windows.Forms.Button btnBackViewCust;
        private System.Windows.Forms.GroupBox groupBoxViewCustomers;
        private stldb2DataSet2TableAdapters.CustomerTableAdapter customerTableAdapter3;
        private MetroFramework.Controls.MetroTile btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGrid_Customer1;
    }
}