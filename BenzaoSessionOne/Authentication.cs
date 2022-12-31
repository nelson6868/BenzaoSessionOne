using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenzaoSessionOne
{
    public static class Authentication
    {
         internal static void UserAuthentication()
        {

                //AUTHENTICAION
                Console.WriteLine("Please Enter Your Username");
                string username = Console.ReadLine().ToLower();

                Console.WriteLine($"Your username is {username}");
                Console.WriteLine("Please Enter you preferred password");
                string userPassword = Console.ReadLine();
                Console.WriteLine("PLease enter username to login");
                string userLoginName = Console.ReadLine().ToLower();
                    if (userLoginName == username)
                    {
                        Console.WriteLine($"Welcome {userLoginName}");
                        Console.WriteLine($"Enter your password {userLoginName}");
                     
                    }
                    else
                    {
                        Console.WriteLine("PLease enter a valid username");
                    }

                    string userLoginPassword = Console.ReadLine();
                    {
                        if (userLoginPassword == userPassword && userLoginName == username)
                        {
                            Console.WriteLine($"Login Successfull");
                        }
                        else
                        {
                            Console.WriteLine("PLease enter a valid password");
                        }
                    }


            }
            
        }
}
