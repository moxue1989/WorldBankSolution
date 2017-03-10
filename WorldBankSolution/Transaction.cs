using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldBankSolution
{
    // Transaction class for testing
    public static class Transaction
    {
        // exchange rates
        public static Dictionary<string, decimal> Rates = new Dictionary<string, decimal>()
        {
            {"CAD", 1m }, {"USD", 2m }, {"MXN", 0.1m}
        };

        public static void Deposit(Account account, decimal amount, String currency)
        {
            account.Deposit(amount * Rates[currency]);
        }

        public static void Withdraw(Account account, decimal amount, String currency)
        {
            try
            {
                account.Withdraw(amount * Rates[currency]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Transfer(Account fromAccount, Account toAccount, decimal amount, String currency)
        {
            try
            {
                // try to withdraw first in case of insufficient funds
                Withdraw(fromAccount, amount, currency);
                Deposit(toAccount, amount, currency);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
