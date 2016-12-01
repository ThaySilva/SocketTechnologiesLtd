using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public static class SysAdmin_Rules
    {
        private static IDataLayer _data = DataLayer.GetInstance();
        private static IModel model = Model.GetInstance(_data);

        #region Employee Functions
        public static List<string[]> GetEmployeeList()
        {
            var data = from emp in model.EmployeeList select new String[] { emp.EmployeeID.ToString(), emp.FirstName, emp.LastName, emp.PhoneNumber, emp.DepartmentID.ToString() };
            return data.ToList<String[]>();
        }

        public static void AddEmployee(int employeeID, string firstName, string lastName, string phoneNum, int deptId, int userId)
        {
            _data.AddRow("Employee", new string[] { employeeID.ToString(), firstName, lastName, phoneNum, deptId.ToString(), userId.ToString() });
            model.FillEmployeeList();
        }

        public static void EditEmployee(int employeeID, string firstName, string lastName, string phoneNum, int deptId)
        {
            _data.RemoveCriteria();
            _data.SetCriteria("employee_ID", employeeID.ToString());
            _data.UpdateRowsByKey("Employee", new string[] { "empFirstName", "empLastName", "empPhoneNum", "department_ID" }, new string[] { firstName, lastName, phoneNum, deptId.ToString()});

            var emp = model.EmployeeList.First(e => e.EmployeeID == employeeID);
            emp.FirstName = firstName;
            emp.LastName = lastName;
            emp.PhoneNumber = phoneNum;
            emp.DepartmentID = deptId;
        }
        #endregion

        #region Users Functions
        public static List<string[]> GetUserList()
        {
            var data = from user in model.UserList select new String[] { user.UserID.ToString(), user.Username, user.Password};
            return data.ToList<String[]>();
        }

        public static void AddUser(int userId, string username, string password)
        {
            _data.AddRow("Users", new string[] { userId.ToString(), username, password});
            model.FillUserList();
        }

        public static void EditUser(int userId, string username, string password)
        {
            _data.RemoveCriteria();
            _data.SetCriteria("user_ID", userId.ToString());
            _data.UpdateRowsByKey("Users", new string[] {"userName", "password" }, new string[] { username, password });

            var user = model.UserList.First(u => u.UserID == userId);
            user.Username = username;
            user.Password = password;
        }
        #endregion
    }
}
