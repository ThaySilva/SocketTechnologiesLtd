using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using DataAccessLayer;

namespace BusinessLayer
{
    public static class CustServices_Rules
    {
        private static IDataLayer _data = DataLayer.GetInstance();
        private static IModel model = Model.GetInstance(_data);

        #region Customer Functions
        public static List<string[]> GetCustomer()
        {
            var data = from cust in model.CustomerList select new String[] { cust.Customer_ID.ToString(), cust.CustFirstName, cust.CustLastName, cust.CustCompanyName, cust.CustAddress[0], cust.CustAddress[1], cust.CustAddress[2] };
            return data.ToList<String[]>();
        }
        #endregion
    }
}
