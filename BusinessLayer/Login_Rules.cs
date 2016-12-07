using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public static class Login_Rules
    {
        private static IDataLayer _data = DataLayer.GetInstance();
        private static IModel model = Model.GetInstance(_data);

        public static void FillModel()
        {
            model.FillEmployeeList();
            model.FillUserList();
            model.FillCustomerList();
            model.FillMaterialsList();
            model.FillProductList();
        }

        public static string ProcessLogin(string username, string password)
        {
            _data.SetCriteria("user_ID", "User_user_ID");
            _data.SetCriteria("userName", username);
            _data.SetCriteria("password", password);
            
            List<String[]> data = _data.GetTableData("Users", "Employee", new String[] { "department_ID" });
            if (data.Count != 1)
                return null;
            else
            {
                return data[0][0];
            }
        }
    }
}
