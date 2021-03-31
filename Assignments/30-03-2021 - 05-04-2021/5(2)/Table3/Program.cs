using System;

namespace Table3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Table[] tables = new Table[10];
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"Table {i + 1}: ");
                tables[i] = new Table(rand.Next(50, 200), rand.Next(50, 200));
                Console.WriteLine(tables[i].ShowData());
                Console.WriteLine();
            }
            for (var i = 5; i < 10; i++)
            {
                Console.WriteLine($"Table {i + 1}: ");
                tables[i] = new CoffeeTable(rand.Next(40, 120), rand.Next(40, 120));
                Console.WriteLine(tables[i].ShowData());
                Console.WriteLine();
            }
            
            tables[0].AddLeg();
            Console.WriteLine();
            tables[6].AddLeg();

        }
    }
}
