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

namespace SocketTechnologiesLtd
{
    public partial class FSRequest_Form : MetroFramework.Forms.MetroForm
    {
        string fsrID = "";
        IdIncrement id = new IdIncrement();
        public FSRequest_Form()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;

            fsrID = Convert.ToString(id.getReportID("FieldServiceRequest_Report"));


            fsrID_tb.Text = fsrID;

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string custID = "", text = "", WorkOrderID = "", comboType = "";
            custID = custID_tb.Text;
            text = text_tb.Text;
            WorkOrderID = WorkOrderID_tb.Text;
            comboType = type_cb.Text;

            if (custID == "")
            {
                MessageBox.Show("Please enter a Work Order ID and press the search button.");
            }
            else if (WorkOrderID == "")
            {

            }
            else if (custID == "")
            {

            }
            else if (text == "")
            {

            }
            else
            {
                fsrRequest fsr = new fsrRequest(fsrID, custID, WorkOrderID, text, comboType);
                MessageBox.Show("Field Service Request successfully created!");
                this.Close();

                switch (comboType)
                {
                    case "Technical Enquiry":
                        TE_Form te = new TE_Form();
                        te.txt_TEtext.Text = text;
                        te.MdiParent = this.MdiParent;
                        te.Dock = DockStyle.Fill;
                        te.Show();
                        break;
                    case "Customer Order Enquiry":
                        COE_Form coe = new COE_Form();
                        coe.MdiParent = this.MdiParent;
                        coe.Dock = DockStyle.Fill;
                        coe.Show();
                        break;
                    case "Returned Goods":
                        RGA_RequestFrom rga = new RGA_RequestFrom();
                        rga.MdiParent = this.MdiParent;
                        rga.Dock = DockStyle.Fill;
                        rga.Show();
                        break;
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
