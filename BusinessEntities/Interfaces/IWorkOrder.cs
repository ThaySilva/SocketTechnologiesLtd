using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class IWorkOrder
    {
        int WorkOrderID { get; set; }
        int CustomerID { get; set; }
        int STLProductID { get; set; }
        int Quantity { get; set; }
        DateTime DateRequired { get; set; }
    }
}
