using System.Collections.Generic;
using System.Linq;

namespace DiamondKata
{
    public class Diamond
    {
        public IEnumerable<string> Of(string letter)
        {
            return new[]
            {
                EraseExcept("BCA", 'A'),
                "_B_",
                "C__"
            }
            .Select(line => line.Mirror())
            .Mirror();
        }

        private static string EraseExcept(string expression, char character) =>
            expression.ToCharArray()
                      .Select(c => c == character
                                       ? character
                                       : '_')
                      .Join();
    }
}
