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
    public partial class PurDep_Form : MetroFramework.Forms.MetroForm
    {
        public PurDep_Form()
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

        private void btn_PurWeeklyReport_Click(object sender, EventArgs e)
        {
            this.btn_Logout.Hide();
            this.btn_Exit.Show();
            this.PurWeeklyReportsPanel.Show();

        }

        private void btn_ManageQuotations_Click(object sender, EventArgs e)
        {
            this.btn_Logout.Hide();
            this.btn_Exit.Show();
            this.ManageQuotationPanel.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.btn_Exit.Hide();
            this.btn_Logout.Show();
            this.PurWeeklyReportsPanel.Hide();
            this.ManageQuotationPanel.Hide();
        }

        private void btn_CreateRFQO_Click(object sender, EventArgs e)
        {
            RfQO_Form rfqo = new RfQO_Form();
            rfqo.Show();
        }
    }
}
