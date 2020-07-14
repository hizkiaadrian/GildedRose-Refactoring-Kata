using System.Security.AccessControl;
using System.Text.RegularExpressions;

namespace csharp
{
    public class Item
    {
        private const int SulfurasQuality = 80;
        private const int UpperLimitQuality = 50;
        private const int LowerLimitQuality = 0;
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }

        public void UpdateQuality()
        {
            switch (Name)
            {
                case "Aged Brie":
                    IncreaseQuality(SellIn-- > 0 ? 1 : 2);
                    break;

                case "Backstage passes to a TAFKAL80ETC concert":
                    IncreaseQuality(SellIn > 10 ?
                        1 : SellIn > 5 ?
                            2 : SellIn > 0 ?
                                3 : -Quality);
                    SellIn--;
                    break;

                case "Sulfuras, Hand of Ragnaros":
                    Quality = SulfurasQuality;
                    break;

                case var item when new Regex(@"^Conjured").IsMatch(item):
                    DecreaseQuality(SellIn-- > 0 ? 2 : 4);
                    break;

                default:
                    DecreaseQuality(SellIn-- > 0 ? 1 : 2);
                    ;
                    break;
            }
        }

        public void IncreaseQuality(int amountOfIncrease)
        {
            Quality = Quality < UpperLimitQuality - amountOfIncrease ? Quality + amountOfIncrease : UpperLimitQuality;
        }

        public void DecreaseQuality(int amountOfDecrease)
        {
            Quality = Quality > LowerLimitQuality + amountOfDecrease ? Quality - amountOfDecrease : LowerLimitQuality;
        }
    }
}