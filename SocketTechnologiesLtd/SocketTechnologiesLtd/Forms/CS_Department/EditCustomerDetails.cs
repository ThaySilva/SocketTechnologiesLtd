using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
using DataAccessLayer;

namespace SocketTechnologiesLtd
{
    public partial class EditCustomerDetails : MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private IModel model;
        List<ICustomer> customer;

        int cusId;
        #endregion

        #region Constructors
        public EditCustomerDetails(IModel _Model)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            model = _Model;
            customer = model.CustomerList;
            populateListView();

            //tb_customerIDedit.Text = id.ToString();
        }
        #endregion
        #region Extra Functions

        private Boolean validateFields()
        {
            if (tb_Fname.Text == "")
                MessageBox.Show("Please enter a first name.can't be left blank");
            else if (tb_Lname.Text == "")
                MessageBox.Show("Please enter a last name. can't be left blank");
            else if (tb_companyName.Text == "")
                MessageBox.Show("Please enter a compnay name. can't be left blank");
            else if (tb_Phone.Text == "")
                MessageBox.Show("Please enter phone number. can't be left blank");
            else if (tb_add1.Text == "")
                MessageBox.Show("Please enter address 1. can't be left blank");
            else if (tb_add2.Text == "")
                MessageBox.Show("Please enter address 2. can't be left blank");
            else if (tb_add3.Text == "")
                MessageBox.Show("Please enter address 3. can't be left blank");
            else
            {
                return true;
            }

            return false;
        }

        private void populateListView()
        {
            DataTable customer1 = new DataTable("Customer");

            DataColumn c0 = new DataColumn("CustomerID:");
            DataColumn c1 = new DataColumn("First Name:");

            customer1.Columns.Add(c0);
            customer1.Columns.Add(c1);

            DataRow row;

            foreach (Customer c in customer)
            {
                row = customer1.NewRow();

                row["CustomerID:"] = c.Customer_ID.ToString();
                row["First Name:"] = c.CustFirstName;

                customer1.Rows.Add(row);
            }

            dataGrid_Customer.DataSource = customer1;

        }

        private void populateListView(int cId)
        {
            DataTable Customer = new DataTable("Customer");

            DataColumn c0 = new DataColumn("Customer_ID:");
            DataColumn c1 = new DataColumn("CompanyName:");

            Customer.Columns.Add(c0);
            Customer.Columns.Add(c1);

            DataRow row;

            foreach (Customer c in customer)
            {
                if (c.Customer_ID == cId)
                {
                    row = Customer.NewRow();

                    row["Customer_ID:"] = c.Customer_ID.ToString();
                    row["CompanyName:"] = c.CustFirstName;

                    Customer.Rows.Add(row);
                }
            }

            dataGrid_Customer.DataSource = Customer;

        }


        private void tb_searchCus_Click(object sender, EventArgs e)
        {
            populateListView();
            //populateListView(cusId);
        }

        private void btn_SearchCus_Click(object sender, EventArgs e)
        {
            int id;
            bool result = int.TryParse(tb_searchCus.Text, out id);
            if (result)
                populateListView(id);
            else
                MessageBox.Show("You need to enter a number on the Id field!");

            tb_searchCus.Text = null;
        }

        private void btn_editCus_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                try
                {
                    foreach (Customer cus in customer)
                    {

                        if (cusId.ToString() == cus.Customer_ID.ToString())
                        {
                            CustServices_Rules.EditCustomer(cusId, tb_Fname.Text, tb_Lname.Text, tb_companyName.Text, tb_Phone.Text, new string[] { tb_add1.Text, tb_add2.Text, tb_add3.Text });


                            MessageBox.Show("The details for customer " + tb_companyName.Text + " have been successfully updated!");
                            this.Close();
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_deleteCus_Click(object sender, EventArgs e)
        {
            if (cusId != 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the customer " + tb_companyName.Text + " ?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CustServices_Rules.DeleteCustomer(cusId);
                    MessageBox.Show("The customer " + tb_companyName.Text + " was successfully deleted!");
                    this.Close();
                }
            }
        }

        private void btn_cancelCus_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void fillFields(int cusID)
        {
            foreach (Customer c in customer)
            {
                
                    if (c.Customer_ID == cusID)
                    {
                        tb_Fname.Text = c.CustFirstName;
                        tb_Lname.Text = c.CustLastName;
                        tb_companyName.Text = c.CustCompanyName;
                        tb_Phone.Text = c.CustPhoneNum;
                        tb_add1.Text = c.CustAddress[0];
                        tb_add2.Text = c.CustAddress[1];
                        tb_add3.Text = c.CustAddress[2];
                    }
                }
            
        }
        private void dataGrid_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cusId = Convert.ToInt32(dataGrid_Customer.Rows[e.RowIndex].Cells["Customer_ID:"].Value);

            fillFields(cusId);
        }
    }
    #endregion
}