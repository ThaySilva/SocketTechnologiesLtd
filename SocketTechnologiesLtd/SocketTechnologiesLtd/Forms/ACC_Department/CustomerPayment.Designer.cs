namespace SocketTechnologiesLtd
{
    partial class CustomerPayment
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
            this.lvOrderList = new System.Windows.Forms.ListView();
            this.invoiceID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paymentDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvOrderList
            // 
            this.lvOrderList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvOrderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.invoiceID,
            this.CustName,
            this.total,
            this.paymentDate});
            this.lvOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOrderList.GridLines = true;
            this.lvOrderList.LabelWrap = false;
            this.lvOrderList.Location = new System.Drawing.Point(22, 63);
            this.lvOrderList.Margin = new System.Windows.Forms.Padding(2);
            this.lvOrderList.Name = "lvOrderList";
            this.lvOrderList.Size = new System.Drawing.Size(503, 232);
            this.lvOrderList.TabIndex = 104;
            this.lvOrderList.UseCompatibleStateImageBehavior = false;
            this.lvOrderList.View = System.Windows.Forms.View.Details;
            this.lvOrderList.SelectedIndexChanged += new System.EventHandler(this.lvOrderList_SelectedIndexChanged);
            // 
            // invoiceID
            // 
            this.invoiceID.Tag = "";
            this.invoiceID.Text = "Invoice ID";
            this.invoiceID.Width = 110;
            // 
            // CustName
            // 
            this.CustName.Text = "Customer ID";
            this.CustName.Width = 135;
            // 
            // total
            // 
            this.total.Text = "Total";
            this.total.Width = 80;
            // 
            // paymentDate
            // 
            this.paymentDate.Text = "Payment Date";
            this.paymentDate.Width = 177;
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(554, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 231);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 41);
            this.button1.TabIndex = 106;
            this.button1.Text = "PAY NOW";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CustomerPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 364);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvOrderList);
            this.Name = "CustomerPayment";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Customer Payment";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.CustomerPayment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvOrderList;
        private System.Windows.Forms.ColumnHeader invoiceID;
        private System.Windows.Forms.ColumnHeader CustName;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader paymentDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}