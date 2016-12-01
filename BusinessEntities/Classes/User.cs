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
        private int userId;
        private string username;
        private string password;
        #endregion

        #region Instance Properties
        public int UserID
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

        #endregion

        #region Constructors
        public User()
        {
            throw new System.NotImplementedException();
        }

        public User(int userId, string username, string password)
        {
            this.UserID = userId;
            this.Username = username;
            this.Password = password;
        }
        #endregion
    }
}
