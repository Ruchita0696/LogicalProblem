using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class PerfectNumber
    {
        public void CheckPerfectNumber(int pNumber)
        {
            int sum = 0;
            for (int i = 1; i < pNumber; i++)
            {
                if (pNumber % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == pNumber)
            {
                Console.WriteLine(pNumber + " is Perfect Number ");
            }
            else
            {
                Console.WriteLine(pNumber + " is  Not a Perfect Number ");
            }

        }
    }
}
