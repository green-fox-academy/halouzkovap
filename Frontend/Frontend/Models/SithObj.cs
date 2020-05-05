using System;
using System.Linq;

namespace Frontend.Models
{
    public class SithObj
    {
        public string text { get; set; }
        public string sith_text { get; set; }





        public string RetundSithText(string text)
        {

            var test = text;

            string[] randomWord = new string[] { "Arrgh. Uhmm.", "Err..err.err." };

            var r = new Random();
            var ind = r.Next(0, randomWord.Count());

            var result = test.Split(new[] { ' ' }).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i].Contains('.'))
                {
                    ind = r.Next(0, randomWord.Count());
                    test.Insert(i + 1, randomWord[ind]);
                    i++;
                }
            }

            return new String(test.ToArray());
        }
    }
}

