using System;

namespace BenzaoSessionOne
{
    public static class StringMasker
    {
        internal static void Masker()
        {
             Console.WriteLine("Enter Text to mask");
            string userInput = Console.ReadLine();
            if(userInput.Length <= 4)
            {
                Console.WriteLine(userInput);
            }
            else
            {

             string DisplayString(string strOriginal, int lastDigit)
            {
                string strResult = new String('#', strOriginal.Length - lastDigit) + 
                        strOriginal.Substring(strOriginal.Length - lastDigit);
                return strResult;
            }
            Console.WriteLine(
            DisplayString(userInput, 4)
                );
        }
            }
    }
}
