namespace SOLID._02_OpenClosed
{
    public class Employee
    {
        public int ID { get; set; }
        public string EmployeeType { get; set; }
        public string Name { get; set; }

        public ISalary SalaryType { get; set; }

        public Employee(int id, string name, string type)
        {
            this.ID = id;
            this.Name = name;
            this.EmployeeType = type;
        }

        public decimal GetBonus(decimal salary)
        {        
            return SalaryType.CalculateBonus(salary);                       
        }
    }
}