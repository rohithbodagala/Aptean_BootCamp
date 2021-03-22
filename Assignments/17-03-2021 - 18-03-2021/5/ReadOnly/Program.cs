using System;

namespace ReadOnly
{
    class Program
    {
        public static readonly string message = "Hi,Welcome to Aptean!";
        static void Main(string[] args)
        {
            
            Console.WriteLine(Program.message);
        }
    }
}
