using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using BusinessLayer;
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
            Guid uid = Guid.NewGuid();
            GenericFactory<IEmployee>.Register(uid, () => new Employee(employeeID, firstName, lastName, phoneNum, deptId, userId));
            IEmployee emp = GenericFactory<IEmployee>.Create(uid);
            _data.AddRow("Employee",new string[] { "empFirstName", "empLastName", "empPhoneNum", "department_ID", "User_user_ID" }, new string[] { firstName, lastName, phoneNum, deptId.ToString(), userId.ToString() });
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

        public static void DeleteEmployee(int employeeID)
        {
            var emp = model.EmployeeList.First(e => e.EmployeeID == employeeID);
            var user = model.UserList.First(u => u.UserID == emp.UserID);

            if (MessageBox.Show("An user is associated with the selected employee, by deleting this employee the user account will also be deleted.\nAre you sure you want to continue?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                throw new Exception("Aborting Delete Employee!");
            }
            else
            {
                _data.RemoveCriteria();
                _data.SetCriteria("employee_ID", employeeID.ToString());
                _data.DeleteRowByKey("Employee");
                model.EmployeeList.Remove(emp);
                int userID = user.UserID;
                DeleteUser(userID);
            }
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
            Guid uid = Guid.NewGuid();
            GenericFactory<IUser>.Register(uid, () => new User(userId, username, password));
            IUser user = GenericFactory<IUser>.Create(uid);
            _data.AddRow("Users", new string[] {"userName", "password" }, new string[] { username, password});
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

        private static void DeleteUser(int userID)
        {
            var user = model.UserList.First(u => u.UserID == userID);
            _data.RemoveCriteria();
            _data.SetCriteria("user_ID", userID.ToString());
            _data.DeleteRowByKey("Users");
            model.UserList.Remove(user);
        }
        #endregion

        #region CustomerOrders Functions

        #endregion
    }
}
