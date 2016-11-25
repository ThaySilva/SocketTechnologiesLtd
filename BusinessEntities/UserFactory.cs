using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class UserFactory
    {
        private static IUser user = null;

        public static IUser GetUser(string userId, string username, string password, string deptId)
        {
            if (user != null)
                return user;
            else
                return new User(userId, username, password, deptId);
        }

        public static void SetUser(IUser aUser)
        {
            user = aUser;
        }
    }
}
