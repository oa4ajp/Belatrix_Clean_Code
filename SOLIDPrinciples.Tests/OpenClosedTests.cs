using SOLID._02_OpenClosed;
using Xunit;
using FluentAssertions;

namespace SOLIDPrinciples.Tests
{
    public class OpenClosedTests
    {
        [Fact]
        public void Validate_Permanent_Employee()
        {            
            var employee = EmployeeFactory.GetEmployee(EmployeeType.Permanent, 1, "Test");            
            employee.CalculateBonus(1000).Should().Be(100);
        }

        [Fact]
        public void Validate_Temporary_Employee()
        {
            var employee = EmployeeFactory.GetEmployee(EmployeeType.Temporary, 1, "Test");            
            employee.CalculateBonus(1000).Should().Be(50);
        }

    }
}
