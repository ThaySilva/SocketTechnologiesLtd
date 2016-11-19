using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class User : BusinessEntities.IUser
    {
        #region Instance Properties
        private string userId;
        private string username;
        private string password;
        private string deptId;
        #endregion

        #region Instance Properties
        public string UserID
        {
            get { return userId; }
            set { userId = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string DeptID
        {
            get { return deptId; }
            set { deptId = value; }
        }
        #endregion

        #region Constructors
        public User()
        {
            throw new System.NotImplementedException();
        }

        public User(string userId, string username, string password, string deptId)
        {
            this.UserID = userId;
            this.Username = username;
            this.Password = password;
            this.DeptID = deptId;
        }
        #endregion
    }
}
