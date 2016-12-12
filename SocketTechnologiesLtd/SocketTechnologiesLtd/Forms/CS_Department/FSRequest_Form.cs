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
        string fsrID;
        IdIncrement id = new IdIncrement();
        public FSRequest_Form()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;

            fsrID = id.getReportID("FieldServiceRequest_Report").ToString();

            if (fsrID != null)
            {
                fsrID_tb.Text = fsrID;
            }
            else
            {
                fsrID_tb.Text = "1";
            }
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

        //private Boolean validateFields()
        //{
        //    if (txt_username.Text == "")
        //        MessageBox.Show("Please enter a username!");
        //    else if (txt_password.Text == "")
        //        MessageBox.Show("Please enter a password!");
        //    else if (txt_password2.Text == "")
        //        MessageBox.Show("Please Re-Enter the password!");
        //    else if (txt_firstName.Text == "")
        //        MessageBox.Show("Please enter the employee's name!");
        //    else if (txt_lastName.Text == "")
        //        MessageBox.Show("Please enter the employee's last name!");
        //    else if (txt_phoneNum.Text == "")
        //        MessageBox.Show("Please enter the employee's phone number!");
        //    else if (cBox_dept.SelectedIndex == -1)
        //        MessageBox.Show("Please select a department!");
        //    else
        //    {
        //        if (txt_password.Text != txt_password2.Text)
        //            MessageBox.Show("The passwords doesn't match, try again!");
        //        else
        //            return true;
        //    }

        //    return false;
        //}

    }
}
