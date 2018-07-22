namespace SOLID._02_OpenClosed
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public abstract decimal CalculateBonus(decimal salary);
    }
}