using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessEntities
{
    public class ProductMaterial : IProductMaterial
    {
        #region Instance Properties
        private IMaterial material;
        private int quantity;
        #endregion

        #region Instance Properties
        public IMaterial Material
        {
            get { return material; }
            set { material = value; }
        }

        public int Qty
        {
            get { return quantity; }
            set { quantity = value; }
        }
        #endregion
        public ProductMaterial(IMaterial material, int quantity)
        {
            this.Material = material;
            this.Qty = quantity;

        }

        public string[] ToStringArray()
        {
            return new string[] { material.MatId, material.MatName, material.MatDescription, quantity.ToString() };
        }

    }
}
