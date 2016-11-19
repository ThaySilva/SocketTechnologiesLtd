using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IUser
    {
        string UserID { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string DeptID { get; set; }
    }
}
