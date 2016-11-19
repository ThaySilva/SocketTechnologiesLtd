namespace SocketTechnologiesLtd
{
    partial class SelectEmployee
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
            this.ExitmetroTile1 = new MetroFramework.Controls.MetroTile();
            this.FirstNamemetroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.FirstNamemetroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.SurnamemetroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SurnamemetroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.SearchmetroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // ExitmetroTile1
            // 
            this.ExitmetroTile1.Location = new System.Drawing.Point(314, 136);
            this.ExitmetroTile1.Name = "ExitmetroTile1";
            this.ExitmetroTile1.Size = new System.Drawing.Size(103, 43);
            this.ExitmetroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.ExitmetroTile1.TabIndex = 0;
            this.ExitmetroTile1.Text = "Exit";
            this.ExitmetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitmetroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ExitmetroTile1.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ExitmetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // FirstNamemetroLabel1
            // 
            this.FirstNamemetroLabel1.AutoSize = true;
            this.FirstNamemetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.FirstNamemetroLabel1.Location = new System.Drawing.Point(44, 92);
            this.FirstNamemetroLabel1.Name = "FirstNamemetroLabel1";
            this.FirstNamemetroLabel1.Size = new System.Drawing.Size(75, 19);
            this.FirstNamemetroLabel1.TabIndex = 1;
            this.FirstNamemetroLabel1.Text = "First Name";
            this.FirstNamemetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FirstNamemetroTextBox1
            // 
            this.FirstNamemetroTextBox1.Location = new System.Drawing.Point(125, 88);
            this.FirstNamemetroTextBox1.Name = "FirstNamemetroTextBox1";
            this.FirstNamemetroTextBox1.Size = new System.Drawing.Size(142, 23);
            this.FirstNamemetroTextBox1.TabIndex = 2;
            // 
            // SurnamemetroLabel1
            // 
            this.SurnamemetroLabel1.AutoSize = true;
            this.SurnamemetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SurnamemetroLabel1.Location = new System.Drawing.Point(287, 92);
            this.SurnamemetroLabel1.Name = "SurnamemetroLabel1";
            this.SurnamemetroLabel1.Size = new System.Drawing.Size(63, 19);
            this.SurnamemetroLabel1.TabIndex = 3;
            this.SurnamemetroLabel1.Text = "Surname";
            this.SurnamemetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SurnamemetroTextBox1
            // 
            this.SurnamemetroTextBox1.Location = new System.Drawing.Point(356, 88);
            this.SurnamemetroTextBox1.Name = "SurnamemetroTextBox1";
            this.SurnamemetroTextBox1.Size = new System.Drawing.Size(170, 23);
            this.SurnamemetroTextBox1.TabIndex = 4;
            // 
            // SearchmetroTile1
            // 
            this.SearchmetroTile1.Location = new System.Drawing.Point(423, 136);
            this.SearchmetroTile1.Name = "SearchmetroTile1";
            this.SearchmetroTile1.Size = new System.Drawing.Size(103, 43);
            this.SearchmetroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.SearchmetroTile1.TabIndex = 5;
            this.SearchmetroTile1.Text = "Search";
            this.SearchmetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchmetroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SearchmetroTile1.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.SearchmetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // SelectEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 218);
            this.Controls.Add(this.SearchmetroTile1);
            this.Controls.Add(this.SurnamemetroTextBox1);
            this.Controls.Add(this.SurnamemetroLabel1);
            this.Controls.Add(this.FirstNamemetroTextBox1);
            this.Controls.Add(this.FirstNamemetroLabel1);
            this.Controls.Add(this.ExitmetroTile1);
            this.Name = "SelectEmployee";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Search Employee";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.SelectEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile ExitmetroTile1;
        private MetroFramework.Controls.MetroLabel FirstNamemetroLabel1;
        private MetroFramework.Controls.MetroTextBox FirstNamemetroTextBox1;
        private MetroFramework.Controls.MetroLabel SurnamemetroLabel1;
        private MetroFramework.Controls.MetroTextBox SurnamemetroTextBox1;
        private MetroFramework.Controls.MetroTile SearchmetroTile1;
    }
}