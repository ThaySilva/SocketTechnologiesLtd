namespace SocketTechnologiesLtd
{
    partial class ConfirmAddNewEmployee
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
            this.AddNewEmployeemetroTile1 = new MetroFramework.Controls.MetroTile();
            this.returnMainmetroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // AddNewEmployeemetroTile1
            // 
            this.AddNewEmployeemetroTile1.Location = new System.Drawing.Point(124, 102);
            this.AddNewEmployeemetroTile1.Name = "AddNewEmployeemetroTile1";
            this.AddNewEmployeemetroTile1.Size = new System.Drawing.Size(136, 70);
            this.AddNewEmployeemetroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.AddNewEmployeemetroTile1.TabIndex = 0;
            this.AddNewEmployeemetroTile1.Text = "Add New Employee";
            this.AddNewEmployeemetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddNewEmployeemetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // returnMainmetroTile1
            // 
            this.returnMainmetroTile1.Location = new System.Drawing.Point(266, 102);
            this.returnMainmetroTile1.Name = "returnMainmetroTile1";
            this.returnMainmetroTile1.Size = new System.Drawing.Size(136, 70);
            this.returnMainmetroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.returnMainmetroTile1.TabIndex = 1;
            this.returnMainmetroTile1.Text = "Return Main Menu";
            this.returnMainmetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.returnMainmetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // ConfirmAddNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 246);
            this.Controls.Add(this.returnMainmetroTile1);
            this.Controls.Add(this.AddNewEmployeemetroTile1);
            this.Name = "ConfirmAddNewEmployee";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Employee Added";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ConfirmAddNewEmployee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile AddNewEmployeemetroTile1;
        private MetroFramework.Controls.MetroTile returnMainmetroTile1;
    }
}