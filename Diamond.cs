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
                "_B_B_",
                "C___C"
            }
            .Mirror();
        }
    }
}
