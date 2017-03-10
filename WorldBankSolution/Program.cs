using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldBankSolution
{
    class Program
    {
        public static List<Customer> Customers = new List<Customer>();
        public static List<Account> Accounts = new List<Account>();

        static void Main(string[] args)
        {
            SetUp();

            //from p in Accounts where p.AccountNumber
            Console.WriteLine(Customers[0].Accounts[0].Balance);
            Console.WriteLine(Accounts[0].Balance);
            Accounts[0].Withdraw(50.5m);
            foreach (var account in Accounts)
            {
                Console.WriteLine(account.AccountNumber);
            }
            Console.WriteLine(Customers[0].Accounts[0].Balance);
            Console.WriteLine(Accounts[0].Balance);
            Console.ReadKey();
        }

        public static void SetUp()
        {
            Customer Stewie = new Customer(777, "Stewie", "Griffin");
            Stewie.CreateAccount(1234, 100m);

            Customer Glenn = new Customer(504, "Glenn", "Quagmire");
            Glenn.CreateAccount(2001, 35000m);

            Customer Joe = new Customer(002, "Joe", "Swanson");
            Joe.CreateAccount(1010, 7425m);
            Joe.CreateAccount(5500, 15000m);

            Customer Peter = new Customer(123, "Peter", "Griffin");
            Peter.CreateAccount(0123, 150m);

            Customer Lois = new Customer(456, "Lois", "Griffin");
            Lois.CreateAccount(0456, 150m);

            Customers.Add(Stewie);
            Customers.Add(Glenn);
            Customers.Add(Joe);
            Customers.Add(Peter);
            Customers.Add(Lois);

            foreach (var customer in Customers)
            {
                Accounts.AddRange(customer.Accounts);
            }
        }
    }
}
