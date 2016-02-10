using System.Linq;

namespace EncodingPerfTests
{
    public static class UglyThings
    {
        public const string Alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ01234567890 {}[]()\"\"''";

        public static string GenerateText(int length)
        {
            return new string(Enumerable.Range(0, length).Select(i => Alphabet[i %Alphabet.Length]).ToArray());
        }
    }
}