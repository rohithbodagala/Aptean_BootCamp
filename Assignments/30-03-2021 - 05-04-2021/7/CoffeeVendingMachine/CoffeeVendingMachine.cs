using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine
{
    class CoffeeVendingMachine
    {
        const int Cost_of_Cofee = 150;
        public int RunningTotal { get; set; }

        public CoffeeVendingMachine()
        {
            RunningTotal = 0;
        }
        public void DepositCoin(int money)
        {
            switch (money)
            {
                case (5):
                    RunningTotal += 5;
                    break;
                case (10):
                    RunningTotal += 10;
                    break;
                case (25):
                    RunningTotal += 25;
                    break;
                case (100):
                    RunningTotal += 100;
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
        public bool checkTotal()
        {
            if (RunningTotal >= Cost_of_Cofee)
                return true;
            else
            { 
                return false;
            }
        }
        public void DisplayCoffeeSelection()
        {
            Console.WriteLine("\nYou have sufficient money, Now make your Selection \n");
            Console.WriteLine("***************************");
            Console.WriteLine("   * N - NORMAL COFFEE *   ");
            Console.WriteLine("   * F - FILTERCOFFEE  *   ");
            Console.WriteLine("   * C - CAPPUCCINO    *   ");
            Console.WriteLine();
            Console.WriteLine("Enter your selection");
            MakeSelection(Convert.ToChar(Console.ReadLine().ToUpper()));
        }

        private void MakeSelection(char selection)
        {
            bool selectOk = false;

            while (!selectOk)
            {
                switch (selection)
                {
                    case 'N':
                        Console.WriteLine("\nThanks for choosing: Normal Coffee");
                        ReturnChange();
                        selectOk = true;
                        break;
                    case 'F':
                        Console.WriteLine("\nThanks for choosing: Filter Coffee");
                        ReturnChange();
                        selectOk = true;
                        break;
                    case 'C':
                        Console.WriteLine("\nThanks for choosing: CAPPUCCINO");
                        ReturnChange();
                        selectOk = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        Console.WriteLine("Enter Again");
                        selection = Convert.ToChar(Console.ReadLine().ToUpper());
                        selectOk = false;
                        break;

                }
            }
        }

        private void ReturnChange()
        {
            if (RunningTotal > Cost_of_Cofee)
                Console.WriteLine($"\nHere is Your change of Rupees: {RunningTotal - Cost_of_Cofee}/-");
        }
    }

}
