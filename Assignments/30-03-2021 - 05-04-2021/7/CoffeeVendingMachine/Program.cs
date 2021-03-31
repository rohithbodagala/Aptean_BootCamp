using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var CoffeeVendingMachine = new CoffeeVendingMachine();

            Console.WriteLine("Welcome to CoffeeMachine");
            Console.WriteLine("Minium Coffee price is 150/-\n");
            int f = 0;
            while (!CoffeeVendingMachine.checkTotal())
            {
                f += 1;
                if (f > 1)
                {
                    Console.WriteLine("\n*Please add more money to buy Coffee*\n ");
                }
                Console.WriteLine("Enter coins or notes of valid Format (5,10,25,100)");
                CoffeeVendingMachine.DepositCoin(int.Parse(Console.ReadLine()));

                

            }
            CoffeeVendingMachine.DisplayCoffeeSelection();
            Console.ReadKey();
        }
        
    }
}
