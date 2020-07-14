using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace GildedRoseTests
{
    public class SulfurasTest
    {
        [Test]
        public void Sulfuras_QualityIsAlwaysEighty()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality(3);

            Assert.AreEqual(80, Items[0].Quality);
        }
        
        [Test]
        public void Sulfuras_SellinDoesNotChange()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality(3);

            Assert.AreEqual(5, Items[0].SellIn);
        }
    }
}