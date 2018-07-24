using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._03_Liskov_substitution
{
    public interface IStandardEmployee
    {
        decimal CalculateBonus(decimal salary);
    }
}
