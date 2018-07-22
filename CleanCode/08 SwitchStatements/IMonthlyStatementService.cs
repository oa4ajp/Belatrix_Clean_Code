using CleanCode.SwitchStatements;

namespace CleanCode._08_SwitchStatements
{
    public interface IMonthlyStatementService
    {
        Cost CalculateTotalCost(MonthlyUsage usage);
    }
}
