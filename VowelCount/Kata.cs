
using System.Linq;

namespace VowelCount
{
    public class Kata
    {
        public static int GetVowelCount(string input)
        {
            return input.Count(c => new[] {'a','e','i','o','u' }.Contains(c));
        }
    }
}
