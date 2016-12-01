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
        IProduct LineItemProduct { get; }
        int LineItemQuantity { get; set; }
        double GetLinePrice();

    }
}
