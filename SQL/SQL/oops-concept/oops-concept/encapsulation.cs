using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept
{
    internal class encapsulation
    {
        public class BankAccount
        {
            private decimal balance;

            public BankAccount(decimal initialBalance)
            {
                balance = initialBalance;
            }

            public void Deposit(decimal amount)
            {
                balance += amount;
            }

            public void Withdraw(decimal amount)
            {
                if (amount > balance)
                {
                    throw new InvalidOperationException("Insufficient balance");
                }
                balance -= amount;
            }
            public decimal GetBalance()
            {
                return balance;
            }
        }
    }
}
