using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace GildedRoseTests
{
    public class ConjuredItemTest
    {
        [Test]
        public void ConjuredItems_DecreaseByTwoInQuality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Humps", SellIn = 3, Quality = 8 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            
            Assert.AreEqual(2, Items[0].Quality);
        }
        
        [Test]
        public void ConjuredItems_QualityNeverBelowZero()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Humps", SellIn = 3, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            
            Assert.AreEqual(0, Items[0].Quality);
        }
    }
}