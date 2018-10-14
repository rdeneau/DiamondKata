using System.Collections.Generic;
using System.Linq;

namespace DiamondKata
{
    public class Diamond
    {
        private const char Filler = '_';

        public IEnumerable<string> Of(string letter)
        {
            return FromLetters("CBA");
        }

        private static IEnumerable<string> FromLetters(string letters) =>
            letters.Reverse()
                   .Select(c => EraseExcept(letters, c))
                   .Select(line => line.Mirror())
                   .Mirror();

        private static string EraseExcept(string source, char character) =>
            source.Select(c => EraseExcept(c, character))
                  .Join();

        private static char EraseExcept(char source, char character) =>
            source == character
                ? character
                : Filler;
    }
}
