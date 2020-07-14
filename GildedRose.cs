using System.Collections.Generic;
using System.Linq;
using ApprovalUtilities.Utilities;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality(int numberOfDays)
        {
            foreach (var day in Enumerable.Range(0,numberOfDays))
            {
                Items.ForEach(item => item.UpdateQuality());
                Program.PrintItemsList(day, Items);
            }
        }
    }
}
