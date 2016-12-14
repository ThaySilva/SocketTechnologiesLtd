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

        
        


        #region Instance Attributes
        private IModel model;
        IdIncrement PON = new IdIncrement();
        IdIncrement quoteRef = new IdIncrement();
        
        List<ICustomer> customers;
        List<IProduct> products;
        List<IDocument> documents;
        //string cpoId = "";
        //string fileId = "";
        int line_ID = 0;
        #endregion


        public Cust_Purchase_Order(IModel _Model)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            model = _Model;
           


            cust_purc_no_box.Text = PON.getReportID("CustomerPurchaseOrder_Report").ToString();
            //quote_Ref_box.Text = quoteRef.getReportID("").ToString();
            products = model.ProductList;
            customers = model.CustomerList;
             model.FillDocumentList("Quotation_Out_Report");
          //  model.FillDocumentList("CustomerPurchaseOrder_Report", false);

            documents = model.DocumentList;
            fillCustomer_comboBox();
            fillproduct_ComboBox();
            fillReportComboBox();
           
             

        }

        private void Cust_Purchase_Order_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        //private Boolean validateFields()
        //{
        //    if (product_ComboBox.SelectedIndex == -1)
        //        MessageBox.Show("Please select a product!");
        //    else if(quote_Ref_box.Text == "")
        //        MessageBox.Show("Please enter a quote Reference!");
        //    else if (quantity_box.Text == "")
        //        MessageBox.Show("Please enter a Quantity value!");
        //    else if (unit_price_box.Text == "")
        //        //auto-fill when possible
        //        MessageBox.Show("Please enter a price!");
        //   // else if (line_price_box.Text == "")
        //        //line price is quantity * price
        //     //   MessageBox.Show("Please enter the employee's name!");
        //    //else if (line_total_box.Text == "")
        //    //    MessageBox.Show("Please enter the employee's last name!");
        //    else if (date_box.Text == "")
        //        MessageBox.Show("Please enter the date required!");
        //    //else if (total_order_price_box.Text == "")
        //    //    MessageBox.Show("Please select a department!");
            

        //    return false;
        //}

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //Dialog box when exiting
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
                documents.Clear();
            }
        }
      

        private void metroButton3_Click(object sender, EventArgs e)
        {
            //open add customer window when working
            AddCustomer ac = new AddCustomer();
        }


        #region Extra Functions
        public void fillCustomer_comboBox()
        {
            int i = 0;
            string[] cust = new string[customers.Count];
            foreach (Customer cus in customers)
            {
                cust[i] = cus.CustCompanyName;
                i++;
            }
            Customer_comboBox.Items.AddRange(cust);
        }

        public void fillproduct_ComboBox()
        {
            int i = 0;
            string[] prods = new string[products.Count];
            foreach (Product prod in products)
            {
                prods[i] = prod.ProductName;
                i++;
            }
            product_ComboBox.Items.AddRange(prods);
        }

        public void fillReportComboBox()
        {
            int i = 0;
            string[] docsItem = new string[documents.Count];
            foreach (Document doc in documents)
            {
                docsItem[i] = doc.DocumentID.ToString();
                i++;
            }
            quote_Ref_CBox.Items.AddRange(docsItem);
        }

        private void line_price_box_Click(object sender, EventArgs e)
        {
           
            double linePrice, Vat, incVat;
            if (quantity_box != null)
            {
                int qty = int.Parse(quantity_box.Text);
                linePrice = Convert.ToDouble(unit_price_box.Text) * qty;
                line_price_box.Text = linePrice.ToString("#.##");
                Vat = (Convert.ToDouble(VAT_textBox.Text) / 100) * linePrice;
                incVat = linePrice + Vat;
                line_total_box.Text = incVat.ToString("#.##");
            }
        }

        private void product_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            product_ComboBox.SelectedItem.ToString().Trim();
            
            foreach (Product prod in products)
            {
                if (prod.ProductName.Equals(product_ComboBox.SelectedItem.ToString().Trim()))
                {
                    unit_price_box.Text = prod.ProductPrice.ToString();
                    VAT_textBox.Text = prod.ProductVAT.ToString();
                }
            }
        }


        //MyString = CStr(dateTimePicker1.Value.Date)
        #endregion

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi1, lvsi2, lvsi3, lvsi4, lvsi5, lvsi6;
            product_ComboBox.SelectedItem.Equals(null);
            listView1.BeginUpdate();

            
            if(listView1 == null)
            {
                line_ID = 1;
            }
            else
            {
                line_ID++;
            }

            foreach (Product prod in products)
            {
                if (prod.ProductName.Equals(product_ComboBox.SelectedItem.ToString().Trim()))
                {
                    LineItem Item = new LineItem(line_ID, prod, Convert.ToInt16(quantity_box.Text), Convert.ToDouble(line_price_box.Text), Convert.ToDouble(VAT_textBox.Text), Convert.ToDouble(line_total_box.Text));
                    lvi = new ListViewItem();
                    lvi.Text = Item.LineID.ToString();

                    lvsi1 = new ListViewItem.ListViewSubItem();
                    lvsi1.Text = Item.LineItemProduct.ProductName.ToString();
                    lvi.SubItems.Add(lvsi1);

                    lvsi3 = new ListViewItem.ListViewSubItem();
                    lvsi3.Text = Item.Quantity.ToString();
                    lvi.SubItems.Add(lvsi3);

                    lvsi4 = new ListViewItem.ListViewSubItem();
                    lvsi4.Text = Item.GetLinePrice().ToString();
                    lvi.SubItems.Add(lvsi4);

                    lvsi5 = new ListViewItem.ListViewSubItem();
                    lvsi5.Text = Item.VAT.ToString();
                    lvi.SubItems.Add(lvsi5);

                    lvsi6 = new ListViewItem.ListViewSubItem();
                    lvsi6.Text = Item.GetLineTotal().ToString();
                    lvi.SubItems.Add(lvsi6);

                    listView1.Items.Add(lvi);
                }

            }
            listView1.EndUpdate();
            listView1.Enabled = true;
            listView1.FullRowSelect = true;


        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem eachItem in listView1.SelectedItems)
                {
                    listView1.Items.Remove(eachItem);
                }
            }
            else
            {
                MessageBox.Show("You have to choose Member from the list first");
            }
        }

        private void create_order_button_Click(object sender, EventArgs e)
        {

            //CustomerPurchaseOrder cusPurOrder = new CustomerPurchaseOrder();






        }
    }


//    Order cusOrder = new Order();                             CODE FOR WORK ORDER


//    Customer_comboBox.SelectedItem.ToString().Trim();
//    int custID = 0;
//            foreach (Customer cust in customers)
//            {
//                if (cust.CustCompanyName.Equals(Customer_comboBox.SelectedItem.ToString().Trim()))
//                {
//                    custID = cust.Customer_ID;
//                    cusOrder.ClientID = custID;
//                }
//            }

//           // int custOrderID;
//            cusOrder.OrderID = Convert.ToInt16(cust_purc_no_box.Text);
//            string date = datePicker.Value.ToString("dd/MM/yyyy");
//datePicker.Text = date;
//            cusOrder.DateRequired = datePicker.Value.Date;




}
