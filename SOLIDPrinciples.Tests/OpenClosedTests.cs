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
            string employeeType = "Permanent";
            var employee = new Employee(1, "Test", employeeType);
            employee.SalaryType = GeEmployeeSalaryType(employee);
            employee.GetBonus(1000).Should().Be(100);
        }

        [Fact]
        public void Validate_Temporal_Employee()
        {
            string employeeType = "Temporal";
            var employee = new Employee(1, "Test", employeeType);
            employee.SalaryType = GeEmployeeSalaryType(employee);
            employee.GetBonus(1000).Should().Be(50);
        }

        private ISalary GeEmployeeSalaryType(Employee employee)
        {
            if (employee.EmployeeType == "Permanent")
                return new PermanentEmployeeSalary();
            else
                return new TemporalEmployeeSalary();
        }

    }
}
