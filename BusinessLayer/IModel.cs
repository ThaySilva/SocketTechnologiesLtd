using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using DataAccessLayer;

namespace BusinessLayer
{
    public interface IModel
    {
        List<IUser> UserList { get; }
        List<IEmployee> EmployeeList { get; }

        void FillEmployeeList();
        void FillUserList();

        //List<ICustomer> CustomerList { get; }

        BusinessEntities.IUser CurrentUser { get; set; }
        //BusinessEntities.Interfaces.ICustomer CurrentCustomer { get; set; }
        DataAccessLayer.IDataLayer DataLayer { get; set; }
        //bool addNewUser(string userId, string userName, string password, string deptId);
        //bool addNewCustomer(string id, string name, string contactName, string contactSurname, string address1, string address2, string address3, string phone, string email);
    }

}
