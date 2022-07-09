using NUnit.Framework;
using System;

namespace SmartphoneShop.Tests
{
    [TestFixture]
    public class SmartphoneShopTests
    {
        [Test]
        public void ConstructorShouldSeCapacity()
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
    }
}