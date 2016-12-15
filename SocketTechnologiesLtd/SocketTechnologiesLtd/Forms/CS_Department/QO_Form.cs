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
using DocumentWriter;

namespace SocketTechnologiesLtd
{
    public partial class QO_Form : MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private IModel model;
        IdIncrement id = new IdIncrement();
        int qo_id;
        int rfq_id;
        int line_id;
        List<IDocument> documents;
        List<IProduct> products;
        List<IProduct> customProducts;
        List<IProduct> standardProducts;
        string fileId = "";
        string filePath = "";
        string custName = "";
        #endregion

        #region Constructors
        public QO_Form(IModel _Model)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            model = _Model;

            model.FillDocumentList("RequestForQuotation_Report", false);
            documents = model.DocumentList;
            products = model.ProductList;
            customProducts = model.CustomProductList;
            standardProducts = model.StandardProductList;

            qo_id = id.getReportID("QuotationOut_Report");
            rfq_id = id.getReportID("RequestForQuotation_Report");
            line_id = id.getLineItemId();

            fillComboBox();

        }

        private void comboBox_rfq_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text;
            rfq_id = Convert.ToInt16(comboBox_rfq.SelectedItem);
            fileId = getFileId(rfq_id);
            Common_Rules.setDownload(fileId, "..\\..\\Reports\\Rfq" + rfq_id + ".pdf");
            filePath = Common_Rules.downloadFile();
            if (filePath != null)
            {
                Pdf_Reader reader = new Pdf_Reader();
                text = reader.readPdf(filePath);

                fillFields(text);
            }
            else
                MessageBox.Show("There are no Request for quotations in need of attention.");
        }
        #endregion

        #region Destructors
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Extra Functions
        public void fillComboBox()
        {
            int i = 0;
            string[] docsItem = new string[documents.Count];
            foreach (Document doc in documents)
            {
                docsItem[i] = doc.DocumentID.ToString();
                i++;
            }
            comboBox_rfq.Items.AddRange(docsItem);
        }

        public string getFileId(int id)
        {
            foreach (Document doc in documents)
            {
                if (id == doc.DocumentID)
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
            txt_custName.Text = custName;

            DataTable StandardProducts = new DataTable("StandardProducts");

            DataColumn sp0 = new DataColumn("Line No.");
            DataColumn sp1 = new DataColumn("STL P/N");
            DataColumn sp2 = new DataColumn("Quantity");
            DataColumn sp3 = new DataColumn("Unit Price");
            DataColumn sp4 = new DataColumn("Line Price");
            DataColumn sp5 = new DataColumn("VAT");
            DataColumn sp6 = new DataColumn("Line Total");

            StandardProducts.Columns.Add(sp0);
            StandardProducts.Columns.Add(sp1);
            StandardProducts.Columns.Add(sp2);
            StandardProducts.Columns.Add(sp3);
            StandardProducts.Columns.Add(sp4);
            StandardProducts.Columns.Add(sp5);
            StandardProducts.Columns.Add(sp6);

            DataRow spRow;

            foreach (Product standard in standardProducts)
            {
                spRow = StandardProducts.NewRow();

                if (rfq_id == standard.RFQ_ID)
                {
                    foreach (Product prod in products)
                    {
                        if (standard.ProductId == prod.ProductId)
                        {
                            spRow["Line No."] = line_id;
                            spRow["STL P/N"] = prod.ProductId;
                            spRow["Quantity"] = standard.Quantity.ToString();
                            spRow["Unit Price"] = prod.ProductPrice.ToString();
                            double linePrice = standard.Quantity * prod.ProductPrice;
                            spRow["Line Price"] = linePrice.ToString();
                            spRow["VAT"] = prod.ProductVAT.ToString();
                            spRow["Line Total"] = (((prod.ProductPrice / prod.ProductVAT) * 100) + linePrice).ToString();

                            StandardProducts.Rows.Add(spRow);

                            line_id++;
                        }
                    }
                }
            }

            gridView_standard.DataSource = StandardProducts;

            DataTable CustomProducts = new DataTable("CustomProducts");

            DataColumn cp0 = new DataColumn("Line No.");
            DataColumn cp1 = new DataColumn("Custom P/N");
            DataColumn cp2 = new DataColumn("Quantity");
            DataColumn cp3 = new DataColumn("Unit Price");
            DataColumn cp4 = new DataColumn("Line Price");
            DataColumn cp5 = new DataColumn("VAT");
            DataColumn cp6 = new DataColumn("Line Total");

            CustomProducts.Columns.Add(cp0);
            CustomProducts.Columns.Add(cp1);
            CustomProducts.Columns.Add(cp2);
            CustomProducts.Columns.Add(cp3);
            CustomProducts.Columns.Add(cp4);
            CustomProducts.Columns.Add(cp5);
            CustomProducts.Columns.Add(cp6);

            DataRow cpRow;

            foreach (Product custom in customProducts)
            {
                cpRow = CustomProducts.NewRow();

                if (rfq_id == custom.RFQ_ID)
                {
                    foreach (Product prod in products)
                    {
                        if (custom.ProductName == prod.ProductName)
                        {
                            cpRow["Line No."] = line_id;
                            cpRow["Custom P/N"] = prod.ProductId;
                            cpRow["Quantity"] = custom.Quantity.ToString();
                            cpRow["Unit Price"] = prod.ProductPrice.ToString();
                            double linePrice = custom.Quantity * prod.ProductPrice;
                            cpRow["Line Price"] = linePrice.ToString();
                            cpRow["VAT"] = prod.ProductVAT.ToString();
                            cpRow["Line Total"] = (((prod.ProductPrice / prod.ProductVAT) * 100) + linePrice).ToString();

                            CustomProducts.Rows.Add(cpRow);

                            line_id++;
                        }
                    }
                }
            }

            gridView_custom.DataSource = CustomProducts;

            //string text = "";
            //for (int k = 0; k < pdfText.Length; k++)
            //{
            //    text = pdfText.Split('\n')[k];
            //    if (text == "__________________________________")
            //    {
            //        contact = pdfText.Split('\n')[k + 1];
            //        break;
            //    }
            //}
        }
        #endregion
    }
}
