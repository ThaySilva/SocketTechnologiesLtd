using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessEntities
{
    public class OrderFactory
    {
        private static IOrder order = null;

      public static Order GetOrder(String[] orderData)
        {
            return new BusinessEntities.Order(orderData[0], orderData[1], Convert.ToDateTime(orderData[2]), Convert.ToDateTime(orderData[3]));
        }

        public static void SetOrder(IOrder aOrder)
        {
            order = aOrder;
        }
    }
}
