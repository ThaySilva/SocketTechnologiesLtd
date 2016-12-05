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
        private string productId;
        private string productName;
        private string productDescription;
        private double productPrice;

      //  private List<IProductMaterial> MaterialList;
        #endregion

        #region Instance Properties

        public string ProductId
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

        //private List<IProductMaterial> MaterialList;
        #endregion

        #region Constructor
        public Product()
        {
            throw new System.NotImplementedException();
        }
        public Product(string productId, string productName, string productDescription, double productPrice)
        {
            this.ProductId = productId;
            this.ProductDescription = productName;
            this.ProductDescription = productDescription;
            this.ProductPrice = productPrice;
        }

        public string[] ToStringArray()
        {
            return new String[] { productId, productName, productDescription, productPrice.ToString() };
        }
        #endregion

        //public void AddProductMaterial(IMaterial material, int quantity)
        //{
        //    MaterialList.Add(new ProductMaterial(material, quantity));
        //}
    }
}
