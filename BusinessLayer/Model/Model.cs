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
        private List<IProduct> customProductList;
        private List<IOrder> orderList;
        private List<IDocument> documentList;
        private List<ILineItem> lineItemList;
        private List<ITechnicalEnquiry> technicalEnquiryList;
        private List<IWorkOrder> workOrderList;
        #endregion

        #region Instance Properties
        public IDataLayer DataLayer
        {
            get { return dataLayer; }
            set { dataLayer = value; }
        }

        public List<ITechnicalEnquiry> TechnicalEnquiryList
        {
            get { return TechnicalEnquiryList; }
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

        public List<IProduct> CustomProductList
        {
            get { return customProductList; }
        }

        public List<IOrder> OrderList
        {
            get { return orderList; }
        }

        public List<IDocument> DocumentList
        {
            get { return documentList; }
        }

        public List<ILineItem> LineItemList
        {
            get { return lineItemList; }
        }

        public List<IWorkOrder> WorkOrderList
        {
            get { return workOrderList; }
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
            customProductList = new List<IProduct>();
            orderList = new List<IOrder>();
            documentList = new List<IDocument>();
            lineItemList = new List<ILineItem>();
            technicalEnquiryList = new List<ITechnicalEnquiry>();
            workOrderList = new List<IWorkOrder>();

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
                GenericFactory<ICustomer>.Register(uid, () => new Customer(Convert.ToInt16(row[0]), row[1], row[2], row[3], row[4], new string[] { row[5], row[6], row[7] }));
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
                GenericFactory<IMaterial>.Register(uid, () => new Material(Convert.ToInt16(row[0]), row[1], row[2], Convert.ToInt16(row[3])));
                IMaterial material = GenericFactory<IMaterial>.Create(uid);
                materialsList.Add(material);
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
                DataLayer.SetCriteria("RawMaterial_ID", "RawMaterial_RawMaterial_ID");
                DataLayer.SetCriteria("STLProduct_STLProduct_ID", row[0]);
                List<string[]> rawMaterials = DataLayer.GetTableData("STLProduct_has_RawMaterial", "RawMaterial", new string[] { "materialName", "Quantity" });
                string[,] materials = new string[rawMaterials.Count,2];
                foreach (String[] mat in rawMaterials)
                {
                    materials[i,0] = mat[0];
                    materials[i,1] = mat[1];
                    i++;
                }
                GenericFactory<IProduct>.Register(uid, () => new Product(Convert.ToInt16(row[0]), row[1], row[2], Convert.ToDouble(row[3]), Convert.ToDouble(row[4]), materials));
                IProduct product = GenericFactory<IProduct>.Create(uid);
                ProductList.Add(product);
                i = 0;
            }
        }

        public void FillCustomProductList()
        {
            List<string[]> customProductData = DataLayer.GetTableData("CustomProduct");

            foreach(String[] row in customProductData)
            {
                Guid uid = Guid.NewGuid();
                GenericFactory<IProduct>.Register(uid, () => new Product(Convert.ToInt16(row[0]), row[1], row[2], Convert.ToInt16(row[3])));
                IProduct customProduct = GenericFactory<IProduct>.Create(uid);
                customProductList.Add(customProduct);
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
                GenericFactory<IDocument>.Register(uid, () => new Document(Convert.ToInt16(row[0]), row[1], DateTime.ParseExact(row[2], "dd/MM/yyyy", null)));
                IDocument doc = GenericFactory<IDocument>.Create(uid);
                DocumentList.Add(doc);
            }
        }

        public void FillDocumentList(string table, bool criteria)
        {
            DataLayer.RemoveCriteria();
            DataLayer.SetCriteria("responded", criteria);
            List<string[]> documentData = DataLayer.GetTableData(table);

            foreach (String[] row in documentData)
            {
                Guid uid = Guid.NewGuid();
                GenericFactory<IDocument>.Register(uid, () => new Document(Convert.ToInt16(row[0]), row[1], DateTime.ParseExact(row[2], "dd/MM/yyyy", null), Convert.ToBoolean(row[3])));
                IDocument doc = GenericFactory<IDocument>.Create(uid);
                DocumentList.Add(doc);
            }
        }

        public void FillLineItemList()
        {
            List<string[]> lineItemData = DataLayer.GetTableData("STL_LineItem");

            foreach (String[] row in lineItemData)
            {
                Guid uid = Guid.NewGuid();
              //  GenericFactory<ILineItem>.Register(uid, () => new LineItem(Convert.ToInt16(row[0]), row[1], row[2], row[3], row[4]));
                ILineItem lineItem = GenericFactory<ILineItem>.Create(uid);
                LineItemList.Add(lineItem);
            }


        }

        public void FillWorkOrderList()
        {
            string[] columns = { "WorkOrder_ID", "dateRequired", "Customer_customer_ID", "Quantity" };
            List<string[]> workOrderData = DataLayer.GetTableData("WorkOrder", columns);

            foreach (String[] row in workOrderData)
            {
                string[] columns1 = { "STLProduct_STLProduct_ID" };
                DataLayer.RemoveCriteria();
                DataLayer.SetCriteria("WorkOrder_WorkOrder_ID", row[0]);
                List<string[]> workOrderData1 = DataLayer.GetTableData("WorkOrder_has_STLProduct", "WorkOrder", columns1);


                foreach (String[] row1 in workOrderData1)
                {
                    Guid uid = Guid.NewGuid();
                    GenericFactory<IWorkOrder>.Register(uid, () => new WorkOrder(Convert.ToInt16(row[0]), Convert.ToInt16(row[2]), Convert.ToInt16(row1[0]), Convert.ToInt16(row[3]), DateTime.ParseExact(row[1], "dd/MM/yyyy", null)));
                    IWorkOrder workOrder = GenericFactory<IWorkOrder>.Create(uid);
                    workOrderList.Add(workOrder);
                }



            }

        }


        #endregion

    }
}
