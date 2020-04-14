using System;

namespace classes
{
    public class Text : PresentationObject
    {

        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We add link to: " + url);
        }
    }
}

