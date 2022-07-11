using NUnit.Framework;
using System.Linq;
using System;

namespace BankSafe.Tests
{
    [TestFixture]
    public class BankVaultTests
    {
        [Test]
        public void BankTests()
        {
            BankVault bank = new BankVault();
            Assert.Throws<ArgumentException>(() => bank.AddItem("Jesko", new Item("owner", "C5")));

            Item item = new Item("Pesho", "1122");
            bank.AddItem("A4", item);
            Assert.Throws<ArgumentException>(() => bank.AddItem("A4", new Item("owner1", "1122")));

            Assert.Throws<ArgumentException>(() => bank.AddItem("A4", new Item("owner2", "12")));
           
            
            Assert.Throws<ArgumentException>(() => bank.RemoveItem("Jesko", new Item("owner2", "12")));
            
            Assert.Throws<ArgumentException>(() => bank.RemoveItem("A4", new Item("owner2", "12")));

            Assert.IsFalse(bank.VaultCells["A4"] == new Item("", ""));

        }
    }
}