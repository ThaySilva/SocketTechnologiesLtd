using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWriter
{
    public class IdIncrement
    {
        private static int m_Counter = 0;

        public int Id { get; set; }

        public IdIncrement()
        {
            this.Id = System.Threading.Interlocked.Increment(ref m_Counter);
        }
    }
}
