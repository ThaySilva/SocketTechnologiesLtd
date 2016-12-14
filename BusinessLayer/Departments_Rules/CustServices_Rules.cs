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

        public static void AddCustomer(int customer_ID, string custFirstName, string custLastName, string custCompanyName, string custPhoneNum, string[] custAddress)
        {
            Guid uid = Guid.NewGuid();
            GenericFactory<ICustomer>.Register(uid, () => new Customer(customer_ID, custFirstName, custLastName, custCompanyName, custPhoneNum, custAddress));
            IEmployee emp = GenericFactory<IEmployee>.Create(uid);
            _data.AddRow("Customer", new string[] { "customer_ID", "custFirstName", "custLastName", "custCompanyName", "custPhoneNum", "custAddress" }, new string[] { customer_ID.ToString(), custFirstName, custLastName, custCompanyName, custPhoneNum });
            model.FillCustomerList();
        }
        public static void EditCustomer(int customer_ID, string custFirstName, string custLastName, string custCompanyName, string custPhoneNum, string[] custAddress)
        {
            _data.RemoveCriteria();
            _data.SetCriteria("customer_ID", customer_ID.ToString());
            _data.UpdateRowsByKey("Customer", new string[] { "customer_ID", "custFirstName", "custLastName", "custCompanyName", "custPhoneNum", "custAddress" }, new string[] { customer_ID.ToString(), custFirstName, custLastName, custCompanyName, custPhoneNum });

            var cus = model.CustomerList.First();
            cus.CustFirstName = custFirstName;
            cus.CustLastName = custLastName;
            cus.CustCompanyName = custCompanyName;
            cus.CustPhoneNum = custPhoneNum;
            cus.CustAddress = custAddress;
        }

        public static void DeleteCustomer(int customerID)
        {
            var cust = model.CustomerList.First(c => c.Customer_ID == customerID);



            _data.RemoveCriteria();
            _data.SetCriteria("customer_ID", customerID.ToString());
            _data.DeleteRowByKey("Customer");
            model.CustomerList.Remove(cust);
            int custID = cust.Customer_ID;
            DeleteCustomer(customerID);
        }
        #endregion

        #region Custom Product Functions
        public static void AddCustomProduct(int prodId, string productName, string productDescription, int quantity, int rfqId)
        {
            Guid uid = Guid.NewGuid();
            GenericFactory<IProduct>.Register(uid, () => new Product(prodId, productName, productDescription, quantity, rfqId));
            IProduct prod = GenericFactory<IProduct>.Create(uid);
            _data.AddRow("CustomProduct", new string[] { "CustomProduct_ID", "productName", "manufacturingInstructions", "quantity", "Rfq_ID" }, new string[] { prodId.ToString(), productName, productDescription, quantity.ToString(), rfqId.ToString()});
            model.FillUserList();
        }

        public static void DeleteCustomProduct(string prodName)
        {
            var prod = model.CustomProductList.First(p => p.ProductName == prodName);
            _data.RemoveCriteria();
            _data.SetCriteria("CustomProduct_ID", prodName);
            _data.DeleteRowByKey("CustomProduct");
            model.CustomProductList.Remove(prod);
        }
        #endregion

        #region Get Production Process from Lot Traveller
        public static string GetProductionStage(int workOrderID)
        {
            _data.RemoveCriteria();
            _data.SetCriteria("WorkOrder_WorkOrder_ID", workOrderID);
            string[] columns1 = { "Lot_Lot_ID" };
            List<string[]> workorderid = _data.GetTableData("WorkOrder_has_Lot", columns1);

            foreach (String[] row1 in workorderid)
            {
                _data.RemoveCriteria();
                _data.SetCriteria("Lot_ID", row1[0]);
                string[] columns2 = { "LotTraveller_LotTraveller_ID" };
                List<string[]> lottravellerid = _data.GetTableData("Lot", columns2);

                foreach (String[] row2 in lottravellerid)
                {
                    return row2[0].ToString();
                }
            }

            return "0";

        }
        #endregion
    }
}
