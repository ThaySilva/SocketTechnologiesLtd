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
    public partial class EngDep_Form : MetroFramework.Forms.MetroForm
    {
        public EngDep_Form()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddCustomProduct_Click(object sender, EventArgs e)
        {
            AddCustomProduct acp = new AddCustomProduct();
            acp.MdiParent = this.MdiParent;
            acp.Dock = DockStyle.Fill;
            acp.Show();
        }

        private void btn_ViewTE_Click(object sender, EventArgs e)
        {
            ViewTechnicalEnquiries vte = new ViewTechnicalEnquiries();
            vte.MdiParent = this.MdiParent;
            vte.Dock = DockStyle.Fill;
            vte.Show();
        }
    }
}
