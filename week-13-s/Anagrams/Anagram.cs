using System;

namespace Anagrams
{
    public class Anagram
    {
        public Anagram()
        {

        }
        public bool GetAnagram(string word1, string word2)
        {
            string newWord = ReverseWord(word1);

            if (newWord == word2)
            {
                return true;
            }
            return false;
        }

        private string ReverseWord(string word1)
        {
            char[] wordARr = word1.ToCharArray();
            Array.Reverse(wordARr);
            return wordARr.ToString();
        }
    }
}
