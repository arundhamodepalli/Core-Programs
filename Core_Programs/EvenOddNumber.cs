using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programs
{
    public class EvenOddNumber
    {
        public static void EvenOdd_Number()
        {
            int num = 5;

            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is even");
            }
            else
            {
                Console.WriteLine(num + " is odd");
            }
        }
    }
}
