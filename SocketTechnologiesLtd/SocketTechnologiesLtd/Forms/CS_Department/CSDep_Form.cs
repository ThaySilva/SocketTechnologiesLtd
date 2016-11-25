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
    public partial class CSDep_Form : MetroFramework.Forms.MetroForm
    {
        public CSDep_Form()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.btn_CSExit.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CSRequests_Click(object sender, EventArgs e)
        {
            btn_Logout.Hide();
            btn_CSExit.Show();
            CSRequestsPanel.Show();
        }

        private void btn_CSResponses_Click(object sender, EventArgs e)
        {
            this.btn_Logout.Hide();
            this.btn_CSExit.Show();
            this.CSResponsesPanel.Show();
        }

        private void btn_CSWeeklyReports_Click(object sender, EventArgs e)
        {
            CS_WeeklyReport csWeeklyReport = new CS_WeeklyReport();
            csWeeklyReport.Show();
        }

        private void btn_CSManagaCustomerOrder_Click(object sender, EventArgs e)
        {
            this.btn_Logout.Hide();
            this.btn_CSExit.Show();
            this.CSManageCustomerOrdersPanel.Show();
        }

        private void btn_CSManageScrapNote_Click(object sender, EventArgs e)
        {
            this.btn_Logout.Hide();
            this.btn_CSExit.Show();
            this.CSManageScrapPanel.Show();
        }

        private void btn_ManageQuotations_Click(object sender, EventArgs e)
        {
            this.btn_Logout.Hide();
            this.btn_CSExit.Show();
            this.CSManageQuotation.Show();
        }

        private void btn_CSExit_Click(object sender, EventArgs e)
        {
            this.CSRequestsPanel.Hide();
            this.CSResponsesPanel.Hide();
            this.CSManageCustomerOrdersPanel.Hide();
            this.CSManageScrapPanel.Hide();
            this.CSManageQuotation.Hide();
            this.CSHomeScreenPanel.Show();
            this.btn_CSExit.Hide();
            this.btn_Logout.Show();
        }

        private void btn_CreateRfQ_Click(object sender, EventArgs e)
        {
            RfQ_Form rfq = new RfQ_Form();
            rfq.MdiParent = this.MdiParent;
            rfq.Dock = DockStyle.Fill;
            rfq.Show();
        }

        private void btn_CreateQO_Click(object sender, EventArgs e)
        {
            QO_Form qo = new QO_Form();
            qo.MdiParent = this.MdiParent;
            qo.Dock = DockStyle.Fill;
            qo.Show();
        }

        private void btn_CreateTE_Click(object sender, EventArgs e)
        {
            TE_Form te = new TE_Form();
            te.MdiParent = this.MdiParent;
            te.Dock = DockStyle.Fill;
            te.Show();
        }

        private void btn_CreateRTQ_Click(object sender, EventArgs e)
        {
            RtQ_Form rtq = new RtQ_Form();
            rtq.MdiParent = this.MdiParent;
            rtq.Dock = DockStyle.Fill;
            rtq.Show();
        }

        private void btn_CreateCOE_Click(object sender, EventArgs e)
        {
            COE_Form coe = new COE_Form();
            coe.MdiParent = this.MdiParent;
            coe.Dock = DockStyle.Fill;
            coe.Show();
        }

        private void btn_CreateCCN_Click(object sender, EventArgs e)
        {
            CusCreditNote cn = new CusCreditNote();
            cn.MdiParent = this.MdiParent;
            cn.Dock = DockStyle.Fill;
            cn.Show();
        }

        private void btn_CreateFSR_Click(object sender, EventArgs e)
        {
            FSRequest_Form fsr = new FSRequest_Form();
            fsr.MdiParent = this.MdiParent;
            fsr.Dock = DockStyle.Fill;
            fsr.Show();
        }

        private void btn_CreateSN_Click(object sender, EventArgs e)
        {

            createScrapNote sN = new createScrapNote();
            sN.MdiParent = this.MdiParent;
            sN.Dock = DockStyle.Fill;
            sN.Show();

        }

    }
}
