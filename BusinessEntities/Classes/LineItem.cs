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
        private IProduct product;
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

        public IProduct LineItemProduct
        {
            get { return product; }
            set { product = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double GetLinePrice()
        {
            return linePrice = quantity * product.ProductPrice;
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

        public LineItem(int _lineID, IProduct _product, int _quantity, double _linePrice, double _vat, double _lineTotal)
        {
            this.lineID = _lineID;
            this.product = _product;
            this.quantity = _quantity;
            this.vat = _vat;
        }
        #endregion
    }
}
