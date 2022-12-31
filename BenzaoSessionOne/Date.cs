using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenzaoSessionOne
{
    public static class Date
    {
        internal static void PrintDateAfterWeek()
        {
            Console.WriteLine("Enter Date in this format MM-DD-YYYY");
            string input = Console.ReadLine();

           static DateTime ConvertDate(string inputParam)
            {
                DateTime convertToDate = DateTime.Parse(inputParam);
                DateTime newDate = convertToDate.AddDays(7);
                Console.WriteLine(newDate);
                return newDate;
            }
            ConvertDate(input);
        }
    }
}
