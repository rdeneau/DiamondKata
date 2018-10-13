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
            result.Should().ContainInOrder("a");
        }

        [Fact]
        public void Mirror_Should_Repeat_First_Item_At_The_End_Given_Dual_Item_Enumerable()
        {
            var items = new[]
            {
                "a",
                "b"
            };
            var result = items.Mirror();
            result.Should().ContainInOrder(
                "a",
                "b",
                "a");
        }
    }
}
