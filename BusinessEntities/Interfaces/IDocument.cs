using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IDocument
    {
        int DocumentID { get; set; }
        string DocumentPath { get; set; }
        DateTime DateCreated { get; set; }
        bool Response { get; set; }
    }
}
