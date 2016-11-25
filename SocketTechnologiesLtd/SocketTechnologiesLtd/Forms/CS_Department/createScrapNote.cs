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
    public partial class createScrapNote : MetroFramework.Forms.MetroForm
    {


        private string C_E_address;
        private string RGAR_num;
        private string scrapNo;
        private string cus_Name;
        private string cus_Address;
        private string txt;
        IdIncrement id = new IdIncrement();
        




        public createScrapNote()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;

            scrapNo = id.Id.ToString();

            scrap_no_tf.Text = scrapNo;
            c_and_e_addresstf.Text = "Customs and Excise, Long Mile Road, Dublin 12";
            RGAR_tf.Text = "9799";

        }

        private void metroButton2_Click(object sender, EventArgs e)
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            cus_Name = cus_Name_tf.Text;
            cus_Address = cus_Address_tf.Text;
            C_E_address = c_and_e_addresstf.Text;
            txt = Scrap_Note_Txt.Text;
            RGAR_num = RGAR_tf.Text;
            //RtQ scrapNote = new RtQ(scrapNo, cus_Name, cus_Address, RGAR_num, txt);
            MessageBox.Show("Scrap Note Successfully Created!");
            this.Close();
        }
    }
}
