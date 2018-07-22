using CleanCode.SwitchStatements;

namespace CleanCode._08_SwitchStatements
{
    public class PayAsYouGoMonthlyStatementService : IMonthlyStatementService
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
