using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessEntities
{
    public interface ILineItem 
    {
        int LineID { get; set; }
        int LineItemProductID { get; set; }
        double UnitPrice { get; set; }
        int Quantity { get; set; }
        double GetLinePrice();
        double VAT { get; set; }
        double GetLineTotal();

    }
}
