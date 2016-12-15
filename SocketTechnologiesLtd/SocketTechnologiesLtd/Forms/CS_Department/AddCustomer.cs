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
            ViewCustomerDetails VCD = new ViewCustomerDetails(model);
            VCD.Show();



        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
        private void btn_saveAddCus_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
               // ICustomer duplicateCustomer = model.CustomerList.FirstOrDefault(cust => cust.CustFirstName == tb_FirstName.Text.Trim());

                //if (duplicateCustomer ==)
                //{
                    try
                    {
                        CustServices_Rules.AddCustomer(Convert.ToInt32(tbCustomer_ID.Text), tb_FirstName.Text, tb_LastName.Text, tb_CompanyName.Text, tb_Phone.Text, new string[] { tb_add1.Text, tb_Add2.Text, tb_add3.Text });

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
       // }
        #endregion

        #region Extra Functions
        private Boolean validateFields()
        {
            if (tb_FirstName.Text == " ")
            {
                MessageBox.Show("Please enter a first name!");
                return false;
            }
            else if (tb_LastName.Text == " ".Trim())
            {
                MessageBox.Show("Please enter a last name");
                return false;
            }
            else if (tb_Phone.Text == " ".Trim())
            {
                MessageBox.Show("Please enter phone number!");
                return false;
            }
            else if (tb_CompanyName.Text == " ".Trim())
            {
                MessageBox.Show("Please enter company name!");
                return false;
            }
            else if (tb_add1.Text == " ".Trim())
            {
                MessageBox.Show("Please enter address 1");
                return false;
            }
            else if (tb_Add2.Text == " ".Trim())
            {
                MessageBox.Show("Please enter address 2");
                return false;
            }
            else if (tb_add3.Text == " ".Trim())
            {
                MessageBox.Show("Please enter address 3");
                return false;
            }
            else
            {
                //MessageBox.Show("Please check all fields are filled in.");
                return true;
            }

        }
    }
}
#endregion