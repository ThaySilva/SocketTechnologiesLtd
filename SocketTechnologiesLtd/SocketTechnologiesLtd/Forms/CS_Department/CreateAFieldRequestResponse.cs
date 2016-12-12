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
    public partial class CreateAFieldRequestResponse : MetroFramework.Forms.MetroForm
    {

      
        private string Cust_Purch_Order_Num;
        private string Field_Serv_Req_Log_Num;
        private string Cust_Name;
        private string Cust_Address;
        private string Txt;  // empty
        private string Txt1; // In Response to your recent request
        private string Txt2; // If you have any futher querries, please do not hesitate to contact the Customer Service Department. 
        //IdIncrement id = new IdIncrement () ;




        public CreateAFieldRequestResponse()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;

            CustomerAddressmetroTextBox6.Text = "";
            
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }

        private void CreateAFieldRequestResponse_Load(object sender, EventArgs e)
        {
            //metroTextBox2 = DateTime.Now.ToString();
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Cust_Purch_Order_Num = metroTextBox3.Text;
            Field_Serv_Req_Log_Num = metroTextBox4.Text;
            Cust_Name = CustomerNamemetroTextBox6.Text;
            Cust_Address = CustomerAddressmetroTextBox6.Text;
            Txt = metroTextBox5.Text;
            Txt1 = metroTextBox6.Text;
            Txt2 = metroTextBox7.Text;
            CrAFiSeReRe CreateAFieldRequestResponse = new CrAFiSeReRe( Cust_Purch_Order_Num, Field_Serv_Req_Log_Num, Cust_Name, Cust_Address, Txt , Txt1, Txt2);
            

            this.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

      

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
