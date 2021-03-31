using System;

namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Table[] tables = new Table[10];
            for(var i = 0; i < tables.Length; i++)
            {
                Console.WriteLine($"For Table {i + 1}: ");
                tables[i] = new Table(rand.Next(50,200), rand.Next(50,200));
                tables[i].ShowData();
                Console.WriteLine();
            }
        }
    }
}
