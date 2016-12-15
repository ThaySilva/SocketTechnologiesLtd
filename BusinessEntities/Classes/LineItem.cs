using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessEntities
{
    public class LineItem : ILineItem
    {

        #region Instance Properties
        private int lineID;
        private int productID;
        private double unitPrice;
        private int quantity;
        private double linePrice;
        private double vat;
        private double lineTotal;
        #endregion

        #region Instance Properties
        public int LineID
        {
            get { return lineID; }
            set { lineID = value; }
        }

        public int LineItemProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        public double UnitPrice
        {
            get { return unitPrice; }
            set{ unitPrice = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double GetLinePrice()
        {
            return linePrice = quantity * unitPrice;
        }

        public double VAT
        {
            get { return vat; }
            set { vat = value; }
        }

        public double GetLineTotal()
        {
            return lineTotal = linePrice + vat;
        }
       
        #endregion

        #region Constructor
        public LineItem()
        {
            throw new System.NotImplementedException();
        }

        public LineItem(int _quantity, double _unitPrice,  double _linePrice, double _vat, int _productId)
        {
            this.productID = _productId;
            this.unitPrice = _unitPrice;
            this.quantity = _quantity;
            this.vat = _vat;
        }
        public LineItem(int _lineID, int _quantity, double _unitPrice, double _linePrice, double _vat, int _productId)
        {
            this.lineID = _lineID;
            this.productID = _productId;
            this.unitPrice = _unitPrice;
            this.quantity = _quantity;
            this.vat = _vat;
        }
        public LineItem(int _lineID, int _productId, double _unitPrice, int _quantity, double _linePrice, double _vat, double _lineTotal)
        {
            this.lineID = _lineID;
            this.productID = _productId;
            this.unitPrice = _unitPrice;
            this.quantity = _quantity;
            this.vat = _vat;
        }
        #endregion
    }
}
