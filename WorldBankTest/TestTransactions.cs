using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldBankSolution;

namespace WorldBankTest
{
    [TestClass]
    public class TestTransactions
    {
        [TestMethod]
        public void TestCase1()
        {
            // Arrange
            Customer Stewie = new Customer(777, "Stewie", "Griffin");
            Account Stewie1234 = Stewie.CreateAccount(1234, 100m);

            // Act
            Transaction.Deposit(Stewie1234, 300m, "USD");

            // Assert
            decimal balance = Stewie.Accounts[0].Balance;
            Assert.AreEqual(700m, balance);
        }

        [TestMethod]
        public void TestCase2()
        {
            // Arrange
            Customer Glenn = new Customer(504, "Glenn", "Quagmire");
            Account Glenn2001 = Glenn.CreateAccount(2001, 35000m);

            // Act
            Transaction.Withdraw(Glenn2001, 5000m, "MXN");
            Transaction.Withdraw(Glenn2001, 12500m, "USD");
            Transaction.Deposit(Glenn2001, 300m, "CAD");

            // Assert
            decimal balance = Glenn.Accounts[0].Balance;
            Assert.AreEqual(9800m, balance);
        }

        [TestMethod]
        public void TestCase3()
        {
            // Arrange
            Customer Joe = new Customer(002, "Joe", "Swanson");
            Account Joe1010 = Joe.CreateAccount(1010, 7425m);
            Account Joe5500 = Joe.CreateAccount(5500, 15000m);

            // Act
            Transaction.Withdraw(Joe5500, 5000m, "CAD");
            Transaction.Transfer(Joe1010, Joe5500, 7300m, "CAD");
            Transaction.Deposit(Joe1010, 13726m, "MXN");

            // Assert
            decimal balance1010 = Joe.Accounts[0].Balance;
            decimal balance5050 = Joe.Accounts[1].Balance;
            Assert.AreEqual(1497.6m, balance1010);
            Assert.AreEqual(17300m, balance5050);
        }

        [TestMethod]
        public void TestCase4()
        {
            // Arrange
            Customer Peter = new Customer(123, "Peter", "Griffin");
            Account Peter0123 = Peter.CreateAccount(0123, 150m);

            Customer Lois = new Customer(456, "Lois", "Griffin");
            Account Lois0456 = Lois.CreateAccount(0456, 65000m);

            // Act
            Transaction.Withdraw(Peter0123, 70m, "USD");
            Transaction.Deposit(Lois0456, 23789m, "USD");
            Transaction.Transfer(Lois0456, Peter0123, 23.75m, "CAD");

            // Assert
            decimal balance0123 = Peter.Accounts[0].Balance;
            decimal balance0456 = Lois.Accounts[0].Balance;
            Assert.AreEqual(33.75m, balance0123);
            Assert.AreEqual(112554.25m, balance0456);
        }
    }
}
