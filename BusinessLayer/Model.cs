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
       
        //public Boolean addNewUser()
        //{
        //    try
        //    {
        //        int maxId = 0;
        //        // need some code to avoid dulicate usernames
        //        // maybe add some logic (busiess rules) about password policy
        //        //      IUser user = new User(name, password, userType); // Construct a User Object
        //        foreach (User user in UserList)
        //        {
        //            if (user.UserID > maxId)
        //                maxId = user.UserID;
        //        }
        //        IUser theUser = UserFactory.GetUser(name, password, userType, maxId + 1);   // Using a Factory to create the user entity object. ie seperating object creation from business logic
        //        UserList.Add(theUser);                             // Add a reference to the newly created object to the Models UserList
        //        DataLayer.addNewUserToDB(theUser); //Gets the DataLayer to add the new user to the DB. 
        //        return true;
        //    }
        //    catch (System.Exception excep)
        //    {
        //        return false;
        //    }
        //}
    }
}
