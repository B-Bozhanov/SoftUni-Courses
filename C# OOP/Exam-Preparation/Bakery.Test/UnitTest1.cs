
namespace Bakery.Test
{
    using NUnit.Framework;
    using Models.BakedFoods.Contracts;
    using Bakery.Models.BakedFoods;
    using System;
    using Bakery.Models.Drinks;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void BakedFoodTest()
        {
            Assert.Throws<ArgumentException>(() => new Tea("", 2, "as"));
        }
    }
}