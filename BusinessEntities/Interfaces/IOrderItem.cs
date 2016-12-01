using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessEntities
{
    public interface IOrderItem 
    {
        IProduct OrderItemProduct { get; }
        int Quantity { get; set; }
        double GetLinePrice();

    }
}
