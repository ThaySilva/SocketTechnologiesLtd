using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentWriter;
using BusinessLayer;
using BusinessEntities;

namespace SocketTechnologiesLtd
{
    public partial class RtQ_Form : MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private IModel model;
        List<ICustomer> customers;
        #endregion

        public RtQ_Form(IModel _Model)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            model = _Model;

            //rtqId = "2";

            //txt_RtQId.Text = rtqId;
            txt_CustomerName.Text = "Cork Cyber Computing Ltd.";
            txt_custAdd.Text = "Cork Business Park, \nModel Farm Road., \nCork.";
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            //custName = txt_CustomerName.Text;
            //custAdd = txt_custAdd.Text;
            //rfqId = txt_RfQId.Text;
            //txt = txt_rtqTxt.Text;

            //RtQ rtq = new RtQ(rtqId, custName, custAdd, rfqId, txt, lst_customItems);
            PDF_Preview viewer = new PDF_Preview(model);
            viewer.MdiParent = this.MdiParent;
            viewer.Show();
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
