﻿using System;
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
    public partial class ManDep_Form : MetroFramework.Forms.MetroForm
    {
        public ManDep_Form()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.btn_Exit.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ManViewReports_Click(object sender, EventArgs e)
        {
            this.btn_Logout.Hide();
            this.btn_Exit.Show();
            this.ManWeeklyReportsPanel.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.btn_Logout.Show();
            this.btn_Exit.Hide();
            this.ManWeeklyReportsPanel.Hide();
        }

        private void btn_CreateMRBR_Click(object sender, EventArgs e)
        {
            MRBReport_Form mrb = new MRBReport_Form();
            mrb.MdiParent = this.MdiParent;
            mrb.Dock = DockStyle.Fill;
            mrb.Show();
        }

        private void btn_SPARes_Click(object sender, EventArgs e)
        {
            SPARes_Form spares = new SPARes_Form();
            spares.MdiParent = this.MdiParent;
            spares.Dock = DockStyle.Fill;
            spares.Show();
        }

        private void btn_CreateRGARes_Click(object sender, EventArgs e)
        {
            RGA_Response rga = new RGA_Response();
            rga.MdiParent = this.MdiParent;
            rga.Dock = DockStyle.Fill;
            rga.Show();
        }
    }
}
