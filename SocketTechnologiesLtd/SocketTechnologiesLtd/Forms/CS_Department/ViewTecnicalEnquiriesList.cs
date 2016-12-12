using System;
using System.Data.SqlClient;
using BusinessEntities;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SocketTechnologiesLtd.Forms.CS_Department
{
    public partial class ViewTecnicalEnquiriesList : MetroFramework.Forms.MetroForm
    {
        public ViewTecnicalEnquiriesList()
        {
            InitializeComponent();
          
    }

        private void ViewTecnicalEnquiriesList_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

            string constring = "Data Source=mssql3.gear.host;Initial Catalog=stldb1;User ID=stldb1;Password=alpha2omega!";
            SqlConnection conDataBase = new SqlConnection(constring);
            //SqlConnection cmdDataBase = new SqlConnection("select * from stldb1.TechnicalEnquiry ; " ,conDataBase);
            string sql = "select * from stldb1.TechnicalEnquiry ; ";

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, conDataBase);
                //sda.SelectCommand = ();
                DataTable dbDataset = new DataTable ();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbDataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
