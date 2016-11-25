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
    public partial class RtQ_Form : MetroFramework.Forms.MetroForm
    {
        private string custName;
        private string custAdd;
        private string rfqId;
        private string txt;
        IdIncrement id = new IdIncrement();
        string rtqId;

        public RtQ_Form()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;

            rtqId = id.Id.ToString();

            txt_RtQId.Text = rtqId;
            txt_CustomerName.Text = "Cork Cyber Computing Ltd.";
            txt_custAdd.Text = "Cork Business Park, \nModel Farm Road., \nCork.";
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            custName = txt_CustomerName.Text;
            custAdd = txt_custAdd.Text;
            rfqId = txt_RfQId.Text;
            txt = txt_rtqTxt.Text;

            RtQ rtq = new RtQ(rtqId, custName, custAdd, rfqId, txt, lst_customItems);
            MessageBox.Show("Refusal to quote successfully created!");
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
