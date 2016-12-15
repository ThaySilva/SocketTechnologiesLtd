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

            populateListView();
        }


        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            if (prodId != 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the product " + tb_name.Text + " ?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Production_Rules.DeleteProduct(prodId);
                    MessageBox.Show("The product " + tb_name.Text + " was successfully deleted!");
                    this.Close();
                }
            }
        }

        private void btn_EditProduct_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                try
                {
                    foreach (Product prod in product)
                    {

                        if (prodId == prod.ProductId)
                        {
                            Production_Rules.EditProduct(prodId, tb_name.Text, tb_instructions.Text, Convert.ToDouble(tb_price.Text), Convert.ToDouble(tb_vat.Text));

                            MessageBox.Show("The details for Product " + tb_name + " have been successfully updated!");
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
        private void btn_BackProduct_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void populateListView()
        {
            DataTable prod = new DataTable("STLProduct");

            DataColumn c0 = new DataColumn("ProductID:");
            DataColumn c1 = new DataColumn("ProductName:");
            DataColumn c2 = new DataColumn("ManufacturingInstructions:");
            DataColumn c3 = new DataColumn("Price:");
            DataColumn c4 = new DataColumn("VAT:");

            prod.Columns.Add(c0);
            prod.Columns.Add(c1);
            prod.Columns.Add(c2);
            prod.Columns.Add(c3);
            prod.Columns.Add(c4);

            DataRow row;

            foreach (Product p in product)
            {
                
                    row = prod.NewRow();

                    row["ProductID:"] = p.ProductId.ToString();
                    row["ProductName:"] = p.ProductName;
                    row["ManufacturingInstructions:"] = p.ProductInstructions;
                    row["Price:"] = p.ProductPrice;
                    row["VAT:"] = p.ProductVAT;

                    prod.Rows.Add(row);
                
            }

            dataGrid_Product.DataSource = prod;

        }

        private Boolean validateFields()
        {
            if (tb_name.Text == "")
                MessageBox.Show("Please enter a product name!");
            else if (tb_instructions.Text == "")
                MessageBox.Show("Please enter a product instruction!");
            else if (tb_price.Text == "")
                MessageBox.Show("Please enter a price!");
            else if (tb_vat.Text == "")
                MessageBox.Show("Please enter the VAT");
            else
            {
                return true;
            }

            return false;
        }

        private void fillFields(int prodID)
        {
            foreach (Product p in product)
            {
                if (p.ProductId == prodId)
                {
                    tb_name.Text = p.ProductName;
                    tb_instructions.Text = p.ProductInstructions;
                    tb_price.Text = p.ProductPrice.ToString();
                    tb_vat.Text = p.ProductVAT.ToString();
                }
            }
        }


        #endregion

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prodId = Convert.ToInt32(dataGrid_Product.Rows[e.RowIndex].Cells["ProductID:"].Value);

            fillFields(prodId);
        }

        private void btn_SearchProd_Click(object sender, EventArgs e)
        {
            int id;
            bool result = int.TryParse(tb_searchProd.Text, out id);
            if (result)
                populateListView();
            else
                MessageBox.Show("You need to enter a number on the Id field!");

            tb_searchProd.Text = null;
        }

        private void txt_searchProd_Click(object sender, EventArgs e)
        {
            populateListView();
        }

        private void tb_name_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTileAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This needs an Add new product screen");
        }

        private void metroTileClear_Click(object sender, EventArgs e)
        {
            tb_name.Clear();
            tb_instructions.Clear();
            tb_price.Clear();
            tb_vat.Clear();
        }
    }
}
