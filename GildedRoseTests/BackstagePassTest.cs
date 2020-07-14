using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace GildedRoseTests
{
    public class BackstagePassTest
    {
        [Test]
        public void BackstagePass_IncreaseInQuality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality(3);

            Assert.AreEqual(5, Items[0].Quality);
        }
        
        [Test]
        public void BackstagePass_IncreaseByTwoInQuality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality(3);

            Assert.AreEqual(8, Items[0].Quality);
        }
        
        [Test]
        public void BackstagePass_IncreaseByThreeInQuality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality(3);

            Assert.AreEqual(11, Items[0].Quality);
        }
        
        [Test]
        public void BackstagePass_QualityIsZeroAfterSellIn()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 2, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality(3);

            Assert.AreEqual(0, Items[0].Quality);
        }
    }
}