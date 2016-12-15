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
using System.IO;
using DataAccessLayer;

namespace SocketTechnologiesLtd
{
    public partial class PDF_Preview : MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private static IDataLayer _data = DataLayer.GetInstance();
        private static IModel model = Model.GetInstance(_data);

        Common_Rules rules = new Common_Rules();
        string formName = "";
        string reference = "";
        string custId = "";
        string text = "";
        #endregion

        #region Constructors
        public PDF_Preview(string[] form)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.TopMost = true;

            if (form != null)
            {
                formName = form[0];
                reference = form[1];
                custId = form[2];
                text = form[3];
            }

            LoadPDF(rules.getPdfPath(), rules.getPdfName());
        }

        public void LoadPDF(string path, string name)
        {
            pdfViewer.LoadFile(path);
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string path = rules.uploadFile();
            MessageBox.Show("Report successfully created!");
            File.Delete(path);
            CallForm(formName);
            this.Close();
        }

        private void CallForm(string form)
        {
            switch (form)
            {
                case "Technical Enquiry":
                    TE_Form te = new TE_Form(model);
                    //te.txt_TEtext.Text = text;
                    te.MdiParent = this.MdiParent;
                    te.Dock = DockStyle.Fill;
                    te.Show();
                    break;
                case "Customer Order Enquiry":
                    COE_Form coe = new COE_Form();
                    coe.MdiParent = this.MdiParent;
                    coe.Dock = DockStyle.Fill;
                    coe.Show();
                    break;
                case "Returned Goods":
                    RGA_RequestFrom rga = new RGA_RequestFrom(model);
                    rga.MdiParent = this.MdiParent;
                    rga.Dock = DockStyle.Fill;
                    rga.Show();
                    break;
            }
        }
        #endregion

        #region Destructors
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
