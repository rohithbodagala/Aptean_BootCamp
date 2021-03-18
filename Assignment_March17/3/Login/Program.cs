using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            int loginAttempts = 0;

            while(loginAttempts!=3)
            {
                Console.Write("Enter username: ");
                var username = Console.ReadLine();
                Console.Write("Enter password: ");
                var password = Console.ReadLine();

                if (username.Equals("Bootcamp") && password.Equals("hpel"))
                {
                    Console.WriteLine("Welcome to C# Applications!");
                    break;
                }
                    
                else
                {
                    Console.WriteLine("Invalid Login!");
                    loginAttempts++;
                }
                    
            }
            
        }
    }
}
