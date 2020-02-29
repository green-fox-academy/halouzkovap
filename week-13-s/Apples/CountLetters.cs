using System.Collections.Generic;
using System.Linq;

namespace Apples
{
    public class CountLetters
    {
        // Write a function, that takes a string as an argument and returns 
        //a dictionary with all letters in the string as keys, and numbers 
        //as values that shows how many occurrences there are.
        //Create a test for that.
        public Dictionary<char, int> GetDictionary(string word)
        {
            char[] newArr = word.ToCharArray();
            Dictionary<char, int> newDictionary =
                                      newArr.GroupBy(c => c).Select(c => new { name = c.Key, count = c.Count() })
                                     .ToDictionary(kvp => kvp.name, kvp => kvp.count);

            return newDictionary;
        }
    }
}
