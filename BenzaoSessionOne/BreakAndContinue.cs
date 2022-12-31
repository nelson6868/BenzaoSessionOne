using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenzaoSessionOne
{
    internal class BreakAndContinue
    {
        public static void Case()
        {
            int[] numberBreak = { 1, 2, 3, 4, 5, 6, };
            foreach(int number in numberBreak)
            {
                if(number == 4)
                {
                    break;
                }

                    Console.WriteLine($"{number}");
            }
            Console.WriteLine();
            Console.WriteLine();
            int[] numberContinue = { 1, 2, 3, 4, 5, 6, };
            foreach (int number in numberContinue)
            {
                if (number == 4)
                {
                    continue;
                }
                Console.WriteLine($"{number}");
            }

        }
    }
}
