using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programs
{
    public class VowelConsonantProgram
    {
        public static void VowelConsonant_Program()
        {
            char ch;

            Console.WriteLine("Enter an alphabet: ");
            ch = Console.ReadLine()[0];

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u'
                || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("{0} is a vowel", ch);
            }
            else
            {
                Console.WriteLine("{0} is a consonant", ch);
            }
        }
    }
}
