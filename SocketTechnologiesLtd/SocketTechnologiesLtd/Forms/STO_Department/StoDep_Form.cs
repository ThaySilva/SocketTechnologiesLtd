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
    public partial class StoDep_Form : MetroFramework.Forms.MetroForm
    {
        public StoDep_Form()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            DeleveryNoteIn dni = new DeleveryNoteIn();
            dni.Show();
        }
    }
}
