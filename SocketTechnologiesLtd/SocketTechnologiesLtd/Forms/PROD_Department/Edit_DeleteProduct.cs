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

    public partial class Edit_DeleteProduct : MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private IModel model;

        List<IProduct> product;
       

        int prodId = 0;
        #endregion

        #region Constructors
        public Edit_DeleteProduct(IModel _Model)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            model = _Model;

            product = model.ProductList;

            //populateListView();
        }


        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            if (prodId != 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the product " + txt_searchProd.Text + " ?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Production_Rules.DeleteProduct(prodId);
                    MessageBox.Show("The product " + txt_searchProd.Text + " was successfully deleted!");
                    this.Close();
                }
            }
        }

        private void btn_EditProduct_Click(object sender, EventArgs e)
        {

        }
        private void btn_BackProduct_Click(object sender, EventArgs e)
        {

        }
        //private void populateListView(int eId)
        //{
        //    DataTable Employee = new DataTable("Employee");

        //    DataColumn c0 = new DataColumn("EmployeeID:");
        //    DataColumn c1 = new DataColumn("EmployeeName:");

        //    Employee.Columns.Add(c0);
        //    Employee.Columns.Add(c1);

        //    DataRow row;

        //    foreach (Employee e in employee)
        //    {
        //        if (e.EmployeeID == eId)
        //        {
        //            row = Employee.NewRow();

        //            row["EmployeeID:"] = e.EmployeeID.ToString();
        //            row["EmployeeName:"] = e.FirstName;

        //            Employee.Rows.Add(row);
        //        }
        //    }

        //    dataGrid_Employee.DataSource = Employee;

        //}

        //private Boolean validateFields()
        //{
        //    if (txt_username.Text == "")
        //        MessageBox.Show("Please enter a username!");
        //    else if (txt_password.Text == "")
        //        MessageBox.Show("Please enter a password!");
        //    else if (txt_firstName.Text == "")
        //        MessageBox.Show("Please enter the employee's name!");
        //    else if (txt_lastName.Text == "")
        //        MessageBox.Show("Please enter the employee's last name!");
        //    else if (txt_phoneNum.Text == "")
        //        MessageBox.Show("Please enter the employee's phone number!");
        //    else if (cBox_dept.SelectedIndex == -1)
        //        MessageBox.Show("Please select a department!");
        //    else
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        //private void fillFields(int prodID)
        //{
        //    foreach (Product p in product)
        //    {
        //            if (p == prodID)
        //            {

        //            }
        //        }
        //    }


        #endregion

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
