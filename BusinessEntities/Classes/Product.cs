using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;


namespace BusinessEntities
{
    public class Product : IProduct
    {

        #region Instance Properties
        private int productId;
        private string productName;
        private string productDescription;
        private double productPrice;
        private double productVAT;
        private string[,] productMaterials;
        private int quantity;
        private int rfqId;
        #endregion

        #region Instance Properties
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }

        public double ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }

        public double ProductVAT
        {
            get { return productVAT; }
            set { productVAT = value; }
        }

        public string[,] ProductMaterials
        {
            get { return productMaterials; }
            set { productMaterials = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int RFQ_ID
        {
            get { return rfqId; }
            set { rfqId = value; }
        }
        #endregion

        #region Constructor
        public Product()
        {
            throw new System.NotImplementedException();
        }

        public Product(int prodId, string prodName, string prodDescription, int prodQuantity, int rfq_id)
        {
            this.productId = prodId;
            this.productName = prodName;
            this.productDescription = prodDescription;
            this.quantity = prodQuantity;
            this.rfqId = rfq_id;
        }

        public Product(int prodId, string prodName, string prodDescription, double prodPrice, double prodVAT, string[,] prodMaterials)
        {
            this.productId = prodId;
            this.productName = prodName;
            this.productDescription = prodDescription;
            this.productPrice = prodPrice;
            this.productMaterials = prodMaterials;
            this.ProductVAT = prodVAT;
        }
        #endregion
    }
}
