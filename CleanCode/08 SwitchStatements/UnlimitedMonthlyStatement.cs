using CleanCode.SwitchStatements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode._08_SwitchStatements
{
    public class UnlimitedMonthlyStatement : IMonthlyStatement
    {
        public Cost CalculateTotalCost(MonthlyUsage usage)
        {
            return new Cost
            {
                CallCost = 0.0f,
                SmsCost = 0.0f,
                TotalCost = 54.90f
            };
        }
    }
}
