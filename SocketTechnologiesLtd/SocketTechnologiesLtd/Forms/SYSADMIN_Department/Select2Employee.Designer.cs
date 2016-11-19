namespace SocketTechnologiesLtd
{
    partial class Select2Employee
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SelectmetroTile1 = new MetroFramework.Controls.MetroTile();
            this.ReturnmetroTile1 = new MetroFramework.Controls.MetroTile();
            this.ExitmetroTile2 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(89, 97);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(361, 167);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // SelectmetroTile1
            // 
            this.SelectmetroTile1.Location = new System.Drawing.Point(361, 270);
            this.SelectmetroTile1.Name = "SelectmetroTile1";
            this.SelectmetroTile1.Size = new System.Drawing.Size(89, 47);
            this.SelectmetroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.SelectmetroTile1.TabIndex = 1;
            this.SelectmetroTile1.Text = "Select";
            this.SelectmetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectmetroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SelectmetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // ReturnmetroTile1
            // 
            this.ReturnmetroTile1.Location = new System.Drawing.Point(266, 270);
            this.ReturnmetroTile1.Name = "ReturnmetroTile1";
            this.ReturnmetroTile1.Size = new System.Drawing.Size(89, 47);
            this.ReturnmetroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.ReturnmetroTile1.TabIndex = 2;
            this.ReturnmetroTile1.Text = "Return";
            this.ReturnmetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReturnmetroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ReturnmetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // ExitmetroTile2
            // 
            this.ExitmetroTile2.Location = new System.Drawing.Point(171, 270);
            this.ExitmetroTile2.Name = "ExitmetroTile2";
            this.ExitmetroTile2.Size = new System.Drawing.Size(89, 47);
            this.ExitmetroTile2.Style = MetroFramework.MetroColorStyle.Orange;
            this.ExitmetroTile2.TabIndex = 3;
            this.ExitmetroTile2.Text = "Exit";
            this.ExitmetroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitmetroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ExitmetroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // Select2Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 411);
            this.Controls.Add(this.ExitmetroTile2);
            this.Controls.Add(this.ReturnmetroTile1);
            this.Controls.Add(this.SelectmetroTile1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Select2Employee";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Select Employee";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Select2Employee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile SelectmetroTile1;
        private MetroFramework.Controls.MetroTile ReturnmetroTile1;
        private MetroFramework.Controls.MetroTile ExitmetroTile2;
    }
}