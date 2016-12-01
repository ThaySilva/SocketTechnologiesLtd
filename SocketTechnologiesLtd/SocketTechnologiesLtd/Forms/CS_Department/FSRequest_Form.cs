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

            metroTextBox4.Text = fsrID;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string custID = txt_custID.Text;
            string text = metroTextBox1.Text;
            string cpoID = metroTextBox2.Text;
            string comboType = metroComboBox1.Text;

            fsrRequest fsr = new fsrRequest(fsrID, custID, cpoID, text, comboType);
            MessageBox.Show("Field Service Request successfully created!");
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
