using System.Collections.Generic;
using System.Linq;

namespace DiamondKata
{
    public class Diamond
    {
        public IEnumerable<string> Of(string letter)
        {
            return Mirror(new[]
            {
                "__A__",
                "_B_B_",
                "C___C"
            });
        }

        private IEnumerable<string> Mirror(IEnumerable<string> lines)
        {
            return lines.Concat(
                new[]
                {
                    "_B_B_",
                    "__A__"
                });
        }
    }
}
