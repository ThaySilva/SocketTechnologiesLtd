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
using System.Globalization;

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
        private static IDataLayer dataLayerInstance;
        static readonly object padlock = new object();
        #endregion

        #region SQL strings
        private String _criteria;
        private String joins;
        private String sql;
        private String db = "stldb1";
        #endregion 

        #region Constructors
        public static IDataLayer GetInstance()
        {
            lock (padlock)
            {
                if (dataLayerInstance == null)
                    dataLayerInstance = new DataLayer();

                return dataLayerInstance;
            }
        }

        private DataLayer()
        {
            OpenConnection();
        }
        #endregion

        #region Database Connection
        public void OpenConnection()
        {
            con = new SqlConnection();
            //con.ConnectionString = "Data Source=sql3.student.litdom.lit.ie\\Team5;Initial Catalog=stldb;Integrated Security=True;User ID=Team5;Password=5ma5T";    //on college machine
            con.ConnectionString = "Data Source=sql3.student.litdom.lit.ie\\Team5;Initial Catalog=stldb2;Integrated Security=True;User ID=Team5;Password=5ma5T";
            //con.ConnectionString = "Data Source=mssql4.gear.host;Initial Catalog=stldb2;User ID=stldb2;Password=alpha2omega!";        //outside connection
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
        #endregion

        #region Get Table Data
        private List<string[]> GetTable_Data(string table)
        {
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            ds.Locale = CultureInfo.InvariantCulture;

            da.Fill(ds, table);

            List<String[]> outputList = new List<String[]>();

            int numColumns = ds.Tables[table].Columns.Count;
            String[] insertArray;

            foreach (DataRow row in ds.Tables[table].Rows)
            {
                insertArray = new String[numColumns];
                for (int i = 0; i < numColumns; i++)
                {
                    if (row.ItemArray[i] is DateTime)
                        insertArray[i] = ((DateTime)row.ItemArray[i]).ToString("dd/MM/yyyy HH:mm:ss");
                    else
                        insertArray[i] = row.ItemArray[i].ToString();
                }

                outputList.Add(insertArray);
            }


            RemoveCriteria();
            RemoveJoins();

            return outputList;

        }

        public List<string[]> GetTableData(string table)
        {
            sql = "SELECT * FROM " + table;
            sql += joins;
            sql += _criteria;

            return GetTable_Data(table);

        }

        public List<string[]> GetTableData(string table, String[] columns)
        {
            sql = "SELECT ";

            foreach (String colName in columns)
            {
                sql += colName + ", ";
            }

            sql = sql.Substring(0, sql.Length - 2);

            sql += " FROM " + table;
            sql += joins;
            sql += _criteria;

            return GetTable_Data(table);
        }

        public List<string[]> GetTableData(string table, string table2, String[] columns)
        {
            sql = "SELECT ";

            foreach (String colName in columns)
            {
                sql += colName + ", ";
            }

            sql = sql.Substring(0, sql.Length - 2);

            sql += " FROM " + table + "," + table2;
            sql += joins;
            sql += _criteria;

            return GetTable_Data(table);
        }
        #endregion

        #region Add Data to Table
        public void AddRow(string table, string[] columns, string[] values)
        {
            sql = "INSERT INTO " + table + " ("; 

            for(int i = 0; i < columns.Length; i++)
            {
                sql += columns[i] + ", ";
            }

            sql = sql.Substring(0, sql.Length - 2);

            sql += ") VALUES (";

            for(int i = 0; i < values.Length; i++)
            {
                sql += "'" + values[i] + "', ";
            }

            sql = sql.Substring(0, sql.Length - 2);
            sql += ")";

            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            ds.Locale = CultureInfo.InvariantCulture;

            da.Fill(ds, table);
        
        }
        #endregion

        #region Delete Data from Table
    
        public void DeleteRowByKey(string table)
        {
            sql = "DELETE FROM " + table;
            sql += _criteria;

            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            ds.Locale = CultureInfo.InvariantCulture;

            da.Fill(ds, table);
        }
        #endregion

        #region Criteria and Joins
        public void SetCriteria(string column, string criteria)
        {
            if (_criteria == "" || _criteria == null)
            {
                _criteria += " WHERE " + column + "=" + criteria;
            }
            else
            {
                _criteria += " AND " + column + "='" + criteria + "'";
            }
        }

        public void SetCriteria(string column, int criteria)
        {
            if (_criteria == "" || _criteria == null)
            {
                _criteria += " WHERE " + column + "=" + criteria;
            }
            else
            {
                _criteria += " AND " + column + "=" + criteria;
            }
        }

        public void SetCriteria(string column, bool criteria)
        {
            if (_criteria == "" || _criteria == null)
            {
                _criteria += " WHERE " + column + "='" + criteria + "'";
            }
            else
            {
                _criteria += " AND " + column + "=" + criteria;
            }
        }

        public void RemoveCriteria()
        {
            _criteria = "";
        }

        public void SetJoin(string thisTable, string joinedTable, string thisTableColumn, string joinedTableColumn)
        {
            joins += " JOIN " + joinedTable + " ON " + thisTableColumn + "=" + joinedTableColumn + " ";
;       }

        public void RemoveJoins()
        {
            joins = "";
        }

        public string GetMax(string table, string column)
        {
            ds = new DataSet();
            sql = "SELECT MAX(" + column + ") FROM " + table;
            da = new SqlDataAdapter(sql, con);
            da.Fill(ds, table);

            if (ds.Tables[table].Rows[0] != null)
            {
                return ds.Tables[table].Rows[0].ItemArray[0].ToString();
            }
            else
                return null;
            

        }
        #endregion

        #region Update Data in Table
        public void UpdateRowsByKey(string table, string[] columns, string[] values)
        {
            sql = "UPDATE " + table + " SET ";
            
            for(int i = 0; i < columns.Length; i++)
            {
                sql += columns[i] + " = '" + values[i] + "',";
            }

            sql = sql.Substring(0, sql.Length - 1);
            sql += _criteria;

            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            ds.Locale = CultureInfo.InvariantCulture;

            da.Fill(ds, table);

        }
        #endregion
    }
}
