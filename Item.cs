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
                    if (SellIn > 0) IncreaseQuality(1);
                    else IncreaseQuality(2);
                    SellIn -= 1;
                    break;
                
                case "Backstage passes to a TAFKAL80ETC concert":
                    if (SellIn > 10) IncreaseQuality(1);
                    else if (SellIn > 5) IncreaseQuality(2);
                    else if (SellIn > 0) IncreaseQuality(3);
                    else Quality = 0;
                    SellIn -= 1;
                    break;
                
                case "Sulfuras, Hand of Ragnaros":
                    Quality = SulfurasQuality;
                    break;
                
                default:
                    if (Name.StartsWith("Conjured"))
                    {
                        if (SellIn > 0) DecreaseQuality(2);
                        else DecreaseQuality(4);
                    }
                    else
                    {
                        if (SellIn > 0) DecreaseQuality(1);
                        else DecreaseQuality(2);
                    }
                    SellIn -= 1;
                    break;
            }
        }

        public void IncreaseQuality(int amountOfIncrease)
        {
            Quality = (Quality < (UpperLimitQuality - amountOfIncrease)) ? Quality + amountOfIncrease : UpperLimitQuality;
        }
        
        public void DecreaseQuality(int amountOfDecrease)
        {
            Quality = (Quality > (LowerLimitQuality + amountOfDecrease)) ? Quality - amountOfDecrease : LowerLimitQuality;
        }
    }
}