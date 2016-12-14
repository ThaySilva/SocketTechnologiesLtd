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
    public partial class AddCustomer : MetroFramework.Forms.MetroForm
    {
        IdIncrement id = new IdIncrement();

        #region Instance Attributes
        private IModel model;
        #endregion

        #region Constructors
        public AddCustomer()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            
            //tbCustomer_ID.Text = id.getCustId().ToString();
           
        }
        private void btnBackAddCust_Click(object sender, EventArgs e)
        {
            Close();
            //ViewCustomerDetails VCD = new ViewCustomerDetails(model);
            //VCD.Show();

            
            
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveAddCust_Click(object sender, EventArgs e)
        {

            if (validateFields())
            {
                ICustomer duplicateCustomer = model.CustomerList.FirstOrDefault(cust => cust.CustFirstName == tb_add1.Text.Trim());

                if (duplicateCustomer == null)
                {
                    try
                    {
                        CustServices_Rules.AddCustomer(Convert.ToInt32(tbCustomer_ID.Text), tb_CompanyName.Text, tb_FirstName.Text, tb_LastName.Text, tb_Phone.Text, new string[] {tb_add1.Text,tb_Add2.Text,tb_add3.Text });

                        MessageBox.Show("The customer " + tb_CompanyName.Text + " was successfully created!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("The customer " + tb_CompanyName.Text + " already exists please try another company name!");
            }
         }
        #endregion

        #region Extra Functions
        private Boolean validateFields()
        {
            if (tb_FirstName.Text == "")
                MessageBox.Show("Please enter a first name!");
            else if (tb_LastName.Text == "")
                MessageBox.Show("Please enter a last name");
            else if (tb_Phone.Text == "")
                MessageBox.Show("Please enter phone number!");
            else if (tb_CompanyName.Text == "")
                MessageBox.Show("Please enter company name!");
            else if (tb_add1.Text == "")
                MessageBox.Show("Please enter address 1");
            else if (tb_Add2.Text == "")
                MessageBox.Show("Please enter address 2");
            else if (tb_add3.Text == "")
                MessageBox.Show("Please enter address 3");
            else
                //MessageBox.Show("Please check all fields are filled in.");

                //    ICustomer duplicateCustomer = model.CustomerList.FirstOrDefault(cust => cust.CustFirstName == tb_add1.Text.Trim());

                //if (duplicateCustomer == null)
                //{
                try
                {
                    CustServices_Rules.AddCustomer(Convert.ToInt32(tbCustomer_ID.Text), tb_CompanyName.Text, tb_FirstName.Text, tb_LastName.Text, tb_Phone.Text, new string[] { tb_add1.Text, tb_Add2.Text, tb_add3.Text });

                    MessageBox.Show("The customer " + tb_CompanyName.Text + " was successfully created!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            return false;
        
            //else
            //    MessageBox.Show("The customer " + tb_CompanyName.Text + " already exists please try another company name!");
        
            //return false;
        }

        private void btnClearAddCust_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                ICustomer duplicateCustomer = model.CustomerList.FirstOrDefault(cust => cust.CustFirstName == tb_add1.Text.Trim());

                if (duplicateCustomer == null)
                {
                    try
                    {
                        CustServices_Rules.AddCustomer(Convert.ToInt32(tbCustomer_ID.Text), tb_CompanyName.Text, tb_FirstName.Text, tb_LastName.Text, tb_Phone.Text, new string[] { tb_add1.Text, tb_Add2.Text, tb_add3.Text });

                        MessageBox.Show("The customer " + tb_CompanyName.Text + " was successfully created!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("The customer " + tb_CompanyName.Text + " already exists please try another company name!");
            }
        }
    }
}
#endregion