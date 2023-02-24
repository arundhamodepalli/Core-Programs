using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programs
{
    public class FactorNumber
    {
        public static void Factor_Number()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Prime factors of {0} are: ", n);

            for (int i = 2; i * i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.Write("{0} ", i);
                    n /= i;
                }
            }

            if (n > 1)
            {
                Console.Write("{0} ", n);
            }
        }
    }
}
