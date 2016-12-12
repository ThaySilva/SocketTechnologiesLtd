using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessEntities
{
    interface IPurchaseOrderOut
    {
        int PurchaseOderNo { get; set; }

        int QuoteNo { get; set; }
        LineItem LineItem { get; set; }
        float TotalPrice { get; set; }

    }
}
