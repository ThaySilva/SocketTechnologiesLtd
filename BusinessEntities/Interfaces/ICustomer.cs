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
        int customer_ID { get; set; }
        string custFirstName { get; set; }
        string custLastName { get; set; }
        string custCompanyName { get; set; }
        string custPhoneNum { get; set; }
        string custAddress { get; set; }
        string custAddLine2 { get; set; }
        string custCounty { get; set; }



    }
}