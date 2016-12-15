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
    public partial class Create_PMRP : MetroFramework.Forms.MetroForm
    {

        #region Instance Attributes
        private IModel model;
        

        List<ICustomer> customers;
        List<IDocument> documents;
        List<IWorkOrder> workOrder;
        #endregion

        public Create_PMRP(IModel _Model)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;

            model = _Model;

            
            model.FillWorkOrderList();
           
            foreach(WorkOrder wo in workOrder)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(dataGridView2);
                row.Cells[0].Value = wo.WorkOrderID.ToString();
                row.Cells[1].Value = wo.CustomerID.ToString();
                row.Cells[2].Value = wo.DateRequired.ToString();


                dataGridView2.Rows.Add(row);

            }
            this.dataGridView2.Sort(this.dataGridView2.Columns["Date Required"], ListSortDirection.Ascending);
        }

        private void Create_PMRP_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
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
               // documents.Clear();
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            foreach (WorkOrder wo in workOrder)
            {
                foreach (DataGridViewRow item in dataGridView2.SelectedRows)
                {
                    if(wo.WorkOrderID == Convert.ToInt16(item.Cells[0]))
                    {
                        //get product and product raw materials

                        //wo.STLproductID



                        //DataGridViewRow row = new DataGridViewRow();
                        //row.CreateCells(dataGridView1);  // this line was missing
                        //row.Cells[0].Value = line_ID.ToString();
                        //row.Cells[1].Value = prod.ProductName.ToString();
                        //row.Cells[2].Value = Item.Quantity.ToString();
                        //row.Cells[3].Value = Item.GetLinePrice().ToString();
                        //row.Cells[4].Value = Item.VAT.ToString();
                        //row.Cells[5].Value = Item.GetLineTotal().ToString();
                        //row.Cells[6].Value = prod.ProductId.ToString();


                        //dataGridView1.Rows.Add(row);

                        //Production_Rules.AddPMRP
                    }

                }
            }


        }
    }
}
