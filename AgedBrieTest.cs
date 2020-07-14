using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class AgedBrieTest
    {
        [Test]
        public void AgedBrie_QualityIncreasesBeforeSellIn()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            
            Assert.AreEqual(3, Items[0].Quality);
        }
        
        [Test]
        public void AgedBrie_QualityIncreasesByTwoAfterSellIn()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            
            Assert.AreEqual(6, Items[0].Quality);
        }
    }
}
