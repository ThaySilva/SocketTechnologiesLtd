using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class UserFactory
    {
        public static User GetUser(String[] userData)
        {
            return new User(Convert.ToInt32(userData[0]), userData[1], userData[2]);
        }
    }
}
