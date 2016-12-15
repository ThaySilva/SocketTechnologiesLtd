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
using System.IO;

namespace SocketTechnologiesLtd
{
    public partial class TE_Form : MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private IModel model;
        IdIncrement id = new IdIncrement();
        int TE_id;
        List<IDocument> documents;
        List<ICustomer> customers;
        List<IProduct> custom;
        List<IProduct> standard;
        #endregion

        #region Constructors
        public TE_Form(IModel _Model)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            model = _Model;

            model.FillDocumentList("TechnicalEnquiry_Report", false);
            documents = model.DocumentList;
            customers = model.CustomerList;
            custom = model.CustomProductList;
            standard = model.ProductList;


            TE_id = id.getReportID("TechnicalEnquiry_Report");
            txt_TEId.Text = TE_id.ToString();
        }
        #endregion

        #region Destructors
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Extra Functions
        public void setFields(string reference, string refId, string parts, string custId)
        {
            lbl_reference.Text = reference;
            txt_referenceId.Text = refId;
            lbl_parts.Text = parts;
            txt_customerId.Text = custId;

            fillFields(int.Parse(custId));

            if (lbl_parts.Text == "Custom Parts")
            {
                loadParts(custom);
            }
            else
                loadParts(standard);
        }

        private void fillFields(int custId)
        {
            foreach(Customer cust in customers)
            {
                if(cust.Customer_ID == custId)
                {
                    txt_CutomerName.Text = cust.CustCompanyName;
                    txt_CustomerAdd.Text = cust.CustAddress[0] + ",\r\n" + cust.CustAddress[1] + ",\r\n" + cust.CustAddress[2];
                }
            }
        }

        private void loadParts(List<IProduct> type)
        {
            DataTable Products = new DataTable("Product");

            DataColumn c0 = new DataColumn("Product ID:");
            DataColumn c1 = new DataColumn("Product Name:");
            DataColumn c2 = new DataColumn("Product Description:");

            Products.Columns.Add(c0);
            Products.Columns.Add(c1);
            Products.Columns.Add(c2);

            DataRow row;

            foreach (Product prod in type)
            {
                row = Products.NewRow();

                row["Product ID:"] = prod.ProductId.ToString();
                row["Product Name:"] = prod.ProductName;
                row["Product Description:"] = prod.ProductDescription;

            }

            dataView_parts.DataSource = Products;
        }
        #endregion
    }
}
