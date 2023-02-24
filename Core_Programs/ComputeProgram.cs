using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programs
{
    public class ComputeProgram
    {
        public static void Compute_Program()
        {
            int dividend, divisor, quotient, remainder;

            Console.Write("Enter dividend: ");
            dividend = int.Parse(Console.ReadLine());

            Console.Write("Enter divisor: ");
            divisor = int.Parse(Console.ReadLine());

            quotient = dividend / divisor;
            remainder = dividend % divisor;

            Console.WriteLine("Quotient = {0}", quotient);
            Console.WriteLine("Remainder = {0}", remainder);
        }
    }
}
