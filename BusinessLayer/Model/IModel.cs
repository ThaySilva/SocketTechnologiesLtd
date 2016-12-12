using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using DataAccessLayer;

namespace BusinessLayer
{
    public interface IModel
    {
        List<IUser> UserList { get; }
        List<IEmployee> EmployeeList { get; }
        List<ICustomer> CustomerList { get; }
        List<IProduct> ProductList { get; }
        List<IOrder> OrderList { get; }
        List<IDocument> DocumentList { get; }
        List<ILineItem> LineItemList { get; }
        List<IMaterial> MaterialsList { get; }
        void FillEmployeeList();
        void FillUserList();
        void FillCustomerList();
        void FillMaterialsList();
        void FillProductList();
        void FillDocumentList(string table);
        void FillLineItemList();



        BusinessEntities.IUser CurrentUser { get; set; }
        //BusinessEntities.Interfaces.ICustomer CurrentCustomer { get; set; }
        DataAccessLayer.IDataLayer DataLayer { get; set; }
        //bool addNewCustomer(string id, string name, string contactName, string contactSurname, string address1, string address2, string address3, string phone, string email);
    }

}
