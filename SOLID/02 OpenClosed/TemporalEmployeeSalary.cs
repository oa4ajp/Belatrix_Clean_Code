using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._02_OpenClosed
{
    public class TemporalEmployeeSalary : ISalary
    {
        public decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }
}
