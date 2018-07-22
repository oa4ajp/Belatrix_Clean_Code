using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._02_OpenClosed
{
    public class PermanentEmployeeSalary : ISalary
    {
        public decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
}
