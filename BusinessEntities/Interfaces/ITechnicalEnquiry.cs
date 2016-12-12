using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessEntities
{
    public interface ITechnicalEnquiry
    {
        int technicalEnquiry_ID { get; set; }
        string enquiryText { get; set; }
        int responded { get; set; }
        int accepted { get; set; }
        DateTime dateCreated { get; set; }
        int customer_customer_ID { get; set; }
    }
}
