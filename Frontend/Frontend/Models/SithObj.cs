﻿using System;
using System.Linq;

namespace Frontend.Models
{
    public class SithObj
    {
        public string text { get; set; }
        public string sith_text { get; set; }


        public SithObj()
        {

        }
        public SithObj(string sithText)
        {
            this.sith_text = sithText;
            text = "";
        }


        public SithObj RetundSithText(string text)
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
                    result.Insert(i + 1, randomWord[ind]);
                    i++;
                }
            }

            var newSithText = string.Join(' ', result);
            var newSithOvj = new SithObj(newSithText);
            return newSithOvj;
        }
    }
}

