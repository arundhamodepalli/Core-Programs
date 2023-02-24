using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programs
{
    public class PowerofN
    {
        public static void Powerof_N()
        {

            /*if (args.Length == 0)
            {
                Console.WriteLine("Please provide a value for N as a command-line argument.");
                return;
            }*/

            //int n = int.Parse(args[0]);
            int n =Convert.ToInt32(Console.ReadLine());

            if (n < 0 || n >= 31)
            {
                Console.WriteLine("N should be between 0 and 30 inclusive, since 2^31 overflows an int.");
                return;
            }

            int powerOfTwo = 1;

            //Console.WriteLine("Powers of 2 less than or equal to 2^" + n + ":");
            //Console.WriteLine(powerOfTwo);

            for (int i = 1; i <= n; i++)
            {
                 powerOfTwo *= 2;
                Console.WriteLine(powerOfTwo);
               // Console.WriteLine("value is " + Math.Pow(2, i));
            }
        }
    }
}
    


