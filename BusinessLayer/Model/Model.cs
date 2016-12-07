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
        private List<IMaterial> materialsList;
        private List<IProduct> productList;
        private List<IOrder> orderList;
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

        public List<ICustomer> CustomerList
        {
            get { return customerList; }
        }

        public List<IMaterial> MaterialsList
        {
            get { return materialsList; }
        }

        public List<IProduct> ProductList
        {
            get { return productList; }
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
            materialsList = new List<IMaterial>();
            productList = new List<IProduct>();
            orderList = new List<IOrder>();
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

        public void FillMaterialsList()
        {
            materialsList = new List<IMaterial>();
            List<string[]> materialsData = DataLayer.GetTableData("RawMaterials");

            foreach(String[] row in materialsData)
            {
                Guid uid = Guid.NewGuid();
                GenericFactory<IMaterial>.Register(uid, () => new Material(Convert.ToInt16(row[0]), row[1], row[2]));
                IMaterial material = GenericFactory<IMaterial>.Create(uid);
                MaterialsList.Add(material);
            }
        }

        public void FillProductList()
        {
            productList = new List<IProduct>();
            int i = 0;
            List<string[]> productData = DataLayer.GetTableData("STLProduct");

            foreach (String[] row in productData)
            {
                Guid uid = Guid.NewGuid();
                DataLayer.RemoveCriteria();
                DataLayer.SetCriteria("RawMaterial_ID", "Materials_RawMaterial_ID");
                DataLayer.SetCriteria("Materials_STLProduct_ID", row[0]);
                List<string[]> rawMaterials = DataLayer.GetTableData("STLProducts_Materials", "RawMaterials", new string[] { "materialName", "Quantity" });
                string[,] materials = new string[rawMaterials.Count,2];
                foreach (String[] mat in rawMaterials)
                {
                    materials[i,0] = mat[0];
                    materials[i,1] = mat[1];
                    i++;
                }
                GenericFactory<IProduct>.Register(uid, () => new Product(Convert.ToInt16(row[0]), row[1], row[2], Convert.ToDouble(row[3]), materials));
                IProduct product = GenericFactory<IProduct>.Create(uid);
                ProductList.Add(product);
                i = 0;
            }
        }

        public void FillOrderList()
        {
            orderList = new List<IOrder>();
            List<string[]> orderData = DataLayer.GetTableData("orders");

            foreach (String[] row in orderData)
            {
                //orderList.Add(OrderFactory.GetOrder(new string[] { row[0], row[1], row[2], row[3] }));
            }
        }
        #endregion

    }
}
