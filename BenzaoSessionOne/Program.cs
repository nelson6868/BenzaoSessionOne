using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

using BenzaoSessionOne;
namespace BenzaoSessionOne.Runner
{
 internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "BEZAO SESSION ONE";
            StringMasker.Masker();
           // CapitalLetterCheck.CheckUpperCase();
            //Authentication.UserAuthentication();
            //BreakAndContinue.Case();
            //SwitchCaseStatement.SwitchCase();
            //Date.PrintDateAfterWeek();

        }
    }
}