using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentWriter;
using BusinessLayer;
using BusinessEntities;

namespace SocketTechnologiesLtd
{
    public partial class RGA_RequestFrom : MetroFramework.Forms.MetroForm
    {

        string rgaID = "", custName = "", custID ="", workOrderID = "", text = "";
        IdIncrement id = new IdIncrement();
        IModel model;
        List<IWorkOrder> workOrders;
        List<ICustomer> customers;

        public RGA_RequestFrom(IModel _Model)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;

            model = _Model;
            model.WorkOrderList.Clear();
            model.FillWorkOrderList();
            workOrders = model.WorkOrderList;
            customers = model.CustomerList;
            fillComboBox();

            rgaID = Convert.ToString(id.getReportID("RGArequest_Report"));
            rgaID_tb.Text = rgaID;
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox_rga_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (WorkOrder wo in workOrders)
            {
                string WorkOrderID;
                WorkOrderID = comboBox_rga.SelectedItem.ToString();
                if (WorkOrderID == wo.WorkOrderID.ToString())
                {
                    custID_tb.Text = wo.CustomerID.ToString();
                    custID = wo.CustomerID.ToString();
                    
                }

                foreach(Customer c in customers)
                {
                    if(wo.CustomerID == c.Customer_ID)
                    {

                        custName = c.CustCompanyName.ToString();
                        custName_tb.Text = custName;
                    }
                }
            }


        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            custID = custID_tb.Text;
            text = txt_tb.Text;
            workOrderID = rgaID_tb.Text;
            custName = custName_tb.Text;

            if (workOrderID == "")
            {
                MessageBox.Show("Please select a Work Order ID from the dropdown menu.");
            }
            else
            {
                RGArequest rga = new RGArequest(rgaID, custName, custID, workOrderID, text);
                MessageBox.Show("RGA Request successfully created!");

                string[] comboType = { };
                PDF_Preview viewer = new PDF_Preview(comboType);
                viewer.MdiParent = this.MdiParent;
                viewer.Show();
                this.Close();
            }
        }
        

        private void fillComboBox()
        {
            int i = 0;
            string[] workOrdersID = new string[workOrders.Count];

            foreach (WorkOrder wo in workOrders)
            {
                workOrdersID[i] = wo.WorkOrderID.ToString();
                i++;
            }

            comboBox_rga.Items.AddRange(workOrdersID);

        }
    }
}
