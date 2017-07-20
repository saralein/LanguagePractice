using System.Collections.Generic;
using System.Linq;

namespace CheckPermutationKata
{
    public class CheckPermutation
    {
        private bool IsNullWhiteSpaceOrDiffLength(string str1, string str2)
        {
            return string.IsNullOrWhiteSpace(str1) ||
                   string.IsNullOrWhiteSpace(str2) ||
                   str1.Length != str2.Length;
        }

        public bool ArePermutations(string str1, string str2) {
            if (IsNullWhiteSpaceOrDiffLength(str1, str2))
            {
                return false;
            }

            var dictionary = new Dictionary<char, int>();
            foreach (char x in str1)
            {
                if (dictionary.ContainsKey(x))
                {
                    dictionary[x]++;
                }
                else
                {
                    dictionary[x] = 1;
                }
            }

            foreach (char x in str2)
            {
                if (!dictionary.ContainsKey(x))
                {
                    return false;
                }
                else
                {
                    dictionary[x]--;
                }
            }

            return dictionary.All(kvp => kvp.Value == 0);
        }
    }
}
