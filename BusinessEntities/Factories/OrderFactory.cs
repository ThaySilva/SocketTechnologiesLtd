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

        public static Order GetOrder(String[] orderData, DateTime dateCreated, DateTime dateCompleted)
        {
            return new Order(orderData[0], orderData[1], dateCreated, dateCompleted);
        }

        public static Order GetOrder(string orderID, string custID, DateTime dateCreated)
        {
            return new Order(orderID, custID, dateCreated);
        }

        public static Order GetOrder(string orderId, string customerID, DateTime dateCreated, DateTime dateCompleted)
        {
            return new Order(orderId, customerID, dateCreated, dateCompleted);

        }

        public static void SetOrder(IOrder aOrder)
        {
            order = aOrder;
        }
    }
}
