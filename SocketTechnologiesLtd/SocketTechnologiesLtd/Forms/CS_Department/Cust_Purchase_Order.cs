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
    public partial class Cust_Purchase_Order : MetroFramework.Forms.MetroForm
    {

        IdIncrement PON = new IdIncrement();
        IdIncrement LineNo = new IdIncrement();

        #region Instance Attributes
        private IModel model;
        #endregion
        

        public Cust_Purchase_Order(IModel _Model)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            model = _Model;

            //cust_purc_no_box.Text = PON.getPON().ToString();
            //line_no_box.Text = LineNo.g

        }

        private void Cust_Purchase_Order_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox10_Click(object sender, EventArgs e)
        {

        }

        private Boolean validateFields()
        {
            if (product_ComboBox.SelectedIndex == -1)
                MessageBox.Show("Please select a product!");
            else if(quote_Ref_box.Text == "")
                MessageBox.Show("Please enter a quote Reference!");
            else if (quantity_box.Text == "")
                MessageBox.Show("Please enter a Quantity value!");
            else if (unit_price_box.Text == "")
                //auto-fill when possible
                MessageBox.Show("Please enter a price!");
           // else if (line_price_box.Text == "")
                //line price is quantity * price
             //   MessageBox.Show("Please enter the employee's name!");
            //else if (line_total_box.Text == "")
            //    MessageBox.Show("Please enter the employee's last name!");
            else if (date_box.Text == "")
                MessageBox.Show("Please enter the date required!");
            //else if (total_order_price_box.Text == "")
            //    MessageBox.Show("Please select a department!");
            

            return false;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }
        //private void populateCombo(int prodName)
        //{
        //    DataTable Product = new DataTable("STLProduct");

        //    DataColumn c0 = new DataColumn("productName:");
            

        //    Product.Columns.Add(c0);
            

        //    DataRow row;

        //    foreach (Product p in product)
        //    {
        //            row = Product.NewRow();

        //        row["productName:"] = p.ProductName;
                    

        //        Product.Rows.Add(row);
               
        //    }

        //    product_ComboBox.DataSource = Product;

        //}

        private void metroButton3_Click(object sender, EventArgs e)
        {
            AddCustomer ac = new AddCustomer();
        }
    }
}
