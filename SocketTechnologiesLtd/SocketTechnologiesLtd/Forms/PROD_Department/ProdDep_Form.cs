using System;
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

namespace SocketTechnologiesLtd
{
    public partial class ProdDep_Form : MetroFramework.Forms.MetroForm
    {

        #region Instance Attributes
        private IModel model;
        #endregion

        public ProdDep_Form(IModel _Model)
        {
            InitializeComponent();
            this.ControlBox = false;
            model = _Model;
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
            fgtn.MdiParent = this.MdiParent;
            fgtn.Dock = DockStyle.Fill;
            fgtn.Show();
        }

        private void btn_ManageProduct_Click(object sender, EventArgs e)
        {
            Edit_DeleteProduct p = new Edit_DeleteProduct(model);
            p.MdiParent = this.MdiParent;
            p.Dock = DockStyle.Fill;
            p.Show();

        }

        private void btn_ProcessWorkOrder_Click(object sender, EventArgs e)
        {
            Create_PMRP pmrp = new Create_PMRP(model);
            pmrp.MdiParent = this.MdiParent;
            pmrp.Dock = DockStyle.Fill;
            pmrp.Show();
        }
    }
}
