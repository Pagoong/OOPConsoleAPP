using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleAPP
{
    public class BankAccount
    {

        private decimal balance;

        public void deposit(decimal amount)
        {
                if(amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount}, current balance: {balance}");
            }
        }

        public  decimal getBalance() 
        {
            return balance;
        }
    }
}
