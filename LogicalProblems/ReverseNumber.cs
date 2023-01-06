using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class ReverseNumber
    {
        public void CalculateReverseNumber(int RN)
        {
            int reverse = 0, rem;

            while (RN != 0)
            {
                rem = RN % 10;
                reverse = (reverse * 10) + rem;
                RN /= 10;
            }
            Console.WriteLine("Reverse Number is : " + reverse);
        }
    }
}
