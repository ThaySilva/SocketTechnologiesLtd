using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Employee : IEmployee
    {
        #region Instance Properties
        private int employeeId;
        private string firstName;
        private string lastName;
        private string phoneNum;
        private int deptId;
        private int userId;
        #endregion

        #region Instance Properties
        public int EmployeeID
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }

        public int DepartmentID
        {
            get { return deptId; }
            set { deptId = value; }
        }

        public int UserID
        {
            get { return userId; }
            set { userId = value; }
        }
        #endregion

        #region Constructors
        public Employee()
        {
            throw new System.NotImplementedException();
        }

        public Employee(int empId, string name, string surname, string phoneN, int departmentId, int userID)
        {
            this.employeeId = empId;
            this.firstName = name;
            this.lastName = surname;
            this.phoneNum = phoneN;
            this.deptId = departmentId;
            this.userId = userID;
        }
        #endregion
    }
}
