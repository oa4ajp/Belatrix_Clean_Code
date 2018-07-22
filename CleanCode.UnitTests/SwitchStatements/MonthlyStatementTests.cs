using CleanCode._08_SwitchStatements;
using CleanCode.SwitchStatements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CleanCode.UnitTests.SwitchStatements
{
    [TestClass]
    public class MonthlyStatementTests
    {
        [TestMethod]
        public void PayAsYouGoCustomer_IsChargedBasedOnTheSumOfCostOfCallAndSms()
        {            
            var statement = GetStatement(CustomerType.PayAsYouGo);
            var usage = new MonthlyUsage { CallMinutes = 100, SmsCount = 100 };
            var cost = statement.CalculateTotalCost(usage);

            Assert.AreEqual(12.0f, cost.CallCost);
            Assert.AreEqual(12.0f, cost.SmsCost);
            Assert.AreEqual(24.0f, cost.TotalCost);
        }

        [TestMethod]
        public void UnlimitedCustomer_IsChargedAFlatRatePerMonth()
        {            
            var statement = GetStatement(CustomerType.Unlimited);
            var usage = new MonthlyUsage { CallMinutes = 100, SmsCount = 100 };
            var cost = statement.CalculateTotalCost(usage);

            Assert.AreEqual(0, cost.CallCost);
            Assert.AreEqual(0, cost.SmsCost);
            Assert.AreEqual(54.90f, cost.TotalCost);
        }

        private IMonthlyStatement GetStatement(CustomerType customerType)
        {
            IMonthlyStatement monthlyStatement = null;

            switch (customerType)
            {
                case CustomerType.PayAsYouGo:
                    monthlyStatement = new PayAsYouGoMonthlyStatement();
                    break;

                case CustomerType.Unlimited:
                    monthlyStatement = new UnlimitedMonthlyStatement();                    
                    break;

                default:
                    throw new NotSupportedException("The current customer type is not supported");
            }

            return monthlyStatement;
        }

    }
}
