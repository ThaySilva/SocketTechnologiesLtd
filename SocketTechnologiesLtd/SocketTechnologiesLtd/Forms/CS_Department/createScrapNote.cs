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
        private string scrap_no; 
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

            

            
            c_and_e_addresstf.Text = "Customs and Excise,\nLong Mile Road,\nDublin 12.\n\n";
            RGAR_tf.Text = "";
            sn_tf.Text = "";

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
            scrap_no = sn_tf.Text;
            cus_Name = cus_Name_tf.Text;
            cus_Address = cus_Address_tf.Text;
            C_E_address = c_and_e_addresstf.Text;
            txt = Scrap_Note_Txt.Text;
            RGAR_num = RGAR_tf.Text;
            scrapNote scrapNote = new scrapNote(scrap_no, cus_Name, cus_Address, C_E_address, RGAR_num, txt);
            
            this.Close();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createScrapNote_Load(object sender, EventArgs e)
        {

        }
    }
}
