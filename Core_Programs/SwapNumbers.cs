using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programs
{
    public class SwapNumbers
    {
        public static void Swap_Numbers()
        {
            int num1 = 5;
            int num2 = 10;
            int temp;

            Console.WriteLine("Before swapping: num1 = " + num1 + ", num2 = " + num2);

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swapping: num1 = " + num1 + ", num2 = " + num2);
        }
    }
}
