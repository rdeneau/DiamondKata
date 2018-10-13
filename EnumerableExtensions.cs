using System.Collections.Generic;
using System.Linq;

namespace DiamondKata
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<string> Mirror(this IEnumerable<string> items)
        {
            IReadOnlyCollection<string> allItems = items.ToList();
            var reversedItems = allItems.Reverse();
            return allItems.Concat(reversedItems.Skip(1));
        }
    }
}
