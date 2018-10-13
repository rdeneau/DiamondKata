using FluentAssertions;
using Xunit;

namespace DiamondKata
{
    public class EnumerableExtensionsTests
    {
        [Fact]
        public void Mirror_Should_Not_Add_Extra_Item_Given_Single_Item_Enumerable()
        {
            var items = new[] { "a" };
            var result = items.Mirror();
            result.Should().BeEquivalentTo(items, options => options.WithStrictOrdering());
        }
    }
}
