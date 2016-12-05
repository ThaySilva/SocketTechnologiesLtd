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
        private List<ICustomer> customerList;
        private List<IOrder> orderList;
        private List<IProduct> productList;
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

        public List<IProduct> ProductList
        {
            get { return productList; }
        }

        public List<IUser> UserList
        {
            get { return userList; }
        }

        public List<IEmployee> EmployeeList
        {
            get { return employeeList; }
        }

        public List<ICustomer> CustomerList
        {
            get { return customerList; }
        }

        public List<IOrder> OrderList
        {
            get { return orderList; }
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
            customerList = new List<ICustomer>();
            orderList = new List<IOrder>();
            productList = new List<IProduct>();
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
                Guid uid = Guid.NewGuid();
                GenericFactory<IEmployee>.Register(uid, () => new Employee(Convert.ToInt16(row[0]), row[1], row[2], row[3], Convert.ToInt16(row[4]), Convert.ToInt16(row[5])));
                IEmployee emp = GenericFactory<IEmployee>.Create(uid);
                EmployeeList.Add(emp);
            }
        }

        public void FillUserList()
        {
            userList = new List<IUser>();
            List<string[]> userData = DataLayer.GetTableData("users");

            foreach(String[] row in userData)
            {
                Guid uid = Guid.NewGuid();
                GenericFactory<IUser>.Register(uid, () => new User(Convert.ToInt16(row[0]), row[1], row[2]));
                IUser user = GenericFactory<IUser>.Create(uid);
                UserList.Add(user);
            }
        }

        public void FillCustomerList()
        {
            customerList = new List<ICustomer>();
            List<string[]> custData = DataLayer.GetTableData("Customer");

            foreach(String[] row in custData)
            {
                Guid uid = Guid.NewGuid();
                GenericFactory<ICustomer>.Register(uid, () => new Customer(Convert.ToInt16(row[0]), row[1], row[2], row[3], row[4], new string[] { row[5], row[6], row[7] }));
                ICustomer customer = GenericFactory<ICustomer>.Create(uid);
                CustomerList.Add(customer);
            }
        }

        public void FillOrderList()
        {
            orderList = new List<IOrder>();
            List<string[]> orderData = DataLayer.GetTableData("orders");

            foreach (String[] row in orderData)
            {
                orderList.Add(OrderFactory.GetOrder(new string[] { row[0], row[1], row[2], row[3] }));
            }
        }
        public void FillProductList()
        {
            productList = new List<IProduct>();
            List<string[]> productData = DataLayer.GetTableData("STLProduct");

            foreach (String[] row in productData)
            {
                productList.Add(ProductFactory.GetProduct(new string[] { row[0], row[1], row[2], row[3] }));
            }
        }
        #endregion

    }
}
