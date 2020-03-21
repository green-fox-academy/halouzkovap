using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SweatWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveSweatWords());
        }

        static int RemoveSweatWords()
        {
            List<string> sweatWords = new List<string> { "fuck", "bloody", "cock", "shit", "fucker", "fuckstick", "asshole", "dick", "piss", "cunt" };
            int countOfsweatWords = 0;
            try
            {
                string[] inputs = File.ReadAllLines("SweatWords.txt");
                foreach (var input in inputs)
                {
                    var words = input.Split(new[] { ' ' });
                    var cleanWords = new List<string>();
                    foreach (var word in words)
                    {
                        var trimmed = word.Trim(new char[] { '.', ',', ';', '!', '?' });
                        if (sweatWords.Contains(trimmed, StringComparer.OrdinalIgnoreCase))
                        {
                            countOfsweatWords++;
                            cleanWords.Add(word.Replace(trimmed, ""));
                        }
                        else
                        {
                            cleanWords.Add(word);
                        }
                    }
                    string resultText = null;
                    resultText += string.Join(' ', cleanWords) + Environment.NewLine;
                }
                return countOfsweatWords;
            }
            catch (Exception e)
            {
                Console.WriteLine("wrong file");
                throw;
            }
        }
    }
}
