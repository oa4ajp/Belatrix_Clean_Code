using System;

namespace SOLID._01_SingleResponsability
{
    public class Calculator
    {
        public void Sum(int a, int b)
        {
            var result = (a + b);
            ShowSumResult(result);
        }

        public void ShowSumResult(int result) {
            var message = string.Empty;

            if (result > 0 && result <= 10)
            {
                message = "Value between 0 and 10";
            }
            else if (result > 10 && result <= 20)
            {
                message = "Value between 11 and 20";
            }
            else if (result > 20 && result <= 30)
            {
                message = "Value between 11 and 20";
            }

            Console.WriteLine(string.Format("The sum is: {0} and is in range {1}", result, message));
        }

    }
}
