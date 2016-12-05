using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessEntities
{
    public static class ProductFactory
    {
        private static IProduct product = null;
        public static Product GetProduct(String[] userData)
        {
            return new Product(userData[0], userData[1], userData[2], Convert.ToInt32(userData[3]));
        }

    }
}
