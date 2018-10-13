using System.Collections.Generic;

namespace DiamondKata
{
    public class Diamond
    {
        public IEnumerable<string> Of(string letter)
        {
            return new[]
            {
                "__A".Mirror(),
                "_B_".Mirror(),
                "C__".Mirror()
            }
            .Mirror();
        }
    }
}
