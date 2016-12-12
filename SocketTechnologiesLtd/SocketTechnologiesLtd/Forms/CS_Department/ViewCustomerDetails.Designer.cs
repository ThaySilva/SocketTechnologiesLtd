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
            this.components = new System.ComponentModel.Container();
            this.lblEmailViewCust = new System.Windows.Forms.Label();
            this.gbCustomerDetails = new System.Windows.Forms.GroupBox();
            this.lblCustIDViewCust = new System.Windows.Forms.Label();
            this.lblPhoneNoViewCust = new System.Windows.Forms.Label();
            this.lblCusSurnameViewCust = new System.Windows.Forms.Label();
            this.lblAddress2ViewCust = new System.Windows.Forms.Label();
            this.lblAddress1ViewCust = new System.Windows.Forms.Label();
            this.lblAddress3ViewCust = new System.Windows.Forms.Label();
            this.lblCustFirstNameViewCust = new System.Windows.Forms.Label();
            this.lblCompNameViewCust = new System.Windows.Forms.Label();
            this.btnAddCustomerViewCust = new System.Windows.Forms.Button();
            this.btnEditCustomerViewCust = new System.Windows.Forms.Button();
            this.btnDeleteCustomerViewCust = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCustomerSearch = new System.Windows.Forms.TextBox();
            this.btnBackViewCust = new System.Windows.Forms.Button();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.stldb1DataSet = new SocketTechnologiesLtd.stldb1DataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new SocketTechnologiesLtd.stldb1DataSetTableAdapters.CustomerTableAdapter();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custCompanyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPhoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAddLine2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custCountyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stldb1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmailViewCust
            // 
            this.lblEmailViewCust.AutoSize = true;
            this.lblEmailViewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailViewCust.Location = new System.Drawing.Point(122, 481);
            this.lblEmailViewCust.Name = "lblEmailViewCust";
            this.lblEmailViewCust.Size = new System.Drawing.Size(62, 24);
            this.lblEmailViewCust.TabIndex = 23;
            this.lblEmailViewCust.Text = "Email:";
            // 
            // gbCustomerDetails
            // 
            this.gbCustomerDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCustomerDetails.Controls.Add(this.lblEmailViewCust);
            this.gbCustomerDetails.Controls.Add(this.lblCustIDViewCust);
            this.gbCustomerDetails.Controls.Add(this.lblPhoneNoViewCust);
            this.gbCustomerDetails.Controls.Add(this.lblCusSurnameViewCust);
            this.gbCustomerDetails.Controls.Add(this.lblAddress2ViewCust);
            this.gbCustomerDetails.Controls.Add(this.lblAddress1ViewCust);
            this.gbCustomerDetails.Controls.Add(this.lblAddress3ViewCust);
            this.gbCustomerDetails.Controls.Add(this.lblCustFirstNameViewCust);
            this.gbCustomerDetails.Controls.Add(this.lblCompNameViewCust);
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
            // lblCustIDViewCust
            // 
            this.lblCustIDViewCust.AutoSize = true;
            this.lblCustIDViewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustIDViewCust.Location = new System.Drawing.Point(68, 72);
            this.lblCustIDViewCust.Name = "lblCustIDViewCust";
            this.lblCustIDViewCust.Size = new System.Drawing.Size(118, 24);
            this.lblCustIDViewCust.TabIndex = 13;
            this.lblCustIDViewCust.Text = "Customer ID:";
            // 
            // lblPhoneNoViewCust
            // 
            this.lblPhoneNoViewCust.AutoSize = true;
            this.lblPhoneNoViewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNoViewCust.Location = new System.Drawing.Point(90, 428);
            this.lblPhoneNoViewCust.Name = "lblPhoneNoViewCust";
            this.lblPhoneNoViewCust.Size = new System.Drawing.Size(101, 24);
            this.lblPhoneNoViewCust.TabIndex = 12;
            this.lblPhoneNoViewCust.Text = "Phone No:";
            // 
            // lblCusSurnameViewCust
            // 
            this.lblCusSurnameViewCust.AutoSize = true;
            this.lblCusSurnameViewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusSurnameViewCust.Location = new System.Drawing.Point(28, 218);
            this.lblCusSurnameViewCust.Name = "lblCusSurnameViewCust";
            this.lblCusSurnameViewCust.Size = new System.Drawing.Size(160, 24);
            this.lblCusSurnameViewCust.TabIndex = 11;
            this.lblCusSurnameViewCust.Text = "Contact Surname:";
            // 
            // lblAddress2ViewCust
            // 
            this.lblAddress2ViewCust.AutoSize = true;
            this.lblAddress2ViewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2ViewCust.Location = new System.Drawing.Point(89, 322);
            this.lblAddress2ViewCust.Name = "lblAddress2ViewCust";
            this.lblAddress2ViewCust.Size = new System.Drawing.Size(100, 24);
            this.lblAddress2ViewCust.TabIndex = 9;
            this.lblAddress2ViewCust.Text = "Address 2:";
            // 
            // lblAddress1ViewCust
            // 
            this.lblAddress1ViewCust.AutoSize = true;
            this.lblAddress1ViewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1ViewCust.Location = new System.Drawing.Point(89, 269);
            this.lblAddress1ViewCust.Name = "lblAddress1ViewCust";
            this.lblAddress1ViewCust.Size = new System.Drawing.Size(100, 24);
            this.lblAddress1ViewCust.TabIndex = 8;
            this.lblAddress1ViewCust.Text = "Address 1:";
            // 
            // lblAddress3ViewCust
            // 
            this.lblAddress3ViewCust.AutoSize = true;
            this.lblAddress3ViewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress3ViewCust.Location = new System.Drawing.Point(89, 375);
            this.lblAddress3ViewCust.Name = "lblAddress3ViewCust";
            this.lblAddress3ViewCust.Size = new System.Drawing.Size(100, 24);
            this.lblAddress3ViewCust.TabIndex = 7;
            this.lblAddress3ViewCust.Text = "Address 3:";
            // 
            // lblCustFirstNameViewCust
            // 
            this.lblCustFirstNameViewCust.AutoSize = true;
            this.lblCustFirstNameViewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustFirstNameViewCust.Location = new System.Drawing.Point(10, 167);
            this.lblCustFirstNameViewCust.Name = "lblCustFirstNameViewCust";
            this.lblCustFirstNameViewCust.Size = new System.Drawing.Size(174, 24);
            this.lblCustFirstNameViewCust.TabIndex = 6;
            this.lblCustFirstNameViewCust.Text = "Contact First Name:";
            // 
            // lblCompNameViewCust
            // 
            this.lblCompNameViewCust.AutoSize = true;
            this.lblCompNameViewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompNameViewCust.Location = new System.Drawing.Point(38, 117);
            this.lblCompNameViewCust.Name = "lblCompNameViewCust";
            this.lblCompNameViewCust.Size = new System.Drawing.Size(152, 24);
            this.lblCompNameViewCust.TabIndex = 5;
            this.lblCompNameViewCust.Text = "Company Name:";
            // 
            // btnAddCustomerViewCust
            // 
            this.btnAddCustomerViewCust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCustomerViewCust.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddCustomerViewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomerViewCust.Location = new System.Drawing.Point(551, 187);
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
            this.btnEditCustomerViewCust.Location = new System.Drawing.Point(551, 237);
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
            this.btnDeleteCustomerViewCust.Location = new System.Drawing.Point(551, 288);
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
            this.tbCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerSearch.Location = new System.Drawing.Point(299, 81);
            this.tbCustomerSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerSearch.Name = "tbCustomerSearch";
            this.tbCustomerSearch.Size = new System.Drawing.Size(231, 28);
            this.tbCustomerSearch.TabIndex = 79;
            // 
            // btnBackViewCust
            // 
            this.btnBackViewCust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackViewCust.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBackViewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackViewCust.Location = new System.Drawing.Point(918, 661);
            this.btnBackViewCust.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackViewCust.Name = "btnBackViewCust";
            this.btnBackViewCust.Size = new System.Drawing.Size(172, 45);
            this.btnBackViewCust.TabIndex = 88;
            this.btnBackViewCust.Text = "BACK";
            this.btnBackViewCust.UseVisualStyleBackColor = false;
            // 
            // customerGridView
            // 
            this.customerGridView.AutoGenerateColumns = false;
            this.customerGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.custFirstNameDataGridViewTextBoxColumn,
            this.custLastNameDataGridViewTextBoxColumn,
            this.custCompanyNameDataGridViewTextBoxColumn,
            this.custPhoneNumDataGridViewTextBoxColumn,
            this.custAddressDataGridViewTextBoxColumn,
            this.custAddLine2DataGridViewTextBoxColumn,
            this.custCountyDataGridViewTextBoxColumn});
            this.customerGridView.DataSource = this.customerBindingSource;
            this.customerGridView.GridColor = System.Drawing.SystemColors.Control;
            this.customerGridView.Location = new System.Drawing.Point(23, 122);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.Size = new System.Drawing.Size(507, 507);
            this.customerGridView.TabIndex = 89;
            // 
            // stldb1DataSet
            // 
            this.stldb1DataSet.DataSetName = "stldb1DataSet";
            this.stldb1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.stldb1DataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custFirstNameDataGridViewTextBoxColumn
            // 
            this.custFirstNameDataGridViewTextBoxColumn.DataPropertyName = "custFirstName";
            this.custFirstNameDataGridViewTextBoxColumn.HeaderText = "custFirstName";
            this.custFirstNameDataGridViewTextBoxColumn.Name = "custFirstNameDataGridViewTextBoxColumn";
            // 
            // custLastNameDataGridViewTextBoxColumn
            // 
            this.custLastNameDataGridViewTextBoxColumn.DataPropertyName = "custLastName";
            this.custLastNameDataGridViewTextBoxColumn.HeaderText = "custLastName";
            this.custLastNameDataGridViewTextBoxColumn.Name = "custLastNameDataGridViewTextBoxColumn";
            // 
            // custCompanyNameDataGridViewTextBoxColumn
            // 
            this.custCompanyNameDataGridViewTextBoxColumn.DataPropertyName = "custCompanyName";
            this.custCompanyNameDataGridViewTextBoxColumn.HeaderText = "custCompanyName";
            this.custCompanyNameDataGridViewTextBoxColumn.Name = "custCompanyNameDataGridViewTextBoxColumn";
            // 
            // custPhoneNumDataGridViewTextBoxColumn
            // 
            this.custPhoneNumDataGridViewTextBoxColumn.DataPropertyName = "custPhoneNum";
            this.custPhoneNumDataGridViewTextBoxColumn.HeaderText = "custPhoneNum";
            this.custPhoneNumDataGridViewTextBoxColumn.Name = "custPhoneNumDataGridViewTextBoxColumn";
            // 
            // custAddressDataGridViewTextBoxColumn
            // 
            this.custAddressDataGridViewTextBoxColumn.DataPropertyName = "custAddress";
            this.custAddressDataGridViewTextBoxColumn.HeaderText = "custAddress";
            this.custAddressDataGridViewTextBoxColumn.Name = "custAddressDataGridViewTextBoxColumn";
            // 
            // custAddLine2DataGridViewTextBoxColumn
            // 
            this.custAddLine2DataGridViewTextBoxColumn.DataPropertyName = "custAddLine2";
            this.custAddLine2DataGridViewTextBoxColumn.HeaderText = "custAddLine2";
            this.custAddLine2DataGridViewTextBoxColumn.Name = "custAddLine2DataGridViewTextBoxColumn";
            // 
            // custCountyDataGridViewTextBoxColumn
            // 
            this.custCountyDataGridViewTextBoxColumn.DataPropertyName = "custCounty";
            this.custCountyDataGridViewTextBoxColumn.HeaderText = "custCounty";
            this.custCountyDataGridViewTextBoxColumn.Name = "custCountyDataGridViewTextBoxColumn";
            // 
            // ViewCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1112, 728);
            this.Controls.Add(this.customerGridView);
            this.Controls.Add(this.btnBackViewCust);
            this.Controls.Add(this.gbCustomerDetails);
            this.Controls.Add(this.btnAddCustomerViewCust);
            this.Controls.Add(this.tbCustomerSearch);
            this.Controls.Add(this.btnEditCustomerViewCust);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteCustomerViewCust);
            this.Name = "ViewCustomerDetails";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "View Customer Details";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ViewCustomerDetails_Load);
            this.gbCustomerDetails.ResumeLayout(false);
            this.gbCustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stldb1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmailViewCust;
        private System.Windows.Forms.GroupBox gbCustomerDetails;
        private System.Windows.Forms.Label lblCustIDViewCust;
        private System.Windows.Forms.Label lblPhoneNoViewCust;
        private System.Windows.Forms.Label lblCusSurnameViewCust;
        private System.Windows.Forms.Label lblAddress2ViewCust;
        private System.Windows.Forms.Label lblAddress1ViewCust;
        private System.Windows.Forms.Label lblAddress3ViewCust;
        private System.Windows.Forms.Label lblCustFirstNameViewCust;
        private System.Windows.Forms.Label lblCompNameViewCust;
        private System.Windows.Forms.Button btnAddCustomerViewCust;
        private System.Windows.Forms.Button btnEditCustomerViewCust;
        private System.Windows.Forms.Button btnDeleteCustomerViewCust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCustomerSearch;
        private System.Windows.Forms.Button btnBackViewCust;
        private System.Windows.Forms.DataGridView customerGridView;
        private stldb1DataSet stldb1DataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private stldb1DataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custCompanyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPhoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAddLine2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custCountyDataGridViewTextBoxColumn;
    }
}