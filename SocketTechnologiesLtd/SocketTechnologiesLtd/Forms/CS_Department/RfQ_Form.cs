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

namespace SocketTechnologiesLtd
{
    public partial class RfQ_Form : MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private IModel model;
        List<ICustomer> customers;
        List<IProduct> products;
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

            populateListViews();
        }


        private void btn_searchCust_Click(object sender, EventArgs e)
        {
            int id;
            bool result = int.TryParse(txt_custId.Text, out id);
            if (result)
                populateCustView(id);
            else
                MessageBox.Show("You need to enter a number on the Id field!");

            clearCustFields();
        }

        private void txt_custId_Click(object sender, EventArgs e)
        {
            populateListViews();
            clearCustFields();
        }

        private void gridView_cust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int custId = Convert.ToInt16(gridView_cust.Rows[e.RowIndex].Cells["CustomerID:"].Value);
            fillFields(custId);
        }

        private void btn_selectCust_Click(object sender, EventArgs e)
        {

        }

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
            int partId = Convert.ToInt16(gridView_parts.Rows[e.RowIndex].Cells["STL P/N:"].Value);
            txt_partId.Text = partId.ToString();
        }
        #endregion

        #region Destructors
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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

                cRow["CustomerID:"] = cust.customer_ID.ToString();
                cRow["CustomerName:"] = cust.custCompanyName.ToString();

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
                if (cust.customer_ID == custId)
                {
                    cRow = Customers.NewRow();

                    cRow["CustomerID:"] = cust.customer_ID.ToString();
                    cRow["CustomerName:"] = cust.custCompanyName.ToString();

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
                if(cust.customer_ID == custId)
                {
                    txt_custId.Text = cust.customer_ID.ToString();
                    txt_custName.Text = cust.custCompanyName;
                    txt_custAdd.Text = cust.custAddress + ",\r\n" + cust.custAddLine2 + ",\r\n" + cust.custCounty;
                }
            }
        }

        private void clearCustFields()
        {
            txt_custId.Text = null;
            txt_custName.Text = null;
            txt_custAdd.Text = null;
        }
        #endregion
    }
}
