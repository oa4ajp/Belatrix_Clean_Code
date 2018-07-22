using CleanCode.SwitchStatements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode._08_SwitchStatements
{
    public interface IMonthlyStatement
    {
        Cost CalculateTotalCost(MonthlyUsage usage);
    }
}
