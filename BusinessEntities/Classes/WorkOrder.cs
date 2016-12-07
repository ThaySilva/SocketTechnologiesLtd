using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Classes
{
    class WorkOrder : Order
    {
        #region Instance Properties
        private int customerPurOrderID;
        #endregion

        #region Instance Properties
        public int CustomerPurOrderID
        {
            get { return customerPurOrderID; }
            set { customerPurOrderID = value; }
        }
        #endregion

        #region Instance Constructors
        public WorkOrder()
        {
            throw new System.NotImplementedException();
        }

        public WorkOrder(int _orderID, int _CPOID, int _partNum, int _quantity, DateTime _dateRequired)
        {
            this.orderID = _orderID;
            this.customerPurOrderID = _CPOID;
            this.partNumber = _partNum;
            this.quantity = _quantity;
            this.dateRequired = _dateRequired;
        }
        #endregion
    }
}
