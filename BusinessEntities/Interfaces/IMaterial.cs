using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessEntities
{
    public interface IMaterial 
    {
        string MatId { get; set; }
        string MatName { get; set; }
        string MatDescription { get; set; }
    }
}
