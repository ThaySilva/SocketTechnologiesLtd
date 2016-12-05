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

namespace SocketTechnologiesLtd
{
    public partial class FSRequest_Form : MetroFramework.Forms.MetroForm
    {
        IdIncrement id = new IdIncrement();
        string fsrID;

        public FSRequest_Form()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;

            fsrID = id.Id.ToString();

            fsrID_tb.Text = fsrID;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string custID = custID_tb.Text;
            string text = text_tb.Text;
            string cpoID = cpoID_tb.Text;
            string comboType = type_cb.Text;

            fsrRequest fsr = new fsrRequest(fsrID, custID, cpoID, text, comboType);
            MessageBox.Show("Field Service Request successfully created!");
            this.Close();

            switch(comboType)
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
