using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntities;

namespace BusinessLayer
{
    public class IdIncrement
    {
        private static IDataLayer _data = DataLayer.GetInstance();
        private static IModel model = Model.GetInstance(_data);

        private int userId;
        private int employeeId;
        private int customerId;
        private int productId;
        private int lineItemID;

        List<IUser> user = model.UserList;
        List<IEmployee> emp = model.EmployeeList;
        List<ICustomer> cust = model.CustomerList;
        List<IProduct> prod = model.ProductList;
        List<ILineItem> lineItem = model.LineItemList;

        #region UserID
        public int getUserID()
        {
            string id = _data.GetMax("Users", "user_ID");

            if (id != null && id != "")
            {
                int i = (int.Parse(id) + 1);
                return i;
            }
            else
            {
                return 1;
            }

        }
        #endregion

        #region EmployeeID
        public int getEmployeeID()
        {
            string id = _data.GetMax("Employee", "employee_ID");

            if (id != null && id != "")
            {
                int i = (int.Parse(id) + 1);
                return i;
            }
            else
            {
                return 1;
            }

        }
        #endregion

        #region ProductID
        public int getProdId()
        {
            string id = _data.GetMax("STLProduct", "STLProduct_ID");

            if (id != null && id != "")
            {
                int i = (int.Parse(id) + 1);
                return i;
            }
            else
            {
                return 1;
            }
        }

        public int getCustomProdId()
        {
            string id = _data.GetMax("CustomProduct", "CustomProduct_ID");

            if (id != null && id != "")
            {
                int i = (int.Parse(id) + 1);
                return i;
            }
            else
            {
                return 1;
            }
        }
        #endregion

        #region LineID
        public int getLineItemId()
        {
            string id = _data.GetMax("STL_LineItem", "STLLineItem_ID");

            if (id != null && id != "")
            {
                int i = (int.Parse(id) + 1);
                return i;
            }
            else
            {
                return 1;
            }
        }

        #endregion

        #region CustomerID
        public void setCustId()
        {
            customerId = cust[cust.Count() - 1].Customer_ID + 1;
        }

        public int getCustId()
        {
            setCustId();
            return customerId;
        }
        #endregion

        #region Generic ReportID
        public int getReportID(string table)
        {
            string id = _data.GetMax(table, "reportID");

            if (id != null && id != "")
            {
                int i = (int.Parse(id) + 1);
                return i;
            }
            else
            {
                return 1;
            }

        }
        #endregion
       

    }
}
