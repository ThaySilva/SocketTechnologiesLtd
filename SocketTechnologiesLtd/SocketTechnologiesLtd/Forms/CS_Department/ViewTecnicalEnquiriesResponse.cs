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
using BusinessEntities;
using DataAccessLayer;


namespace SocketTechnologiesLtd.Forms.CS_Department
{
    public partial class ViewTecnicalEnquiriesResponse : MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private IModel model;
        #endregion
        public ViewTecnicalEnquiriesResponse(IModel _Model)
        {
            InitializeComponent();
           _Model= model  ;
    }

        private void ViewTecnicalEnquiriesList_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

            //string constring = "Data Source=mssql3.gear.host;Initial Catalog=stldb1;User ID=stldb1;Password=alpha2omega!";
            //SqlConnection conDataBase = new SqlConnection(constring);
            ////SqlConnection cmdDataBase = new SqlConnection("select * from stldb1.TechnicalEnquiry ; " ,conDataBase);
            //string sql = "select * from stldb1.TechnicalEnquiry ; ";

            //try
            //{
            //    SqlDataAdapter sda = new SqlDataAdapter(sql, conDataBase);
            //    //sda.SelectCommand = ();
            //    DataTable dbDataset = new DataTable ();
            //    sda.Fill(dbDataset);
            //    BindingSource bSource = new BindingSource();

            //    bSource.DataSource = dbDataset;
            //    dataGridView1.DataSource = bSource;
            //    sda.Update(dbDataset);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
             //response = model.technicalEnquiryList.FirstOrDefault(tech => tech.responded.ToString());
        


            if (cusmetroTextBox1!=null)
            {
                 ICustomer SearchCustomer = model.CustomerList.FirstOrDefault(tech => tech.Customer_ID.ToString() == cusmetroTextBox1.Text.Trim());
              
                if(techmetroTextBox1!=null)
                {
                  
                    //ITechnicalEnquiry SearchEnquiry = model.TechnicalEnquiryList.FirstOrDefault(tech => tech.technicalEnquiry_ID.ToString() == techmetroTextBox1.Text.Trim());
}
                else
                {
                    MessageBox.Show("Technical Enquiry doesn't exist");
                }

            }

            else
            {
                MessageBox.Show("customer doesn't exist");
            }
            
                
            }
        }
    }

