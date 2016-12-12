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
            var data = from cust in model.CustomerList select new String[] { cust.Customer_ID.ToString(), cust.CustFirstName, cust.CustLastName, cust.CustCompanyName, cust.CustAddress[0], cust.CustAddress[1], cust.CustAddress[2]};
            return data.ToList<String[]>();
        }

        //public static void AddCustomer(int customer_ID, string custFirstName, string custLastName, string custCompanyName, string custPhoneNum, string custAddress, string custAddLine2, string custCounty)
        //{
        //    Guid uid = Guid.NewGuid();
        //    GenericFactory<ICustomer>.Register(uid, () => new Customer(customer_ID, custFirstName, custLastName, custCompanyName, custPhoneNum, custAddress, custAddLine2, custCounty));
        //    IEmployee emp = GenericFactory<IEmployee>.Create(uid);
        //    _data.AddRow("Customer", new string[] { "customer_ID","custFirstName", "custLastName","custCompanyName", "custPhoneNum", "custAddress", "custAddLine2","custCounty" }, new string[] { customer_ID.ToString(), custFirstName, custLastName, custCompanyName, custPhoneNum, custAddress, custAddLine2, custCounty });
        //    model.FillCustomerList();
        //}

        //public static void EditCustomer(int customer_ID, string firstName, string lastName, string companyName, string phone, string add1, string add2, string county)
        //{
        //    _data.RemoveCriteria();
        //    _data.SetCriteria("customer_ID", customer_ID.ToString() );
        //    _data.UpdateRowsByKey("customer", new string[] { "custFirstName", "custLastName", "custCompanyName", "custPhoneNum", "custAddress", "custAddLine2", "custCounty" }, new string[] { customer_ID.ToString(), firstName, lastName, companyName, phone, add1, add2, county });

        //    var cus = model.CustomerList.First();
        //    cus.custFirstName = firstName;
        //    cus.custLastName = lastName;
        //    cus.custCompanyName = companyName;
        //    cus.custPhoneNum = phone;
        //    cus.custAddress = add1;
        //    cus.custAddLine2 = add2;
        //    cus.custCounty = county;
        //}

        //public static void DeleteCustomer(int customerID)
        //{
        //    var cust = model.CustomerList.First(c => c.customer_ID == customerID);
            

        //    //if (MessageBox.Show("A Customer is associated with the selected employee, by deleting this employee the user account will also be deleted.\nAre you sure you want to continue?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.No)
        //    //{
        //    //    throw new Exception("Aborting Delete Customer!");
        //    //}
        //    //else
        //    //{
        //        _data.RemoveCriteria();
        //        _data.SetCriteria("customer_ID", customerID.ToString());
        //        _data.DeleteRowByKey("customer");
        //        model.CustomerList.Remove(cust);
        //        int custID = cust.customer_ID;
        //        DeleteCustomer(customerID);
        //    //}
        //}
        #endregion

    }
}
