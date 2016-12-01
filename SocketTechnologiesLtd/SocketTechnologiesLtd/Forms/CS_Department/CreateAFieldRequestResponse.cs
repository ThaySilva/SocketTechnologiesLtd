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
    public partial class CreateAFieldRequestResponse : MetroFramework.Forms.MetroForm
    {

        class RResponse
        {
            public int IdNumber;
            public string Date;
            public int CustPurchNumber;
            public int FieldSerReqLogNumber;
            public string Text;

            public RResponse (int id, string date, int cusNumber,int logNumber,string text )
            {
                this.IdNumber = id;
                this.Date = date;
                this.CustPurchNumber = cusNumber;
                this.FieldSerReqLogNumber = logNumber;
                this.Text=text;
            }
        }
        public CreateAFieldRequestResponse()
        {
            InitializeComponent();
            List<RResponse> newRespList = new List<RResponse>();
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

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
