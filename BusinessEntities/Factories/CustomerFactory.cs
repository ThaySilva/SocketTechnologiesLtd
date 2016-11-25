using BusinessEntities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Factories
{
    public class CustomerFactory
    {
        public static Customer GetCustomer(String[] custData)
        {
            return new Customer(custData[0], custData[1], custData[2], custData[3], custData[4], custData[5], custData[6], custData[7], custData[8]);
        }
    }
}
