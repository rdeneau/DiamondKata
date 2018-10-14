using System.Collections.Generic;

namespace DiamondKata
{
    public static class CharExtensions
    {
        public static string SequenceDownToA(this char letter) =>
            EnumerateDownToA(letter).Join();

        private static IEnumerable<char> EnumerateDownToA(char letter)
        {
            yield return letter;
            if (letter == 'A')
            {
                yield break;
            }
            var previous = 'A';
            yield return previous;
        }
    }
}
