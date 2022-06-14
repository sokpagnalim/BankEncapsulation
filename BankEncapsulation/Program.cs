using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("Enter deposit amount");
            var amountToDeposit= double.Parse(Console.ReadLine());
            account.Deposit(amountToDeposit);
            Console.WriteLine($"Yous balance is now {account.GetBalance()}");

        
         }
    }
}
