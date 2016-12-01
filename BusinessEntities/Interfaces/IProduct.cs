using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessEntities
{
    public interface IProduct 
    {
        string ProductId { get; set; }
        string ProductName { get; set; }
        string ProductDescription { get; set; }
        double ProductPrice { get; set; }
        List<IProductMaterial> MaterialList { get; set; }
        void AddProductMaterial(IMaterial material, int quantity);


    }
}
