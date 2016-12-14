using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using DataAccessLayer;

namespace BusinessLayer
{
    public static class Production_Rules
    {
        private static IDataLayer _data = DataLayer.GetInstance();
        private static IModel model = Model.GetInstance(_data);

        #region Production Functions
        public static void DeleteProduct(int productID)
        {
            var prod = model.ProductList.First(p => p.ProductId == productID);
           //need validation
                _data.RemoveCriteria();
                _data.SetCriteria("product_ID", productID.ToString());
                _data.DeleteRowByKey("Product");
                model.ProductList.Remove(prod);
                int prodID = prod.ProductId;
                DeleteProduct(productID);
            
        }
        #endregion
    }
}
