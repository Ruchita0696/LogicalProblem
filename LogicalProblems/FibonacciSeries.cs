using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class FibonacciSeries
    {
        public void CalculateFibonacciSeries()
        {
            int num1 = 0, num2 = 1, num3;
            Console.Write("Fibonacci Series is : ");
            for (int i = 2; i <= 10; i++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }

        }
    }
}
