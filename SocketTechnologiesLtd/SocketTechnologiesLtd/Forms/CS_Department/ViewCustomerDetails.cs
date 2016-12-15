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
using DataAccessLayer;

namespace SocketTechnologiesLtd
{
    public partial class ViewCustomerDetails : MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private IModel model;
        List<ICustomer> customers;
        private DataLayer dataL;
        int cusId = 0;
        #endregion

        #region Constructors
        public ViewCustomerDetails(IModel _Model)
        {

            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            model = _Model;
            customers = model.CustomerList;
            List<String[]> custList = CustServices_Rules.GetCustomer();
            

            //PopulateListView(lv_customers, custList);

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
            EditCustomerDetails ec = new EditCustomerDetails(model);
            ec.MdiParent = this.MdiParent;
            ec.Dock = DockStyle.Fill;
            ec.Show();

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {

            if (cusId != 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the customer ?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CustServices_Rules.DeleteCustomer(cusId);
                    MessageBox.Show("The customer was successfully deleted!");
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
        //private void SetCustomerDetails(string custId, string compName, string FirstName, string LastName, string phone, string Address1, string Address2, string Address3)
        //{
        //    lblCustIDViewCust.Text = custId;
        //    lblCompNameViewCust.Text = compName;
        //    lblCustFirstNameViewCust.Text = FirstName;
        //    lblCusSurnameViewCust.Text = LastName;
        //    lblAddress1ViewCust.Text = Address1;
        //    lblAddress2ViewCust.Text = Address2;
        //    lblAddress3ViewCust.Text = Address3;
        //    lblPhoneNoViewCust.Text = phone;
        //}
        

        private void btnBackViewCust_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            
            populateListView();
        }


        private void populateListView()
        {
            DataTable customer = new DataTable("Customer");

            DataColumn c0 = new DataColumn("CustomerID:");
            DataColumn c1 = new DataColumn("First Name:");
            DataColumn c2 = new DataColumn("Last Name:");
            DataColumn c3 = new DataColumn("Company Name:");
            DataColumn c4 = new DataColumn("Phone:");
            DataColumn c5 = new DataColumn("Address:");
            DataColumn c6 = new DataColumn("Address 2:");
            DataColumn c7 = new DataColumn("Address 3:");

            customer.Columns.Add(c0);
            customer.Columns.Add(c1);
            customer.Columns.Add(c2);
            customer.Columns.Add(c3);
            customer.Columns.Add(c4);
            customer.Columns.Add(c5);
            customer.Columns.Add(c6);
            customer.Columns.Add(c7);

            DataRow row;

            foreach (Customer c in customers)
            {

                row = customer.NewRow();

                row["CustomerID:"] = c.Customer_ID.ToString();
                row["First Name:"] = c.CustFirstName;
                row["Last Name:"] = c.CustLastName;
                row["Company Name:"] = c.CustCompanyName;
                row["Phone:"] = c.CustPhoneNum;
                row["Address:"] = c.CustAddress[0];
                row["Address 2:"] = c.CustAddress[1];
                row["Address 3:"] = c.CustAddress[2];


                customer.Rows.Add(row);
                
            }

            //dataGridCustomer.DataSource = customer;

        }

        private void fillFields(int cusID)
        {
            foreach (Customer c in customers)
            {

                if (c.Customer_ID == cusID)
                {
                    tbCustomerSearch.Text = c.Customer_ID.ToString();
                }

            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int id;
            bool result = int.TryParse(tbCustomerSearch.Text, out id);
            if (result)
                populateListView();
            else
                MessageBox.Show("You need to enter a number on the Id field!");

            tbCustomerSearch.Text = null;
        }

        private void fillFields1(int cusID)
        {
            foreach (Customer c in customers)
            {

                if (c.Customer_ID == cusID)
                {
                    //tb_Fname.Text = c.CustFirstName;
                    //tb_Lname.Text = c.CustLastName;
                    //tb_companyName.Text = c.CustCompanyName;
                    //tb_Phone.Text = c.CustPhoneNum;
                    //tb_add1.Text = c.CustAddress[0];
                    //tb_add2.Text = c.CustAddress[1];
                    //tb_add3.Text = c.CustAddress[2];
                }
            }

        }
        private void dataGrid_Customer1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cusId = Convert.ToInt32(dataGrid_Customer1.Rows[e.RowIndex].Cells["Customer_ID:"].Value);

            fillFields1(cusId);
        }

        private void tbCustomerSearch_Click(object sender, EventArgs e)
        {
            populateListView();
        }
    }
}
    #endregion
#endregion