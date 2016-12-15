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
    public partial class RfQ_Form : MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private IModel model;
        List<ICustomer> customers;
        List<IProduct> products;
        List<IProduct> customProducts;
        int rfqId;
        IdIncrement id = new IdIncrement();
        int custId;
        Customer customer;
        int partId;
        List<IProduct> standardPart;
        List<IProduct> parts = new List<IProduct>();
        List<IProduct> customPart = new List<IProduct>();
        int amount;
        int customPartId;
        int customQty;
        string customPartName;
        string specs;
        string[] deliveryDates;
        int i;
        string contact = "";
        #endregion

        #region Constructors
        public RfQ_Form(IModel _Model)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            model = _Model;

            customers = model.CustomerList;
            products = model.ProductList;
            standardPart = model.StandardProductList;
            customProducts = model.CustomProductList;
            i = 0;

            rfqId = id.getReportID("RequestForQuotation_Report");
            customPartId = id.getCustomProdId();

            populateListViews();
        }

        #region Customer Functions
        private void btn_searchCust_Click(object sender, EventArgs e)
        {
            int id;
            bool result = int.TryParse(txt_custId.Text, out id);
            if (result)
                populateCustView(id);
            else
                MessageBox.Show("You need to enter a number on the Id field!");
        }

        private void txt_custId_Click(object sender, EventArgs e)
        {
            populateListViews();
            clearCustFields();
        }

        private void gridView_cust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            custId = Convert.ToInt16(gridView_cust.Rows[e.RowIndex].Cells["CustomerID:"].Value);
            fillFields(custId);
        }

        private void btn_selectCust_Click(object sender, EventArgs e)
        {
            foreach(Customer cust in customers)
            {
                if(custId == cust.Customer_ID)
                {
                    customer = cust;
                    btn_selectCust.Enabled = false;
                    gridView_cust.Enabled = false;
                    btn_searchCust.Enabled = false;
                }
            }
        }
        #endregion

        #region Part Functions
        private void btn_searchPart_Click(object sender, EventArgs e)
        {
            int id;
            bool result = int.TryParse(txt_partId.Text, out id);
            if (result)
                populatePartView(id);
            else
                MessageBox.Show("You need to enter a number on the Id field!"); 
        }

        private void txt_partId_Click(object sender, EventArgs e)
        {
            populateListViews();
            txt_partId.Text = null;
        }

        private void gridView_parts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            partId = Convert.ToInt16(gridView_parts.Rows[e.RowIndex].Cells["STL P/N:"].Value);
            txt_partId.Text = partId.ToString();
        }

        private void btn_addSItem_Click(object sender, EventArgs e)
        {
            bool result = int.TryParse(txt_quantity.Text, out amount);
            if (result)
            {
                foreach (Product prod in products)
                {
                    if (partId == prod.ProductId)
                    {
                        parts.Add(new Product(prod.ProductId, prod.ProductName, prod.ProductDescription, amount, rfqId));
                        standardPart.Add(new Product(prod.ProductId, prod.ProductName, prod.ProductDescription, amount, rfqId));
                        clearPartsFields();
                    }
                }
            }
            else
                MessageBox.Show("You need to enter a number on the quantity field!");
        }

        private void btn_AddCustom_Click(object sender, EventArgs e)
        {
            bool qtyResult = int.TryParse(txt_CustomQty.Text, out customQty);
            if (qtyResult)
            {
                if (txt_customPartName.Text != null && txt_CustomSpecs.Text != null)
                {

                    customPartName = txt_customPartName.Text;
                    specs = txt_CustomSpecs.Text;
                    CustServices_Rules.AddCustomProduct(customPartId, customPartName, specs, customQty, rfqId);
                    customPart.Add(new Product(customPartId, customPartName, specs, customQty, rfqId));
                    customPartId++;
                    clearCustomFields();
                }
                else
                    MessageBox.Show("You need to fill all the fields!");
            }
            else
                MessageBox.Show("You need to enter a number on the Id field!");
        }
        #endregion

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (validateDates() != null)
            {
                if (customer != null && parts != null && customPart != null)
                {
                    string[] form = null;
                    RfQ rfq = new RfQ(rfqId.ToString(), customer, parts, customPart, deliveryDates, contact);
                    PDF_Preview viewer = new PDF_Preview(form);
                    viewer.Text = "Request for Quotation";
                    viewer.MdiParent = this.MdiParent;
                    viewer.Show();
                    customPart.Clear();
                    this.Close();
                }
            }
        }

        #endregion

        #region Destructors
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            deleteCustomProduct();
            customPart.Clear();

            foreach(Product part in parts)
            {
                foreach(Product prod in standardPart)
                {
                    if (part.ProductId == prod.ProductId)
                        standardPart.Remove(part);
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            deleteCustomProduct();
            customPart.Clear();

            foreach (Product part in parts)
            {
                foreach (Product prod in standardPart)
                {
                    if (part.ProductId == prod.ProductId)
                        standardPart.Remove(part);
                }
            }
        }
        #endregion

        #region Extra Functions
        private void populateListViews()
        {
            DataTable Customers = new DataTable("Customers");

            DataColumn c0 = new DataColumn("CustomerID:");
            DataColumn c1 = new DataColumn("CustomerName:");

            Customers.Columns.Add(c0);
            Customers.Columns.Add(c1);

            DataRow cRow;

            foreach(Customer cust in customers)
            {
                cRow = Customers.NewRow();

                cRow["CustomerID:"] = cust.Customer_ID.ToString();
                cRow["CustomerName:"] = cust.CustCompanyName.ToString();

                Customers.Rows.Add(cRow);
            }

            gridView_cust.DataSource = Customers;

            DataTable Products = new DataTable("Products");

            DataColumn p0 = new DataColumn("STL P/N:");
            DataColumn p1 = new DataColumn("PartName:");

            Products.Columns.Add(p0);
            Products.Columns.Add(p1);

            DataRow pRow;

            foreach(Product prod in products)
            {
                pRow = Products.NewRow();

                pRow["STL P/N:"] = prod.ProductId.ToString();
                pRow["PartName:"] = prod.ProductName.ToString();

                Products.Rows.Add(pRow);
            }

            gridView_parts.DataSource = Products;
        }

        private void populateCustView(int custId)
        {
            DataTable Customers = new DataTable("Customers");

            DataColumn c0 = new DataColumn("CustomerID:");
            DataColumn c1 = new DataColumn("CustomerName:");

            Customers.Columns.Add(c0);
            Customers.Columns.Add(c1);

            DataRow cRow;

            foreach (Customer cust in customers)
            {
                if (cust.Customer_ID == custId)
                {
                    cRow = Customers.NewRow();

                    cRow["CustomerID:"] = cust.Customer_ID.ToString();
                    cRow["CustomerName:"] = cust.CustCompanyName.ToString();

                    Customers.Rows.Add(cRow);
                }
            }

            gridView_cust.DataSource = Customers;
        }

        private void populatePartView(int partId)
        {
            DataTable Products = new DataTable("Products");

            DataColumn p0 = new DataColumn("STL P/N:");
            DataColumn p1 = new DataColumn("PartName:");

            Products.Columns.Add(p0);
            Products.Columns.Add(p1);

            DataRow pRow;

            foreach (Product prod in products)
            {
                if (prod.ProductId == partId)
                {
                    pRow = Products.NewRow();

                    pRow["STL P/N:"] = prod.ProductId.ToString();
                    pRow["PartName:"] = prod.ProductName.ToString();

                    Products.Rows.Add(pRow);
                }
            }

            gridView_parts.DataSource = Products;
        }

        private void fillFields(int custId)
        {
            foreach(Customer cust in customers)
            {
                if(cust.Customer_ID == custId)
                {
                    txt_custId.Text = cust.Customer_ID.ToString();
                    txt_custName.Text = cust.CustCompanyName;
                    txt_custAdd.Text = cust.CustAddress[0] + ",\r\n" + cust.CustAddress[1] + ",\r\n" + cust.CustAddress[2];
                    contact = cust.CustFirstName + " " + cust.CustLastName + ", Purchasing Manager";
                }
            }
        }

        private void clearCustFields()
        {
            txt_custId.Text = null;
            txt_custName.Text = null;
            txt_custAdd.Text = null;
        }

        private void clearPartsFields()
        {
            txt_partId.Text = null;
            txt_quantity.Text = null;
        }

        private void disableCustPartFields()
        {
            txt_customPartName.Enabled = false;
            txt_CustomQty.Enabled = false;
            txt_CustomSpecs.Enabled = false;
        }

        private void clearCustomFields()
        {
            txt_customPartName.Text = null;
            txt_CustomQty.Text = null;
            txt_CustomSpecs.Text = null;
        }

        private string[] validateDates()
        {
            if (dtPicker_qDate.Value > DateTime.UtcNow && txt_CDate != null && txt_SDate != null)
            {
                string qDate = dtPicker_qDate.Value.ToString("dd/MM/yyyy");
                if (qDate != null)
                {
                    deliveryDates = new string[] { qDate, txt_CDate.Text, txt_SDate.Text };
                    return deliveryDates;
                }
                else
                    return null;
            }
            else
                return null;
        }

        private void deleteCustomProduct()
        {
            foreach (Product custom in customPart)
            {
                CustServices_Rules.DeleteCustomProduct(custom.ProductName);
            }
        }
        #endregion
    }
}
