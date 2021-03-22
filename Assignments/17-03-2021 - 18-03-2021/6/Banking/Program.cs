using System;

namespace Banking
{
    class Program
    {
        public static void AccountTrans(BankAccount b)
        {

            b.balance = b.balance + 100;
            b.accountHolderName = "Nagendra";
        }
        public static void AccountTrans(ref BankAccount b)
        {
            b.balance = b.balance + 100;
            b.accountHolderName = "Ishank";

        }


        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1233,"Rohith",30000);
            Console.WriteLine($"Bank Account Details:");
            account.DisplayDetails();
            Console.WriteLine($"-------Passing object by value---------");
            AccountTrans(account);
            account.DisplayDetails();
            Console.WriteLine($"-------Passing object by reference---------");
            AccountTrans(ref account);
            account.DisplayDetails();
        }
        

    }
}
