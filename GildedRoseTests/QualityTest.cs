using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace GildedRoseTests
{
    public class QualityTest
    {
        [Test]
        public void QualityDecreaseBeforeSellIn()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "My Humps", SellIn = 5, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            
            Assert.AreEqual(7, Items[0].Quality);
        }
        
        [Test]
        public void QualityDecreasesByTwoAfterSellIn()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "My Humps", SellIn = -1, Quality = 6 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.AreEqual(4, Items[0].Quality);
        }
        
        [Test]
        public void QualityCannotBeNegative()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "My Humps", SellIn = 5, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            app.UpdateQuality();

            Assert.AreEqual(0, Items[0].Quality);
        }
    }
}