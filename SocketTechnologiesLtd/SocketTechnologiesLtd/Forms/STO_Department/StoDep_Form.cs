using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using SocketTechnologiesLtd.Forms.STO_Department;

namespace SocketTechnologiesLtd
{
    public partial class StoDep_Form : MetroFramework.Forms.MetroForm
    {

        #region Instance Attributes
        private IModel model;
        #endregion
        public StoDep_Form(IModel _Model)
        {
            InitializeComponent();
            this.ControlBox = false;
            model = _Model;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            DeleveryNoteIn dni = new DeleveryNoteIn();
            dni.MdiParent = this.MdiParent;
            dni.Dock = DockStyle.Fill;
            dni.Show();

            /*
              Cust_Purchase_Order cpr = new Cust_Purchase_Order(model);
            cpr.MdiParent = this.MdiParent;
            cpr.Dock = DockStyle.Fill;
            cpr.Show();
             
             
             */

        }
    }
}
