using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class CustomerFactory
    {
        private static ICustomer customer = null;

        public static ICustomer GetCustomer(int customerId, string firstName, string lastName, string companyName, string phoneNum, string address)
        {
            if (customer != null)
                return customer;
            else
                return new Customer(customerId, firstName, lastName, companyName, phoneNum, address);
        }

        public static void SetCustomer(ICustomer aCustomer)
        {
            customer = aCustomer;
        }
    }
}
