using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programs
{
    public class HarmonicNumber
    {
        public static void Harmonic_Number()
        {
            /* if (args.Length == 0)
             {
                 Console.WriteLine("Please provide a value for N as a command-line argument.");
                 return;
             }*/

            //int n = int.Parse(args[0]);
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("N should not be 0.");
                return;
            }

            double harmonicNumber = 0;

            for (int i = 1; i <= n; i++)
            {
                harmonicNumber += 1.0 / i;
            }

            Console.WriteLine("The " + n + "th harmonic number is: " + harmonicNumber);
            // Console.WriteLine("value is " + Math.Pow(2, i));
        }
    }
}
