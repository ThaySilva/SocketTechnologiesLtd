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

namespace SocketTechnologiesLtd
{
    public partial class Container : MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private IModel Model;
        #endregion

        public Container(IModel _Model)
        {
            Model = _Model;
            InitializeComponent();
            this.IsMdiContainer = true;
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            this.BackColor = Color.Black;

            MdiClient client;
            foreach(Control ctr in this.Controls)
            {
                try
                {
                    client = (MdiClient)ctr;
                    client.BackColor = Color.Black;
                    client.Dock = DockStyle.None;
                    client.Size = new Size(this.Width, this.Height);
                }
                catch (InvalidCastException ex){ }
            }

            Login_Form login = new Login_Form(_Model);
            login.MdiParent = this;
            login.Dock = DockStyle.Fill;
            login.FormClosing += Close;
            login.Show();
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Container_Load(object sender, EventArgs e)
        {

        }
    }
}
