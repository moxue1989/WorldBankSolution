using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldBankSolution
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Account> Accounts { get; private set; }
        
        // constructor
        public Customer(int customerId, string firstName, string lastName)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Accounts = new List<Account>();
        }

        // create account for this customer
        public Account CreateAccount(int accountNumber, decimal initialBalance = 0m)
        {
            Account newAccount = new Account(accountNumber, CustomerId, initialBalance);
            Accounts.Add(newAccount);
            return newAccount;
        }
    }
}
