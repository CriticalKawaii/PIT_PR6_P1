using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankAccountNS;

namespace BankTests
{
    [TestClass]
    public class BankAccountCreditTest
    {
        [TestCategory("Credit")]
        [TestMethod]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double creditAmount = 4.55;
            double expected = beginningBalance + creditAmount;
            BankAccount account = new BankAccount("Mr. Jesse Pinkman", beginningBalance);
            // Act
            account.Credit(creditAmount);
            // Assert
            double actual = account.Balance;
            Assert.AreEqual(actual, expected, 0.001, "Account not credited correctly");
        }

        [TestCategory("Credit")]
        [TestMethod]
        public void Credit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double creditAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Walter White", beginningBalance);
            // Act and Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Credit(creditAmount));
        }
    }
}
