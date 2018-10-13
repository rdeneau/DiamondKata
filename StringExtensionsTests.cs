using FluentAssertions;
using Xunit;

namespace DiamondKata
{
    public class StringExtensionsTests
    {
        [Fact]
        public void Mirror_Should_Not_Add_Extra_Character_Given_Empty_String()
        {
            var items  = string.Empty;
            var result = items.Mirror();
            result.Should().BeEmpty();
        }

        [Fact]
        public void Mirror_Should_Not_Add_Extra_Character_Given_Single_Item_String()
        {
            var items  = "a";
            var result = items.Mirror();
            result.Should().Be("a");
        }
    }
}
