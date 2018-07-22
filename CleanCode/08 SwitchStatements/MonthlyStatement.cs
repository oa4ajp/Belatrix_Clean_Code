using CleanCode.SwitchStatements;
using System;

namespace CleanCode._08_SwitchStatements
{
    public class MonthlyStatement
    {
        private IMonthlyStatementService MonthlyStatementService { get; set; }
        public float CallCost { get; set; }
        public float SmsCost { get; set; }
        public float TotalCost { get; set; }       

        public void Generate(MonthlyUsage usage)
        {
            SetStatementService(usage.Customer.Type);
            var cost = MonthlyStatementService.CalculateTotalCost(usage);
            CallCost = cost.CallCost;
            SmsCost = cost.SmsCost;
            TotalCost = CallCost + SmsCost;
        }

        private void SetStatementService(CustomerType customerType)
        {
            switch (customerType)
            {
                case CustomerType.PayAsYouGo:
                    MonthlyStatementService = new PayAsYouGoMonthlyStatementService();
                    break;

                case CustomerType.Unlimited:
                    MonthlyStatementService = new UnlimitedMonthlyStatementService();
                    break;

                default:
                    throw new NotSupportedException("The current customer type is not supported");
            }
        }
    }
}
