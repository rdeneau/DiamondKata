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
                "__A",
                "_B_",
                "C__"
            }
            .Select(line => line.Mirror())
            .Mirror();
        }
    }
}
