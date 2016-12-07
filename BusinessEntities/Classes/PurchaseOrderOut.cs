using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Classes
{
    class PurchaseOrderOut : Order
    {
        #region Instance Properties
        protected int quotationNumber;
        protected LineItem lineItem;
        protected float totalPrice;
        #endregion

        #region Instance Properties
        public int QuotationNumber
        {
            get { return quotationNumber; }
            set { quotationNumber = value; }
        }

        public LineItem _LineItem
        {
            get { return lineItem; }
            set { lineItem = value; }
        }

        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
        #endregion

        #region Intance Constructors
        public PurchaseOrderOut()
        {
            throw new System.NotImplementedException();
        }

        public PurchaseOrderOut(int _orderID, int _quotationNumber, LineItem _lineItem, float _totalPrice)
        {
            this.orderID = _orderID;
            this.quotationNumber = _quotationNumber;
            this.lineItem = _lineItem;
            this.totalPrice = _totalPrice;
        }
        #endregion
    }
}
