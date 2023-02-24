using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programs
{
    public class FlipCoin
    {
        public static void Flip_Coin()
        {
            Console.Write("Enter the number of times to flip the coin: ");
            string input = Console.ReadLine();

            // Validate input
            int numFlips;
            if (!int.TryParse(input, out numFlips) || numFlips <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            // Flip the coin and count heads/tails
            int numHeads = 0;
            Random rnd = new Random();
            for (int i = 0; i < numFlips; i++)
            {
                if (rnd.NextDouble() < 0.5)
                {
                    numHeads++;
                }
            }

            // Print results
            double percentHeads = (double)numHeads / numFlips * 100;
            double percentTails = 100 - percentHeads;
            Console.WriteLine("Heads: {0:f2}%", percentHeads);
            Console.WriteLine("Tails: {0:f2}%", percentTails);
        }
    }
}
