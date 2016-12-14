using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class WorkOrder : IWorkOrder
    {
        #region Instance Properties
        private int workOrderID;
        private int customerID;
        private int stlProductID;
        private int quantity;
        private DateTime dateRequired;
        #endregion

        #region Instance Properties
        public int WorkOrderID
        {
            get { return workOrderID; }
            set { workOrderID = value; }
        }

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public int STLproductID
        {
            get { return stlProductID; }
            set { stlProductID = value; }
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
        public WorkOrder()
        {
            throw new System.NotImplementedException();
        }

        public WorkOrder(int _orderID, int _CustID, int _partNum, int _quantity, DateTime _dateRequired)
        {
            this.workOrderID = _orderID;
            this.customerID = _CustID;
            this.stlProductID = _partNum;
            this.quantity = _quantity;
            this.dateRequired = _dateRequired;
        }
        #endregion
    }
}
