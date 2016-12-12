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
            
            tbCustomer_ID.Text = id.getCustId().ToString();
           
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

        private void btnSaveAddCust_Click(object sender, EventArgs e)
        {
            
            if (validateFields())
            {
                //ICustomer duplicateCustomer = model.CustomerList.FirstOrDefault(cust => cust.custCompanyName == tbCompanyNameAddCust.Text.Trim());

            //   if (duplicateCustomer == null)
            //    {
            //        try
            //        {
            //            //CustServices_Rules.AddCustomer(Convert.ToInt32(tbCustomer_ID.Text), tbCompanyNameAddCust.Text,tbFirstNameAddCust.Text, tbLastNameAddCust.Text, tbPhoneAddCust.Text, tbAddress1AddCust.Text, tbAddress2AddCust.Text, tbAddress3AddCust.Text);
                        
            //            MessageBox.Show("The customer " + tbCompanyNameAddCust.Text + " was successfully created!");
            //            this.Close();
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }
            //    }
            //    else
            //        MessageBox.Show("The customer " + tbCompanyNameAddCust.Text + " already exists please try another company name!");
            }
        }
        #endregion

        #region Extra Functions
        private Boolean validateFields()
        {
            if (tbFirstNameAddCust.Text == "")
                MessageBox.Show("Please enter a first name!");
            else if (tbLastNameAddCust.Text == "")
                MessageBox.Show("Please enter a last name");
            else if (tbEmailAddCust.Text == "")
                MessageBox.Show("Please enter an email address");
            else if (tbPhoneAddCust.Text == "")
                MessageBox.Show("Please enter phone number!");
            else if (tbCompanyNameAddCust.Text == "")
                MessageBox.Show("Please enter company name!");
            else if (tbAddress1AddCust.Text == "")
                MessageBox.Show("Please enter address 1");
            else if (tbAddress2AddCust.Text == "")
                MessageBox.Show("Please enter address 2");
            else if (tbAddress3AddCust.Text == "")
                MessageBox.Show("Please enter address 3");
            else
                MessageBox.Show("Please check all fields arfilled in.");
            return false;
        }
    }
}
#endregion