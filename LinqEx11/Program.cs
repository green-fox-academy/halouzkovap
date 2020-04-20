using System;
using System.IO;
using System.Linq;

namespace LinqEx11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string inputs = File.ReadAllText("Article.txt");
                var words = inputs.Split(new[] { ' ', '.' }).Select(x => x.Trim(new char[] { '.', ',', ';', '!', '?' }))
                    .GroupBy(x => x).Select(x => new { key = x.Key, val = x.Count() });

                foreach (var item in words)
                {
                    Console.WriteLine(item.key + ":" + item.val);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
