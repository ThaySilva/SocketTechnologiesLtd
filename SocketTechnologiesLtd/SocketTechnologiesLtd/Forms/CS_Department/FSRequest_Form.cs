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
    public partial class FSRequest_Form : MetroFramework.Forms.MetroForm
    {
        string fsrID = "";
        string custID = "";
        List<IWorkOrder> workOrders;
        IModel model;
        IdIncrement id = new IdIncrement();

        public FSRequest_Form(IModel _Model)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;

            model = _Model;
            model.WorkOrderList.Clear();
            model.FillWorkOrderList();
            workOrders = model.WorkOrderList;
            fillComboBox();

            fsrID = Convert.ToString(id.getReportID("FieldServiceRequest_Report"));
            fsrID_tb.Text = fsrID;

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string text = "", WorkOrderID = "",comboType = "";

            
            text = text_tb.Text;
            WorkOrderID = comboBox_fsr.Text;
            comboType = type_cb.Text;

            if (WorkOrderID == "")
            {
                MessageBox.Show("Please select a Work Order ID from the dropdown menu.");
            }
            else
            {
                fsrRequest fsr = new fsrRequest(fsrID, custID, WorkOrderID, text, comboType);
                MessageBox.Show("Field Service Request successfully created!");

                //PDF_Preview viewer = new PDF_Preview(comboType);
                //viewer.MdiParent = this.MdiParent;
                //viewer.Show();
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchID_tile_Click(object sender, EventArgs e)
        {

        }

        private void fillComboBox()
        {
            int i = 0;
            string[] workOrdersID = new string[workOrders.Count];

            foreach(WorkOrder wo in workOrders)
            {
                workOrdersID[i] = wo.WorkOrderID.ToString();
                i++;
            }

            comboBox_fsr.Items.AddRange(workOrdersID);
        }

        private void comboBox_fsr_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (WorkOrder wo in workOrders)
            {
                string WorkOrderID;
                WorkOrderID = comboBox_fsr.SelectedItem.ToString();
                if (WorkOrderID == wo.WorkOrderID.ToString())
                {
                    custID_tb.Text = wo.CustomerID.ToString();
                    custID = wo.CustomerID.ToString();
                }
            }
        }
    }
}
