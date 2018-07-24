using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID._03_Liskov_substitution;

namespace SOLIDPrinciples.Tests
{
    [TestClass]
    public class LiskovTests
    {
        [TestMethod]
        public void Test_Standard_Employee()
        {
            var permanentEmployee = new PermanentEmployee(1, "Mendiola");
            permanentEmployee.CalculateBonus(100);
        }

        [TestMethod]
        public void Test_Contract_Employee()
        {
            var contractEmployee = new ContractEmployee(2, "Loyola");
            contractEmployee.ToString();
        }
    }
}
