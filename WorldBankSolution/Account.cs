using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WorldBankSolution
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public int CustomerId { get; set; }
        public decimal Balance { get; private set; }

        // constructor
        public Account(int accountNumber, int customerId, decimal balance)
        {
            AccountNumber = accountNumber;
            CustomerId = customerId;
            Balance = balance;
        }

        // deposit into account
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        // withdraw from account, throws exception if trying to withdraw more than balance
        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
               throw new Exception("Insufficient balance in account: " + AccountNumber);
            }
            else
            {
                Balance -= amount;
            }
        }
    }
}
