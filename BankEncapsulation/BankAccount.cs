using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        
        private double balance=0;
        public void Deposit (double amount)
        {
           balance=balance+amount;
        }
        public void Withdraw (double amount)
        {
            balance = balance-amount;
        }
        public double GetBalance()
        {
            return balance;
        }
    }
}
