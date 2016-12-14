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
            RtQ rtq = new RtQ(rtqId, txt_CustomerName.Text, txt_custAdd.Text, rfqId.ToString(), txt_rtqTxt.Text, txt_customItems.Text, contact);
            string form = "";
            PDF_Preview viewer = new PDF_Preview(form);
            viewer.MdiParent = this.MdiParent;
            viewer.Show();
            this.Close();
            deleteFile(filePath);
            documents.Clear();
        }
        #endregion

        #region Destructors
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            documents.Clear();
            deleteFile(filePath);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            documents.Clear();
            deleteFile(filePath);
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

            string text = "";
            string custom = "";
            for (int i = 0; i < pdfText.Length; i++)
            {
                text = pdfText.Split('\n')[i];
                if (text == "CUSTOM ITEMS")
                {
                    for (int j = i; j < pdfText.Length; j++)
                    {
                        text = pdfText.Split('\n')[j];
                        if (text == "Custom Part Name Specifications Quantity")
                        {
                            j++;
                            while (text != " ")
                            {
                                text = pdfText.Split('\n')[j];
                                custom += pdfText.Split('\n')[j] + "\r\n";
                                j++;
                            }
                            break;
                        }
                    }
                    break;
                }
            }
            txt_customItems.Text = custom;

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

        private void deleteFile(string path)
        {
            if (path != "")
            {
                File.Delete(path);
            }
        }
        #endregion
    }
}
