using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessEntities
{
    public interface IOrder 
    {
        int OrderID { get; set; }
        int ClientID { get; set; }
        int PartNumber { get; set; }
        int Quantity { get; set; }
        DateTime DateRequired { get; set; }
    }
}
