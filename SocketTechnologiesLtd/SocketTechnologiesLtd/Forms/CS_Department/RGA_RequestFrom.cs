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
    public partial class RGA_RequestFrom : MetroFramework.Forms.MetroForm
    {
        //IdIncrement id = new IdIncrement();
        string rgaID;

        public RGA_RequestFrom()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;

            rgaID = "2";

            rgaID_tb.Text = rgaID;
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

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
            string custID = custID_tb.Text;
            string text = txt_tb.Text;
            string cpoID = cpoID_tb.Text;
            string custName = custName_tb.Text;



            RGArequest rga = new RGArequest(rgaID, custName, custID, cpoID, text);
            MessageBox.Show("RGA Request successfully created!");
            this.Close();
        }
    }
}
