using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntities;
using BusinessLayer;

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
        private List<IEmployee> employeeList;
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

        public List<IEmployee> EmployeeList
        {
            get { return employeeList; }
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
            employeeList = new List<IEmployee>();
            dataLayer = DataLayer;
        }

        ~Model()
        {
            tearDown();
        }
        
        public void tearDown()
        {
            DataLayer.CloseConnection();
        }
        #endregion

        #region Fill Lists
        public void FillEmployeeList()
        {
            employeeList = new List<IEmployee>();
            List<string[]> employeeData = DataLayer.GetTableData("employee");

            foreach (String[] row in employeeData)
            {
                EmployeeList.Add(EmployeeFactory.GetEmployee(new string[] { row[0], row[1], row[2], row[3], row[4], row[5] }));
            }
        }

        public void FillUserList()
        {
            userList = new List<IUser>();
            List<string[]> userData = DataLayer.GetTableData("users");

            foreach(String[] row in userData)
            {
                userList.Add(UserFactory.GetUser(new string[] { row[0], row[1], row[2]}));
            }
        }
        #endregion

    }
}
