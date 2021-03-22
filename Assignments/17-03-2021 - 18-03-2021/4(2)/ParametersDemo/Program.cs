using System;

namespace ParametersDemo
{
    class Calculator
    {
        public static void AddandSubtract(out int sum,out int diff)
        {
            Console.WriteLine("Enter two numbers:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            sum = x + y;
            diff = x - y;
        }
        static void Main(string[] args)
        {
            int sum, diff;
            AddandSubtract(out sum, out diff);
            Console.WriteLine($"Sum: {sum}\nDifference: {diff}");

        }
    }
}
