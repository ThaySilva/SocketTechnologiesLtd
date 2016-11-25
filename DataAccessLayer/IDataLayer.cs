using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace DataAccessLayer
{
    public interface IDataLayer
    {
        void OpenConnection();
        void CloseConnection();
        System.Data.SqlClient.SqlConnection getConnection();
        List<IUser> getAllUsers();
    }
}
