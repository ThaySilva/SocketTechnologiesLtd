using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketTechnologiesLtd
{
    public partial class ExceptinAuthorisationResponse : MetroFramework.Forms.MetroForm
    {
        public ExceptinAuthorisationResponse()
        {
            InitializeComponent();
        }

        private void ExceptinAuthorisationResponse_Load(object sender, EventArgs e)
        {

        }

        private void yesradioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (yesradioButton1.Checked == true)
            {
                metroTextBox1.Text = "Authorisation accepted";
            }
            else
            {
                metroTextBox1.Text = "Authorisation refused";
            }
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
    }
    }

