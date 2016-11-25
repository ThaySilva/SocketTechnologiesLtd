using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessLayer
{
    public interface IModel
    {
        bool login(string username, string password);
        List<IUser> UserList { get; }
        string userDepartment();
        BusinessEntities.IUser CurrentUser { get; set; }
        DataAccessLayer.IDataLayer DataLayer { get; set; }
    }

}
