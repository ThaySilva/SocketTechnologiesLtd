﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessEntities
{
    public interface IProduct 
    {
        int ProductId { get; set; }
        string ProductName { get; set; }
        string ProductDescription { get; set; }
        string ProductInstructions { get; set; }
        double ProductPrice { get; set; }
        double ProductVAT { get; set; }
        int Quantity { get; set; }
        int RFQ_ID { get; set; }
    }
}
