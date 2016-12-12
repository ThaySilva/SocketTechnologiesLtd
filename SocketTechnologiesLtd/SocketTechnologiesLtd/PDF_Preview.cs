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

namespace SocketTechnologiesLtd
{
    public partial class PDF_Preview : MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private IModel model;
        Common_Rules rules = new Common_Rules();
        #endregion

        #region Constructors
        public PDF_Preview(IModel _Model)
        {
            InitializeComponent();
            this.ControlBox = false;
            model = _Model;

            LoadPDF(rules.getPdfPath(), rules.getPdfName());
        }

        public void LoadPDF(string path, string name)
        {
            pdfViewer.LoadFile(path);
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string path = rules.uploadFile();
            MessageBox.Show("Refusal to quote successfully created!");
            File.Delete(path);
            this.Close();
        }
        #endregion

        #region Destructors
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
