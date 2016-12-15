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
using DataAccessLayer;

namespace SocketTechnologiesLtd
{
    public partial class CusCreditNote : MetroFramework.Forms.MetroForm
    {
        string ccnID = "", woID = "", custID = "";
        decimal totalPrice;

        private static IDataLayer _data = DataLayer.GetInstance();
        private static IModel model = Model.GetInstance(_data);
        List<IWorkOrder> workOrders;
        IdIncrement id = new IdIncrement();


        public CusCreditNote()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;

            model.WorkOrderList.Clear();
            model.FillWorkOrderList();
            workOrders = model.WorkOrderList;
            fillComboBox();

            ccnID = Convert.ToString(id.getReportID("CustomerCreditNote_Report"));
            ccnID_tb.Text = ccnID;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_ccn_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (WorkOrder wo in workOrders)
            {
                string WorkOrderID;
                WorkOrderID = comboBox_ccn.SelectedItem.ToString();
                if (WorkOrderID == wo.WorkOrderID.ToString())
                {
                    custID_tb.Text = wo.CustomerID.ToString();
                    custID = wo.CustomerID.ToString();
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

            comboBox_ccn.Items.AddRange(workOrdersID);
        }
    }
}
