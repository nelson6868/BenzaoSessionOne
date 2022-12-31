using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenzaoSessionOne
{
    internal class SwitchCaseStatement
    {
        public static void SwitchCase()
        {
            bool Options = true;
            while (Options)
         
            {
                Console.WriteLine("-------Choose Books based on their starting letter: e.g, C, 0, D, E--------");
                Console.WriteLine("------OR Enter |Quit| to cancel the process------");
                string Case = Console.ReadLine().ToUpper();
                switch (Case)
                { 
                    case "C":
                        Console.WriteLine("C# books");
                        break;
                    case "O":
                        Console.WriteLine(".NET books");
                        break;
                    case "D":
                        Console.WriteLine("Clean Code Books");
                        break;
                    case "E":
                        Console.WriteLine("EFCore Books");
                        break;
                    case "QUIT":
                        Options = false;
                        break;
                    default:
                        Console.WriteLine("Opps! Please try again");
                        break;
                     
                }
            }
        }
    }
}
