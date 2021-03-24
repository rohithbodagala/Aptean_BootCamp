using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace aggregate
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"..\..\..\Numbers.txt";
            var lines = File.ReadAllText(file);
            List<int> numbers=new List<int> ();
            var input = lines.Split(',');
            for(var i = 0; i < input.Length; i++)
            {
                numbers.Add(int.Parse(input[i].Trim()));
            }
            var oddCount = (from number in numbers
                            where (number % 2 != 0)
                            select number).Count();

            Console.WriteLine($"Odd Number count:  {oddCount}");
            var evenCount = (from number in numbers
                            where (number % 2 == 0)
                            select number).Count();
            Console.WriteLine($"Even Number count:  {evenCount}");
            var uniqueCount= (from number in numbers
                              select number).Distinct().Count();
            Console.WriteLine($"Unique numbers count: {uniqueCount}");
            var sum = (from number in numbers
                       select number).Sum();
            Console.WriteLine($"Sum: {sum}");
            var min = (from number in numbers
                       select number).Min();
            Console.WriteLine($"Lowest Number: {min}");
            var max= (from number in numbers
                      select number).Max();
            Console.WriteLine($"Greatest Number: {max}");
            var avg= numbers.Average();
            Console.WriteLine($"Average: {avg}");
            var greaterThanAverage = (from number in numbers
                                      where number > avg
                                      orderby number
                                      select number);
            Console.WriteLine("Numbers greater than average of the list:  ");
            foreach(var number in greaterThanAverage)
            {
                Console.Write($"{number}, ");
            }



        }
    }
}
