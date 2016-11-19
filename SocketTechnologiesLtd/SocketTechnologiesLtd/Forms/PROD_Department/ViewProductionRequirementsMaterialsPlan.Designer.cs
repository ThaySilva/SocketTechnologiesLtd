namespace SocketTechnologiesLtd
{
    partial class ViewProductionRequirementsMaterialsPlan
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lvPMRP = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.matName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(23, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PMRP Production Schedule Selected: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lvPMRP
            // 
            this.lvPMRP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.quantity,
            this.matName});
            this.lvPMRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPMRP.FullRowSelect = true;
            this.lvPMRP.GridLines = true;
            this.lvPMRP.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPMRP.HideSelection = false;
            this.lvPMRP.Location = new System.Drawing.Point(23, 101);
            this.lvPMRP.MultiSelect = false;
            this.lvPMRP.Name = "lvPMRP";
            this.lvPMRP.ShowItemToolTips = true;
            this.lvPMRP.Size = new System.Drawing.Size(459, 257);
            this.lvPMRP.TabIndex = 2;
            this.lvPMRP.UseCompatibleStateImageBehavior = false;
            this.lvPMRP.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Material ID";
            this.id.Width = 133;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.Width = 113;
            // 
            // matName
            // 
            this.matName.Text = "Material Name";
            this.matName.Width = 309;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "EDIT QUANTITY";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "ISSUE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(513, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "SAVE AND EXIT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ViewProductionRequirementsMaterialsPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 403);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvPMRP);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ViewProductionRequirementsMaterialsPlan";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "View PMRP";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView lvPMRP;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader matName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}