using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessEntities;

namespace DataAccessLayer
{
    public class DataLayer : IDataLayer
    {
        #region Instance Attributes
        private SqlConnection con;
        DataSet ds;
        SqlDataAdapter da;
        SqlCommandBuilder cb;
        int maxRows;
        #endregion

        #region Static Attributes
        private static IDataLayer dataLayerSingletonInstance;
        static readonly object padlock = new object();
        #endregion

        #region Constructors
        public static IDataLayer GetInstance()
        {
            lock (padlock)
            {
                if (dataLayerSingletonInstance == null)
                    dataLayerSingletonInstance = new DataLayer();

                return dataLayerSingletonInstance;
            }
        }

        private DataLayer()
        {
            OpenConnection();
        }
        #endregion

        public void OpenConnection()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=mssql4.gear.host;Initial Catalog=STLdb;User ID=STLdb;Password=alpha2omega!";
            try
            {
                con.Open();
            }
            catch (System.Exception ex)
            {
                Environment.Exit(0);
            }
        }

        public void CloseConnection()
        {
            con.Close();
        }

        public SqlConnection getConnection()
        {
            return con;
        }

        public List<IUser> getAllUsers()
        {
            List<IUser> UserList = new List<IUser>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT u.user_ID, u.userName, u.password, e.User_user_ID, e.department_ID FROM [dbo].[user] u, employee e WHERE u.user_ID=e.User_user_ID";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "UsersData");
                maxRows = ds.Tables["UsersData"].Rows.Count;
                for (int i = 0; i < maxRows; i++)
                {
                    DataRow dRow = ds.Tables["UsersData"].Rows[i];
                    IUser user = UserFactory.GetUser(dRow.ItemArray.GetValue(0).ToString().Trim(), dRow.ItemArray.GetValue(1).ToString().Trim(), dRow.ItemArray.GetValue(2).ToString().Trim(), dRow.ItemArray.GetValue(3).ToString().Trim());
                    UserList.Add(user);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
            }
            return UserList;
        }
    }
}
