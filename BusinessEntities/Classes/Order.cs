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
        protected int orderID;
        protected int clientID;
        protected int partNumber;
        protected int quantity;
        protected DateTime dateRequired;
        #endregion

        #region Instance Properties
        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }
        
        public int PartNumber
        {
            get { return partNumber; }
            set { partNumber = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public DateTime DateRequired
        {
            get { return dateRequired; }
            set { dateRequired = value; }
        }
        #endregion

        #region Instance Constructors
        public Order()
        {
            throw new System.NotImplementedException();
        }

        public Order(int _orderID, int _clientID, DateTime _dateRequired)
        {
            this.orderID = _orderID;
            this.clientID = _clientID;
            this.dateRequired = _dateRequired;
        }
        #endregion

    }
}
