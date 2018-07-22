using CleanCode.SwitchStatements;

namespace CleanCode._08_SwitchStatements
{
    public class UnlimitedMonthlyStatementService : IMonthlyStatementService
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
