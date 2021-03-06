﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessEntities;
using DataAccessLayer;
using SocketTechnologiesLtd.Forms.CS_Department;

namespace SocketTechnologiesLtd
{
    public partial class CSDep_Form : MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private IModel model;
        #endregion

        #region Constructors
        public CSDep_Form(IModel _Model)
        {
            InitializeComponent();
            this.ControlBox = false;
            model = _Model;
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

        private void btn_CreateRfQ_Click(object sender, EventArgs e)
        {
            RfQ_Form rfq = new RfQ_Form(model);
            rfq.MdiParent = this.MdiParent;
            rfq.Dock = DockStyle.Fill;
            rfq.Show();
        }

        private void btn_CreateQO_Click(object sender, EventArgs e)
        {
            QO_Form qo = new QO_Form(model);
            qo.MdiParent = this.MdiParent;
            qo.Dock = DockStyle.Fill;
            qo.Show();
        }

        private void btn_CreateTE_Click(object sender, EventArgs e)
        {
            TE_Form te = new TE_Form(model);
            te.setFields("Purchase Order ID:", "3","Standard Parts:", "2");
            te.MdiParent = this.MdiParent;
            te.Dock = DockStyle.Fill;
            te.Show();
        }

        private void btn_CreateRTQ_Click(object sender, EventArgs e)
        {
            RtQ_Form rtq = new RtQ_Form(model);
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
            FSRequest_Form fsr = new FSRequest_Form(model);
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

        private void btn_CreateCPO_Click_1(object sender, EventArgs e)
        {
            Cust_Purchase_Order cpr = new Cust_Purchase_Order(model);
            cpr.MdiParent = this.MdiParent;
            cpr.Dock = DockStyle.Fill;
            cpr.Show();
        }

        private void btn_ViewRGARes_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_CreateRGAR_Click(object sender, EventArgs e)
        {
            RGA_RequestFrom rga = new RGA_RequestFrom(model);
            rga.MdiParent = this.MdiParent;
            rga.Dock = DockStyle.Fill;
            rga.Show();
        }

        private void btn_CSManageCustomers_Click(object sender, EventArgs e)
        {
            ViewCustomerDetails vcd = new ViewCustomerDetails(model);
            vcd.MdiParent = this.MdiParent;
            vcd.Dock = DockStyle.Fill;
            vcd.Show();

        }

        private void btn_ViewTERes_Click(object sender, EventArgs e)
        {
            ViewTecnicalEnquiriesResponse ter = new ViewTecnicalEnquiriesResponse(model);
            ter.MdiParent = this.MdiParent;
            ter.Dock = DockStyle.Fill;
            ter.Show();
        }



        #endregion

        #region Destructors
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
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


        #endregion

        private void btn_ViewCOS_Click(object sender, EventArgs e)
        {
            Customer_Order_Status cos = new Customer_Order_Status(model);
            cos.MdiParent = this.MdiParent;
            cos.Dock = DockStyle.Fill;
            cos.Show();
        }
    }
}
