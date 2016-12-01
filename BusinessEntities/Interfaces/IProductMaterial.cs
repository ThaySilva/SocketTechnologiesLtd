using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessEntities
{
    public interface IProductMaterial
    {
        int Qty { get; set; }
        IMaterial Material { get; set; }
    }
}
