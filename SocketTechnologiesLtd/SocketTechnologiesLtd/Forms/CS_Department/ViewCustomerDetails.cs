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
using DataAccessLayer;

namespace SocketTechnologiesLtd
{
    public partial class ViewCustomerDetails : MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private IModel model;
        List<ICustomer> customers;
        #endregion

        #region Constructors
        public ViewCustomerDetails()
        {
            
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;

            customers = model.CustomerList;

            populateCustView();
        }
        
        private void ViewCustomerDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stldb1DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.stldb1DataSet.Customer);

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer ac = new AddCustomer(model);
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {

        }

        private void lvCustomerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbCustomerDetails_Enter(object sender, EventArgs e)
        {

        }
        #region Destructors
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Extra Functions
        private void populateCustView()
        {
            DataTable Customers = new DataTable("Customers");

            DataColumn c0 = new DataColumn("CustomerID:");
            DataColumn c1 = new DataColumn("First Name:");
            DataColumn c2 = new DataColumn("Last Name:");
            DataColumn c3 = new DataColumn("Company Name:");
            DataColumn c4 = new DataColumn("Phone:");
            DataColumn c5 = new DataColumn("Address 1:");
            DataColumn c6 = new DataColumn("Address 2:");
            DataColumn c7 = new DataColumn("County:");



            Customers.Columns.Add(c0);
            Customers.Columns.Add(c1);
            Customers.Columns.Add(c2);
            Customers.Columns.Add(c3);
            Customers.Columns.Add(c4);
            Customers.Columns.Add(c5);
            Customers.Columns.Add(c6);
            Customers.Columns.Add(c7);

            DataRow cRow;

            foreach (Customer cust in customers)
            {
                
                    cRow = Customers.NewRow();

                    cRow["CustomerID:"] = cust.customer_ID.ToString();
                    cRow["First Name:"] = cust.custFirstName.ToString();
                    cRow["Last Name:"] = cust.custLastName.ToString();
                    cRow["Company Name:"] = cust.custCompanyName.ToString();
                    cRow["Phone:"] = cust.custPhoneNum.ToString();
                    cRow["Address 1:"] = cust.custAddress.ToString();
                    cRow["Address 2:"] = cust.custAddLine2.ToString();
                    cRow["County:"] = cust.custCounty.ToString();

                    Customers.Rows.Add(cRow);
                
            }

            customerGridView.DataSource = Customers;
        }
    }
    #endregion
}
#endregion