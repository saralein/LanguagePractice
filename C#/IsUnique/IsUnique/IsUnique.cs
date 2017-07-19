using System;
using System.Collections.Generic;
using System.Linq;

namespace IsUniqueKata
{
    public class IsUnique
    {
        public bool HasUniqueCharacters(String phrase)
        {
            if (phrase == "")
            {
                return false;
            }

            var dictionary = new Dictionary<char,int> ();
            foreach (char x in phrase)
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
            return dictionary.All(kvp => kvp.Value == 1);
        }
    }
}
