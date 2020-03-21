using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace SweatWords
{
    class Class1
    {
        //static void Main(string[] args)
        //{
        //    RemoveSwearWords();
        //    Console.WriteLine("Hello World!");
        //}
        private static int RemoveSwearWords()
        {
            var swearWords = new string[] { "fuck", "bloody", "cock", "shit", "fucker", "fuckstick", "asshole", "dick", "piss", "cunt" };
            var lines = File.ReadAllLines("content.txt");
            int swearWordCounter = 0;
            string resultText = "";
            foreach (var line in lines)
            {
                var words = line.Split(new[] { ' ' });
                var cleanWords = new List<string>();
                foreach (var word in words)
                {
                    var trimmed = word.Trim(new char[] { '.', ',', ';', '!', '?' });
                    if (swearWords.Contains(trimmed, StringComparer.OrdinalIgnoreCase))
                    {
                        swearWordCounter++;
                        cleanWords.Add(word.Replace(trimmed, ""));
                    }
                    else
                    {
                        cleanWords.Add(word);
                    }
                }
                resultText += string.Join(' ', cleanWords) + Environment.NewLine;
            }
            return swearWordCounter;
        }
    }
}
