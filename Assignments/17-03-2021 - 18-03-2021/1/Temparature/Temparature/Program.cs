using System;

namespace Temparature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the temperature : ");
            var temperature = double.Parse(Console.ReadLine());
            if (temperature <= 32)
            {
                Console.WriteLine("The climate is good today");
                if (temperature == 32)
                {
                    Console.WriteLine("The temperature is 32");
                }
                
            }
            else
            {
                Console.WriteLine("It is hot today");
            }
        }
    }
}
