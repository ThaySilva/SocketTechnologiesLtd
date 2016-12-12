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
        private List<IDocument> documentList;
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

        public List<IDocument> DocumentList
        {
            get { return documentList; }
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
            documentList = new List<IDocument>();
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
            List<string[]> custData = DataLayer.GetTableData("Customer");

            foreach(String[] row in custData)
            {
                Guid uid = Guid.NewGuid();
                GenericFactory<ICustomer>.Register(uid, () => new Customer(Convert.ToInt16(row[0]), row[1], row[2], row[3], row[4], row[5], row[6], row[7]));
                ICustomer customer = GenericFactory<ICustomer>.Create(uid);
                CustomerList.Add(customer);
            }
        }

        public void FillMaterialsList()
        {
            List<string[]> materialsData = DataLayer.GetTableData("RawMaterial");

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
            int i = 0;
            List<string[]> productData = DataLayer.GetTableData("STLProduct");

            foreach (String[] row in productData)
            {
                Guid uid = Guid.NewGuid();
                DataLayer.RemoveCriteria();
                DataLayer.SetCriteria("RawMaterial_ID", "RawMaterial_ID");
                DataLayer.SetCriteria("STLProduct_STLProduct_ID", row[0]);
                List<string[]> rawMaterials = DataLayer.GetTableData("STLProduct_has_RawMaterial", "RawMaterial", new string[] { "materialName", "Quantity" });
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
            List<string[]> orderData = DataLayer.GetTableData("orders");

            foreach (String[] row in orderData)
            {
                //orderList.Add(OrderFactory.GetOrder(new string[] { row[0], row[1], row[2], row[3] }));
            }
        }

        public void FillDocumentList(string table)
        {
            List<string[]> documentData = DataLayer.GetTableData(table);

            foreach (String[] row in documentData)
            {
                Guid uid = Guid.NewGuid();
                GenericFactory<IDocument>.Register(uid, () => new Document(Convert.ToInt16(row[0]), row[1], DateTime.ParseExact(row[2], "dd/MM/YYYY", null)));
                IDocument doc = GenericFactory<IDocument>.Create(uid);
                DocumentList.Add(doc);
            }
        }
        #endregion

    }
}
