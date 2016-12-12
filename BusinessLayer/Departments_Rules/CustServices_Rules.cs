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
            var data = from cust in model.CustomerList select new String[] { cust.customer_ID.ToString(), cust.custFirstName, cust.custLastName, cust.custCompanyName, cust.custAddress, cust.custAddLine2, cust.custCounty };
            return data.ToList<String[]>();
        }
        public static void AddCustomer(int customer_ID, string custFirstName, string custLastName, string custCompanyName, string custPhoneNum, string custAddress, string custAddLine2, string custCounty)
        {
            Guid uid = Guid.NewGuid();
            GenericFactory<ICustomer>.Register(uid, () => new Customer(customer_ID, custFirstName, custLastName, custCompanyName, custPhoneNum, custAddress, custAddLine2, custCounty));
            IEmployee emp = GenericFactory<IEmployee>.Create(uid);
            _data.AddRow("Customer", new string[] { "customer_ID","custFirstName", "custLastName","custCompanyName", "custPhoneNum", "custAddress", "custAddLine2","custCounty" }, new string[] { customer_ID.ToString(), custFirstName, custLastName, custCompanyName, custPhoneNum, custAddress, custAddLine2, custCounty });
            model.FillCustomerList();
        }

        //public static void EditCustomer()
        //{
        //    _data.RemoveCriteria();
        //    _data.SetCriteria("", );
        //    _data.UpdateRowsByKey("", new string[] { "", "", "", "" }, new string[] { });

        //    var emp = model..First();
        //    emp.FirstName = firstName;
        //    emp.LastName = lastName;
        //    emp.PhoneNumber = phoneNum;
        //    emp.DepartmentID = deptId;
        //}

        //public static void DeleteCustomer(int customerID)
        //{
        //    var emp = model.EmployeeList.First(e => e.EmployeeID == employeeID);
        //    var user = model.UserList.First(u => u.UserID == emp.UserID);

        //    if (MessageBox.Show("An user is associated with the selected employee, by deleting this employee the user account will also be deleted.\nAre you sure you want to continue?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.No)
        //    {
        //        throw new Exception("Aborting Delete Employee!");
        //    }
        //    else
        //    {
        //        _data.RemoveCriteria();
        //        _data.SetCriteria("employee_ID", employeeID.ToString());
        //        _data.DeleteRowByKey("Employee");
        //        model.EmployeeList.Remove(emp);
        //        int userID = user.UserID;
        //        DeleteUser(userID);
        //    }
        //}
        #endregion

    }
}
