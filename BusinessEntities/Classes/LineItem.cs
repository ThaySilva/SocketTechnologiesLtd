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
        private IProduct product;
        private int quantity;
        private double linePrice;
        #endregion

        #region Instance Properties
        public IProduct LineItemProduct
        {
            get { return product; }
            set { product = value; }
        }
        public int LineItemQuantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        #endregion

        #region Constructor
        public LineItem()
        {
            throw new System.NotImplementedException();
        }
        public LineItem(IProduct product, int quantity, double linePrice)
        {
            this.LineItemProduct = product;
            this.LineItemQuantity = quantity;
        }

        public double GetLinePrice()
        {
            return linePrice = quantity * product.ProductPrice;
        }

        public string[] ToStringArray()
        {
            return new string[] { product.ProductId.ToString(), quantity.ToString(), this.GetLinePrice().ToString() };
        }
        #endregion
    }
}
