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

        List<IUser> user = model.UserList;
        List<IEmployee> emp = model.EmployeeList;

        #region UserID
        public void setUserId()
        {
            userId = user[user.Count - 1].UserID + 1;
        }
        public int getUserId()
        {
            setUserId();
            return userId;
        }
        #endregion

        #region EmployeeID
        public void setEmpId()
        {
            employeeId = emp[emp.Count() - 1].EmployeeID + 1;
        }

        public int getEmpId()
        {
            setEmpId();
            return employeeId;
        }
        #endregion
    }
}
