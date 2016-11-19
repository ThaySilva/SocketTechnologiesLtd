using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntities;

namespace BusinessLayer
{
    public class Model : IModel
    {
        #region Static Attributes
        private static IModel modelSingletonInstance;
        static readonly object padlock = new object();
        #endregion

        #region Instance Attributes
        private IDataLayer dataLayer;
        private IUser currentUser;
        private List<IUser> userList;
        #endregion

        #region Instance Properties
        public IDataLayer DataLayer
        {
            get { return dataLayer; }
            set { dataLayer = value; }
        }

        public IUser CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        public List<IUser> UserList
        {
            get { return userList; }
        }
        #endregion

        #region Constructors and Destructors
        public static IModel GetInstance(IDataLayer DataLayer)
        {
            lock (padlock)
            {
                if (modelSingletonInstance == null)
                    modelSingletonInstance = new Model(DataLayer);
            }
            return modelSingletonInstance;
        }

        private Model(IDataLayer DataLayer)
        {
            userList = new List<IUser>();
            dataLayer = DataLayer;
            userList = dataLayer.getAllUsers();
        }

        ~Model()
        {
            tearDown();
        }
        #endregion

        public Boolean login(String username, String password)
        {
            IUser matchUser = userList.FirstOrDefault(user => user.Username == username && user.Password == password);
            if (matchUser == null)
                return false;
            else
            {
                CurrentUser = matchUser;
                return true;
            }
        }

        public string userDepartment()
        {
            return currentUser.DeptID;
        }

        public void tearDown()
        {
            DataLayer.CloseConnection();
        }
    }
}
