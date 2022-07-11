using NUnit.Framework;
using System;

namespace SmartphoneShop.Tests
{
    [TestFixture]
    public class SmartphoneShopTests
    {
        [Test]
        public void ConstructorShouldSetCapacity()
        {
            var shop = new Shop(5);
            Assert.AreEqual(5, shop.Capacity);
        }
        [Test]
        public void CapacityShouldNotBellowZero()
        {
            //Shop shop = new Shop(-1);
            Assert.Throws<ArgumentException>(() => new Shop(-1));
        }
        [Test]
        public void EmptyListOfPhonesCountShouldBeZero()
        {
            Shop shop = new Shop(5);
            Assert.AreEqual(0, shop.Count);
        }
        [Test]
        public void CanotAddExistingPhone()
        {
            Shop shop = new Shop(5);
            shop.Add(new Smartphone("Nokia", 10));
            Assert.Throws<InvalidOperationException>(() => shop.Add(new Smartphone("Nokia", 10)));
        }
        [Test]
        public void AddShouldBeThrowIfCapacityIsFull()
        {
            Shop shop = new Shop(5);
            shop.Add(new Smartphone("Nokia", 10));
            shop.Add(new Smartphone("Nokia1", 10));
            shop.Add(new Smartphone("Nokia2", 10));
            shop.Add(new Smartphone("Nokia3", 10));
            shop.Add(new Smartphone("Nokia4", 10));
            Assert.Throws<InvalidOperationException>(() => shop.Add(new Smartphone("Nokia5", 10)));
        }
        [Test]
        public void CountShouldWorkCorectly()
        {
            Shop shop = new Shop(5);
            shop.Add(new Smartphone("Nokia", 10));
            shop.Add(new Smartphone("Nokia1", 10));
            shop.Add(new Smartphone("Nokia2", 10));
            Assert.AreEqual(3, shop.Count);
        }

        [Test]
        public void ShouldNotRemoveEmptyPhone()
        {
            Shop shop = new Shop(5);
            shop.Add(new Smartphone("Nokia", 10));
            shop.Add(new Smartphone("Nokia1", 10));
            shop.Add(new Smartphone("Nokia2", 10));
            Assert.Throws<InvalidOperationException>(() => shop.Remove(""));
        }
        [Test]
        public void RemoveShouldWorkCorectly()
        {
            Shop shop = new Shop(5);
            shop.Add(new Smartphone("Nokia", 10));
            shop.Add(new Smartphone("Nokia1", 10));
            shop.Add(new Smartphone("Nokia2", 10));
            shop.Remove("Nokia");
            Assert.AreEqual(2, shop.Count);
            shop.Remove("Nokia1");
            shop.Remove("Nokia2");
            Assert.AreEqual(0, shop.Count);
        }
        [Test]
        public void RemoveShouldWorkCanotRemoveEmptyString()
        {
            Shop shop = new Shop(5);
            shop.Add(new Smartphone("Nokia", 10));
            shop.Add(new Smartphone("Nokia1", 10));
            shop.Add(new Smartphone("Nokia2", 10));
            Assert.Throws<InvalidOperationException>(() => shop.Remove("Nokia123"));
        }
        [Test]
        public void TestPhone()
        {
            Shop shop = new Shop(5);
            Smartphone phone = new Smartphone("iphone", 10);
            Smartphone phone2 = new Smartphone("iphone1", 11);
            Smartphone phone3 = new Smartphone("iphone3", 5);
            shop.Add(phone);    
            shop.Add(phone2);    
            shop.Add(phone3);    
            Assert.Throws<InvalidOperationException>(() => shop.TestPhone(null, 12));
            Assert.Throws<InvalidOperationException>(() => shop.TestPhone("A1", -3));
            shop.TestPhone(phone.ModelName, 6);
            Assert.AreEqual(4, phone.CurrentBateryCharge);
            Assert.AreEqual(11, phone2.MaximumBatteryCharge);

            shop.TestPhone(phone3.ModelName, 4);
            Assert.Throws<InvalidOperationException>(() => shop.TestPhone(phone3.ModelName, 5));
        }
        [Test]
        public void ChargePhone()
        {
            Shop shop = new Shop(5);
            Assert.Throws<InvalidOperationException>(() => shop.ChargePhone(null));
            var phone = new Smartphone("Iphone", 10);
            shop.Add(phone);
            shop.TestPhone("Iphone", 6);
            shop.ChargePhone(phone.ModelName);
            Assert.AreEqual(10, phone.CurrentBateryCharge);
        }
    }
}