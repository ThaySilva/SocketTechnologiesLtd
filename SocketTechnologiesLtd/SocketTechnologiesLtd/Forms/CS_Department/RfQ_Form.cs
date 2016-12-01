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
    public partial class RfQ_Form : MetroFramework.Forms.MetroForm
    {
        public RfQ_Form()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;

            populate_view();

            int index = lstView_standard.CurrentCell.RowIndex;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void populate_view()
        {
            DataTable items = new DataTable("Items");

            DataColumn c0 = new DataColumn("STL P/N");
            DataColumn c1 = new DataColumn("Name");

            items.Columns.Add(c0);
            items.Columns.Add(c1);

            DataRow row, row1, row2;

            row = items.NewRow();
            row["STL P/N"] = "STL0001";
            row["Name"] = "Terminal Carriers (6000 Series)";

            row1 = items.NewRow();
            row1["STL P/N"] = "STL0002";
            row1["Name"] = "Burn-in-boards";

            row2 = items.NewRow();
            row2["STL P/N"] = "STL0003";
            row2["Name"] = "Terminal Carriers (3000 Series)";

            items.Rows.Add(row);
            items.Rows.Add(row1);
            items.Rows.Add(row2);

            lstView_standard.DataSource = items;
            
        }
    }
}
