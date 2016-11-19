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
    public partial class AccDep_Form : MetroFramework.Forms.MetroForm
    {
        public AccDep_Form()
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

        private void btn_ACCWeeklyReports_Click(object sender, EventArgs e)
        {
            this.btn_Logout.Hide();
            this.btn_Exit.Show();
            this.AccWeeklyReportsPanel.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.btn_Exit.Hide();
            this.btn_Logout.Show();
            this.AccWeeklyReportsPanel.Hide();
            this.AccManageInvoicesPanel.Hide();
        }

        private void btn_ManageInvoices_Click(object sender, EventArgs e)
        {
            this.btn_Logout.Hide();
            this.btn_Exit.Show();
            this.AccManageInvoicesPanel.Show();
        }

        private void btn_IssueCustomerInvoice_Click(object sender, EventArgs e)
        {
            InvoiceOut_Form io = new InvoiceOut_Form();
            io.Show();
        }

        private void btn_CreatePackingSlip_Click(object sender, EventArgs e)
        {
            PS_Form ps = new PS_Form();
            ps.Show();
        }
    }
}
