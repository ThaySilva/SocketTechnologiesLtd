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
    public partial class ViewCustomerDetails : MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private IModel model;
        List<ICustomer> customers;
        #endregion

        #region Constructors
        public ViewCustomerDetails(IModel _Model)
        {
            //populateCustView();
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            model = _Model;
            customers = model.CustomerList;
        

        }

        private void ViewCustomerDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stldb2DataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter2.Fill(this.stldb2DataSet1.Customer);
            // TODO: This line of code loads data into the 'stldb2DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.stldb2DataSet.Customer);
            //TODO: This line of code loads data into the 'stldb1DataSet.Customer' table.You can move, or remove it, as needed.
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
            AddCustomer ac = new AddCustomer();
            ac.MdiParent = this.MdiParent;
            ac.Dock = DockStyle.Fill;
            ac.Show();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            
            if (lv_customers.SelectedItems.Count != 0)
            {
                String id = lv_customers.SelectedItems[0].SubItems[0].Text;
                if (id != null)
                {
                    EditCustomerDetails ec = new EditCustomerDetails(Convert.ToInt16(id));
                    ec.MdiParent = this.MdiParent;
                    ec.Dock = DockStyle.Fill;
                    ec.Show();
                }
            }
        }

private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
        
            if (lv_customers.SelectedItems.Count != 0)
            {
                String id = lv_customers.SelectedItems[0].SubItems[0].Text;
                if (MessageBox.Show("Are you sure you want to delete the customer " + id +" ?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CustServices_Rules.DeleteCustomer(Convert.ToInt16(id));
                    MessageBox.Show("The customer " + id  +" was successfully deleted!");
                    this.Close();
                }
            }
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

                    //cRow["CustomerID:"] = cust.customer_ID.ToString();
                    //cRow["First Name:"] = cust.custFirstName.ToString();
                    //cRow["Last Name:"] = cust.custLastName.ToString();
                    //cRow["Company Name:"] = cust.custCompanyName.ToString();
                    //cRow["Phone:"] = cust.custPhoneNum.ToString();
                    //cRow["Address 1:"] = cust.custAddress.ToString();
                    //cRow["Address 2:"] = cust.custAddLine2.ToString();
                    //cRow["County:"] = cust.custCounty.ToString();

                    Customers.Rows.Add(cRow);
                
            }

            //customerGridView.DataSource = Customers;
           
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customerTableAdapter1.FillBy(this.stldb2DataSet.Customer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void SetCustomerDetails(string custId, string compName, string FirstName, string LastName, string phone, string Address1, string Address2, string Address3)
        {
            lblCustIDViewCust.Text = custId;
            lblCompNameViewCust.Text = compName;
            lblCustFirstNameViewCust.Text = FirstName;
            lblCusSurnameViewCust.Text = LastName;
            lblAddress1ViewCust.Text = Address1;
            lblAddress2ViewCust.Text = Address2;
            lblAddress3ViewCust.Text = Address3;
            lblPhoneNoViewCust.Text = phone;
        }
        private void lv_customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // check whether an item is selected
            if (lv_customers.SelectedItems.Count != 0)
            {
                // Enable buttons
               btnDeleteCustomerViewCust.Enabled = true;
               btnEditCustomerViewCust.Enabled = true;

                // get id of selected employee
                string id = lv_customers.SelectedItems[0].SubItems[0].Text;

                // get details of a customer that is associated with selected customer
                 

                // use these details to populate the textboxes
                SetCustomerDetails(customers[0].ToString(), customers[1].ToString(), customers[2].ToString(), customers[3].ToString(), customers[4].ToString(), customers[5].ToString(), customers[6].ToString(), customers[7].ToString());
            }
            else
            {
                // if SelectedItems.Count is zero, reset labels
                SetCustomerDetails("", "", "", "", "", "", "", "");

                // disable buttons
                btnDeleteCustomerViewCust.Enabled = false;
                btnEditCustomerViewCust.Enabled = false;
            }
        }

        private void btnBackViewCust_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    #endregion
}
#endregion