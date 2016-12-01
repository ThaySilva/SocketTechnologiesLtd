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
       string OrderID { get; set; }
        string CustomerID { get; set; }
        DateTime DateCreated { get; set; }
        DateTime DateCompleted { get; set; }
        List<ILineItem> LineItemsList { get; }
        double GetPriceTotal();
        void AddLineItem(IProduct product, int qty);

    }
}
