using System;
using System.Collections.Generic;
using System.Linq;

namespace Frontend.Models
{
    public class HuTranslater
    {
        public string Text { get; set; }
        public string Lang { get; set; }

        public HuTranslater()
        {

        }
        public HuTranslater(string text)
        {
            this.Text = text;
            this.Lang = "teva";
        }

        public HuTranslater Translater(string text)
        {
            var vowels = "aeiouAEIOUáéíóúÁÉÍÓÚ";
            var oldText = text.ToCharArray().ToList();
            var output = new List<char>();
            for (int i = 0; i < oldText.Count; i++)
            {
                if (vowels.Contains(text[i]))
                {

                    output.Add(text[i]);
                    output.Add('v');
                    output.Add(Char.ToLower(text[i]));
                }
                else
                {
                    output.Add(text[i]);
                }

            }
            var result = new String(output.ToArray());
            var newObj = new HuTranslater(result);
            return newObj;
        }
    }
}
