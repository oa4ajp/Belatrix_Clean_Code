using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._02_OpenClosed
{
    public class EmployeeFactory
    {
        public static Employee GetEmployee(EmployeeType employeeType, int id, string name)
        {
            switch (employeeType)
            {
                case EmployeeType.Permanent:
                    return new PermanentEmployee(id, name);
                case EmployeeType.Temporary:
                    return new TemporaryEmployee(id, name);
                default:
                    return null;
            }
        }
    }

    public enum EmployeeType {
        Permanent = 1,
        Temporary = 2
    }
}
