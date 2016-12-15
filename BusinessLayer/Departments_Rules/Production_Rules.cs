using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using DataAccessLayer;

namespace BusinessLayer
{
    public static class Production_Rules
    {
        private static IDataLayer _data = DataLayer.GetInstance();
        private static IModel model = Model.GetInstance(_data);

        #region Production Functions
        public static void DeleteProduct(int productID)
        {
            var prod = model.ProductList.First(p => p.ProductId == productID);
           //need validation
                _data.RemoveCriteria();
                _data.SetCriteria("STLProduct_ID", productID.ToString());
                _data.DeleteRowByKey("STLProduct");
                model.ProductList.Remove(prod);
                int prodID = prod.ProductId;
                DeleteProduct(productID);
            
        }

        public static void EditProduct(int productID, string productName, string productInstructions, double Prodprice, double vat)
        {
            _data.RemoveCriteria();
            _data.SetCriteria("STLProduct_ID", productID.ToString());
            _data.UpdateRowsByKey("STLProduct", new string[] { "STLProduct_ID", "productName", "manufacturingInstructions", "productPrice", "VAT" }, new string[] { productID.ToString(),productName,productInstructions, Prodprice.ToString(), vat.ToString() });

            var prod = model.ProductList.First(p => p.ProductId == productID);
            prod.ProductName = productName;
            prod.ProductInstructions = productInstructions;
            prod.ProductPrice = Prodprice;
            prod.ProductVAT = vat;
        }

        public static void AddProduct(int prodID, string prodName, string prodInstructions, double price, double vat)
        {
            Guid uid = Guid.NewGuid();
            GenericFactory<IProduct>.Register(uid, () => new Product(prodID, prodName, prodInstructions, price, vat));
            ILineItem line = GenericFactory<ILineItem>.Create(uid);
            _data.AddRow("STLProduct", new string[] { "STLProduct_ID", "productName", "manufacturingInstructions", "productPrice", "VAT" }, new string[] {prodID.ToString(), prodName, prodInstructions, price.ToString(), vat.ToString()});
            model.FillProductList();

        }
        public static void AddLineItem(int lineid, int qty, double unitPrice,  double linePrice, double vat, int productID)
        {
            Guid uid = Guid.NewGuid();
            GenericFactory<ILineItem>.Register(uid, () => new LineItem( lineid, qty, unitPrice, linePrice, vat, productID));
            ILineItem line = GenericFactory<ILineItem>.Create(uid);
            _data.AddRow("STL_LineItem", new string[] { "Quantity", "UnitPrice",  "LinePrice", "VAT", "STLProduct_ID" }, new string[] {  qty.ToString(), unitPrice.ToString(), linePrice.ToString(), vat.ToString(), productID.ToString() });
            model.FillLineItemList();
            
        }

        public static void DeleteLineItem(int lineid)
        {
            var line = model.LineItemList.First(l => l.LineID == lineid);

            _data.RemoveCriteria();
            _data.SetCriteria("STLLineItem_ID", lineid.ToString());
            _data.DeleteRowByKey("STL_LineItem");
            model.LineItemList.Remove(line);


        }

        //public static void AddWorkOrder(int orderID, int custID, int prodID, int qty, DateTime dateReq)
        //{
        //    Guid uid = Guid.NewGuid();
        //    GenericFactory<IWorkOrder>.Register(uid, () => new WorkOrder(orderID, custID, prodID, qty, dateReq));
        //    ILineItem line = GenericFactory<ILineItem>.Create(uid);
        //    _data.AddRow("WorkOrder", new string[] { "WorkOrder_ID", "Customer_customer_ID", "STLProductID", "Quantity", "dateRequired" }, new string[] 
        //    { orderID.ToString(), custID.ToString(), prodID.ToString(), qty.ToString(), dateReq.ToString() });
        //    model.FillLineItemList();

        //}
        
        //CUSTOMER PURCHASE ORDER
        
        //public static void AddCPOOrder(int orderID, int custID, int prodID, int qty, DateTime dateReq)
        //{
        //    Guid uid = Guid.NewGuid();
        //    GenericFactory<IWorkOrder>.Register(uid, () => new WorkOrder(orderID, custID, prodID, qty, dateReq));
        //    ILineItem line = GenericFactory<ILineItem>.Create(uid);
        //    _data.AddRow("WorkOrder", new string[] { "WorkOrder_ID", "Customer_customer_ID", "STLProductID", "Quantity", "dateRequired" }, new string[]
        //    { orderID.ToString(), custID.ToString(), prodID.ToString(), qty.ToString(), dateReq.ToString() });
        //    model.FillLineItemList();

        //}
        #endregion
    }
}
