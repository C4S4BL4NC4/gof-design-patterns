using System;
using System.Collections.Generic;
using System.Text;

namespace gof_design_patterns.OOP.Principles.Encapsulation
{
    internal class BetterBankAccount
    {
        // The balance field is private, ensuring that it cannot be accessed directly from outside the class. This encapsulation allows us to control how the balance is modified and accessed, promoting data integrity and security.
        private decimal balance;

        public BetterBankAccount(decimal initialBalance)
        {
            Deposit(initialBalance);
        }

        // The class methods Deposit and Withdraw provide controlled access to modify the balance. They include validation checks to ensure that only valid operations are performed, preventing negative deposits or withdrawals that exceed the current balance.
        // Concepts such as getter and setters are part of encapsulation
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                throw new ArgumentException("Invalid withdrawal amount.");
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
