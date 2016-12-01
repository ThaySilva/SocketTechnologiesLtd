using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class EmployeeFactory
    {
        public static Employee GetEmployee(String[] empData)
        {
            return new Employee(Convert.ToInt32(empData[0]), empData[1], empData[2], empData[3], Convert.ToInt32(empData[4]), Convert.ToInt32(empData[5]));
        }
    }
}
