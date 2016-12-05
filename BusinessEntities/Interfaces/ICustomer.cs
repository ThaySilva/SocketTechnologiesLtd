using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessEntities
{
    public interface ICustomer 
    {
        int Customer_ID { get; set; }
        string CustFirstName { get; set; }
        string CustLastName { get; set; }
        string CustCompanyName { get; set; }
        string CustPhoneNum { get; set; }
        string[] CustAddress { get; set; }

    }
}