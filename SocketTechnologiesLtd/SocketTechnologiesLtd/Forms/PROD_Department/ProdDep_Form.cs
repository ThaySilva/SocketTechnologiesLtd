using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketTechnologiesLtd
{
    public partial class ProdDep_Form : MetroFramework.Forms.MetroForm
    {
        public ProdDep_Form()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            this.btn_Exit.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ProdWeeklyReports_Click(object sender, EventArgs e)
        {
            this.btn_Logout.Hide();
            this.btn_Exit.Show();
            this.ProdWeeklyReportsPanel.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.btn_Exit.Hide();
            this.btn_Logout.Show();
            this.ProdWeeklyReportsPanel.Hide();
        }

        private void btn_CreateFGTN_Click(object sender, EventArgs e)
        {
            FGTN_Form fgtn = new FGTN_Form();
            fgtn.Show();
        }
    }
}
