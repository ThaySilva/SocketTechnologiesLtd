using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketTechnologiesLtd
{
    public partial class AddCustomer : MetroFramework.Forms.MetroForm
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnBackAddCust_Click(object sender, EventArgs e)
        {
            Close();
            ViewCustomerDetails VCD = new ViewCustomerDetails();
            VCD.Show();
            
        }

        private void btnSaveAddCust_Click(object sender, EventArgs e)
        {
            //if (Model.addNewUser(textBoxName.Text, textBoxPassword.Text, listBoxUserType.SelectedItem.ToString()))
            //{
            //    MessageBox.Show("User created");
            //    textBoxName.Text = "";
            //    textBoxPassword.Text = "";
            //}
        }
    }
}
