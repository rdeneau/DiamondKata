using FluentAssertions;
using Xunit;

namespace DiamondKata
{
    public class CharExtensionsShould
    {
        [Fact]
        public void Return_SequenceDownToA_Given_Letter_A()
        {
            'A'.SequenceDownToA()
               .Should()
               .Be("A");
        }
    }
}
