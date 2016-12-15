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
using System.IO;

namespace SocketTechnologiesLtd
{
    public partial class RtQ_Form : MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private IModel model;
        IdIncrement id = new IdIncrement();
        List<ICustomer> customers;
        List<IDocument> documents;
        List<IProduct> customParts;
        string rtqId = "";
        string fileId = "";
        int rfqId;
        string custName = "";
        string custAdd = "";
        string contact = "";
        string filePath = "";
        #endregion

        #region Constructors
        public RtQ_Form(IModel _Model)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            model = _Model;

            model.FillDocumentList("RequestForQuotation_Report", false);
            documents = model.DocumentList;
            customers = model.CustomerList;
            customParts = model.CustomProductList;
            fillComboBox();

            rtqId = Convert.ToString(id.getReportID("RefusalToQuote_Report"));
            txt_RtQId.Text = rtqId;
        }

        private void comboBox_rfq_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text;
            rfqId = Convert.ToInt16(comboBox_rfq.SelectedItem);
            fileId = getFileId(rfqId);
            Common_Rules.setDownload(fileId, "..\\..\\Reports\\Rfq" + rfqId + ".pdf");
            filePath = Common_Rules.downloadFile();
            if(filePath != null)
            {
                Pdf_Reader reader = new Pdf_Reader();
                text = reader.readPdf(filePath);

                fillFields(text);
            }
            else
                MessageBox.Show("There are no Request for quotations in need of attention.");
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            RtQ rtq = new RtQ(rtqId, txt_CustomerName.Text, txt_custAdd.Text, rfqId.ToString(), txt_rtqTxt.Text, lst_customItems, contact);
            Common_Rules.UpdateDocumentResponse("RequestForQuotation_Report", rfqId.ToString());
            string[] form = null;
            PDF_Preview viewer = new PDF_Preview(form);
            viewer.Text = "Refusal to Quote";
            viewer.MdiParent = this.MdiParent;
            viewer.Show();
            this.Close();
            documents.Clear();
        }
        #endregion

        #region Destructors
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            documents.Clear();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            documents.Clear();
        }
        #endregion

        #region Extra Functions
        public void fillComboBox()
        {
            int i = 0;
            string[] docsItem = new string[documents.Count];
            foreach(Document doc in documents)
            {
                docsItem[i] = doc.DocumentID.ToString();
                i++;
            }
            comboBox_rfq.Items.AddRange(docsItem);
        }

        public string getFileId(int id)
        {
            foreach(Document doc in documents)
            {
                if(id == doc.DocumentID)
                {
                    fileId = doc.DocumentPath;
                }
            }

            return fileId;
        }

        public void fillFields(string pdfText)
        {
            custName = pdfText.Split('\n')[1];
            custName = custName.Substring(0, custName.Length - 1);
            txt_CustomerName.Text = custName;

            custAdd = pdfText.Split('\n')[2];
            custAdd += pdfText.Split('\n')[3];
            custAdd += pdfText.Split('\n')[4];
            txt_custAdd.Text = custAdd;

            DataTable Products = new DataTable("Products");

            DataColumn p0 = new DataColumn("Custom Part Name:");
            DataColumn p1 = new DataColumn("Specifications:");
            DataColumn p2 = new DataColumn("Quantity:");

            Products.Columns.Add(p0);
            Products.Columns.Add(p1);
            Products.Columns.Add(p2);

            DataRow pRow;

            foreach (Product custom in customParts)
            {
                pRow = Products.NewRow();

                if (rfqId == custom.RFQ_ID)
                {  
                    pRow["Custom Part Name:"] = custom.ProductName;
                    pRow["Specifications:"] = custom.ProductDescription;
                    pRow["Quantity:"] = custom.Quantity.ToString();

                    Products.Rows.Add(pRow);
                }
            }

            lst_customItems.DataSource = Products;

            string text = "";
            for(int k = 0; k < pdfText.Length; k++)
            {
                text = pdfText.Split('\n')[k];
                if(text == "__________________________________")
                {
                    contact = pdfText.Split('\n')[k + 1];
                    break;
                }
            }
        }
        #endregion
    }
}
