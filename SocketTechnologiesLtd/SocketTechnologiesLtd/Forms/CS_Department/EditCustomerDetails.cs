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
    public partial class EditCustomerDetails :  MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private IModel model;
        List<ICustomer> customer;
        #endregion

        #region Constructors
        public EditCustomerDetails(int id)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;

            tb_customerIDedit.Text = id.ToString();
        }

        private void btnSaveEditCus_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                try
                {
                    foreach (Customer cus in customer)
                    {
                        
                            if (tb_customerIDedit.Text == cus.Customer_ID.ToString())
                            {
                            CustServices_Rules.EditCustomer(Convert.ToInt16(tb_customerIDedit.Text), tbFNameEditCus.Text, tbLNameEditCus.Text, tbCompanyNameEditCus.Text, tbPhoneEditCus.Text, new string[] { tbAddress1EditCus.Text, tbAddress2EditCus.Text, tbAddress3EditCus.Text });
                                
                                
                                MessageBox.Show("The details for customer " + tbCompanyNameEditCus.Text + " has been successfully updated!");
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
        #endregion

        #region Extra Functions

        private Boolean validateFields()
        {
            if (tbFNameEditCus.Text == "")
                MessageBox.Show("Please enter a first name.can't be left blank");
            else if (tbFNameEditCus.Text == "")
                MessageBox.Show("Please enter a last name. can't be left blank");
            else if (tbPhoneEditCus.Text == "")
                MessageBox.Show("Please enter phone number. can't be left blank");
            else if (tbAddress1EditCus.Text == "")
                MessageBox.Show("Please enter address 1. can't be left blank");
            else if (tbAddress2EditCus.Text == "")
                MessageBox.Show("Please enter address 2. can't be left blank");
            else if (tbAddress3EditCus.Text == "")
                MessageBox.Show("Please enter address 3. can't be left blank");
            else if (tbCompanyNameEditCus.Text == "")
                MessageBox.Show("Please enter company name. can't be left blank");
            else
            {
                return true;
            }

            return false;
        }
        #endregion

        private void btnBackEditCus_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_customerIDedit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
