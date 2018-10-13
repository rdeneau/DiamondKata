using System.Linq;

namespace DiamondKata
{
    public static class StringExtensions
    {
        public static string Mirror(this string @this)
        {
            var chars = @this.ToCharArray()
                             .Mirror()
                             .ToArray();
            return new string(chars);
        }
    }
}
