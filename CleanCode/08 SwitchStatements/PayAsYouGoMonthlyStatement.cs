using CleanCode.SwitchStatements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode._08_SwitchStatements
{
    public class PayAsYouGoMonthlyStatement : IMonthlyStatement
    {
        public Cost CalculateTotalCost(MonthlyUsage usage)
        {
            float callCost = 0.12f * usage.CallMinutes;
            float smsCost = 0.12f * usage.SmsCount;

            return new Cost
            {
                CallCost = callCost,
                SmsCost = smsCost,
                TotalCost = callCost + smsCost
            };

        }
    }
}
