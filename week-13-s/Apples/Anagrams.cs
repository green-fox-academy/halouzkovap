using System;

namespace Apples
{
    public class Anagrams
    {
        public bool GetAnagram(string word1, string word2)
        {
            char[] wordARr = word1.ToCharArray();
            Array.Reverse(wordARr);
            string newWord = new string(wordARr);

            if (newWord == word2)
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        private string ReverseWord(string word1)
        {
            char[] wordARr = word1.ToCharArray();
            Array.Reverse(wordARr);
            return wordARr.ToString();
        }
    }
}

