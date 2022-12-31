using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenzaoSessionOne
{
    public static class CapitalLetterCheck
    {
        internal static void CheckUpperCase()
        {
            Console.WriteLine("Enter Your Sentence");
            string userInput = Console.ReadLine();
            List<int> stringIndexes = new List<int>();


            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] >= 'A' & userInput[i] <= 'Z') 
                {
                    stringIndexes.Add(i);
                }
                else
                {
                    Console.WriteLine("There is no capital letter in the sentence");
                }
            }

            foreach (int i in stringIndexes)
            {
                Console.WriteLine($"Index: {i}\t Value: {userInput[i]}");
            }
        }
    }
}
