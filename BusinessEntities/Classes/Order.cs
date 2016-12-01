using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessEntities
{
    public class Order : IOrder

    {
        #region Instance Properties
        private string orderID;
        private string customerID;
        private DateTime dateCreated;
        private DateTime dateCompleted;
        private List<ILineItem> LineItemsList;
        private List<IProductMaterial> MaterialList;
        #endregion


        #region Instance Constructors
        public Order(string orderID, string customerID, DateTime dateCreated, DateTime dateCompleted)
        {
            this.OrderID = orderID;
            this.CustomerID = customerID;
            this.DateCreated = dateCreated;
            this.DateCompleted = dateCompleted;

        }

        public Order(string orderID, string custID, DateTime dateCreated)
        {
            this.OrderID = orderID;
            this.CustomerID = customerID;
            this.DateCreated = dateCreated;
        }
        public string[] ToStringArray()
        {
            return new string[] { orderID, customerID, dateCreated.ToString(), dateCompleted.ToString(), this.GetPriceTotal().ToString() };
        }
        
        public double GetPriceTotal()
        {
            double total = 0;
            foreach(ILineItem item in LineItemsList)
            {
                total += item.GetLinePrice();

            }
            return total;
        }

        public void AddLineItem(IProduct product, int qty)
        {
            // need to figure out what list to use
        //    MaterialList.Add(new LineItem(product, qty));
        }
        #endregion


        #region Instance Properties
        public string OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }
            
        public DateTime DateCompleted
        {
            get { return dateCompleted; }
            set { dateCompleted = value; }
        }

        List<ILineItem> IOrder.LineItemsList
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //public List<ILineItem> LineItemsList
        //{
        //    get { return LineItemsList; }
        //}

        #endregion

    }
}
