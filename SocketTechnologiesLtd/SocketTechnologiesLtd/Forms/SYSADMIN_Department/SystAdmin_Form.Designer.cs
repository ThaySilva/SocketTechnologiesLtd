namespace SocketTechnologiesLtd
{
    partial class SysAdmin_Form
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
            this.btn_Logout = new MetroFramework.Controls.MetroButton();
            this.PurWeeklyReportsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btn_EditUser = new MetroFramework.Controls.MetroTile();
            this.btn_AddUser = new MetroFramework.Controls.MetroTile();
            this.PurWeeklyReportsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Logout.Location = new System.Drawing.Point(867, 23);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(92, 34);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // PurWeeklyReportsPanel
            // 
            this.PurWeeklyReportsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PurWeeklyReportsPanel.ColumnCount = 3;
            this.PurWeeklyReportsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PurWeeklyReportsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.PurWeeklyReportsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.PurWeeklyReportsPanel.Controls.Add(this.btn_EditUser, 1, 2);
            this.PurWeeklyReportsPanel.Controls.Add(this.btn_AddUser, 1, 1);
            this.PurWeeklyReportsPanel.Location = new System.Drawing.Point(23, 64);
            this.PurWeeklyReportsPanel.Name = "PurWeeklyReportsPanel";
            this.PurWeeklyReportsPanel.RowCount = 4;
            this.PurWeeklyReportsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PurWeeklyReportsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PurWeeklyReportsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PurWeeklyReportsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PurWeeklyReportsPanel.Size = new System.Drawing.Size(936, 498);
            this.PurWeeklyReportsPanel.TabIndex = 24;
            // 
            // btn_EditUser
            // 
            this.btn_EditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EditUser.Location = new System.Drawing.Point(314, 251);
            this.btn_EditUser.Name = "btn_EditUser";
            this.btn_EditUser.Size = new System.Drawing.Size(306, 118);
            this.btn_EditUser.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_EditUser.TabIndex = 12;
            this.btn_EditUser.Text = "Edit/Delete User";
            this.btn_EditUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EditUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_EditUser.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditUser.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_EditUser.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_EditUser.UseTileImage = true;
            this.btn_EditUser.Click += new System.EventHandler(this.btn_EditUser_Click);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddUser.Location = new System.Drawing.Point(314, 127);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(306, 118);
            this.btn_AddUser.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_AddUser.TabIndex = 11;
            this.btn_AddUser.Text = "Add User";
            this.btn_AddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AddUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_AddUser.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddUser.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_AddUser.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_AddUser.UseTileImage = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // SysAdmin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 585);
            this.Controls.Add(this.PurWeeklyReportsPanel);
            this.Controls.Add(this.btn_Logout);
            this.Name = "SysAdmin_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "SystemAdministrator";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PurWeeklyReportsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_Logout;
        private System.Windows.Forms.TableLayoutPanel PurWeeklyReportsPanel;
        private MetroFramework.Controls.MetroTile btn_AddUser;
        private MetroFramework.Controls.MetroTile btn_EditUser;
    }
}