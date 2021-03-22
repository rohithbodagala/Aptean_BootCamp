using System;
namespace Banking
{
    class BankAccount
    {
        public int accountNumber;
        public string accountHolderName;
        public double balance;

        public BankAccount(int accountNumber,string accountHolderName,double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.balance = balance;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Account Number: {accountNumber}\nAccount Holder name:{accountHolderName}\nBalance: {balance}");
        }
        
    }
}