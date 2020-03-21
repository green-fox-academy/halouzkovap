using System.IO;
using System.Linq;

namespace Births
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that
            // - takes the name of a CSV file as a parameter,
            //   - every row is in the following format: <person name>;<birthdate in YYYY-MM-DD format>;<city name>
            // - returns the year when the most births happened.
            //   - if there were multiple years with the same number of births then return any one of them
            // You can find such a CSV file in this directory named births.csv
            // If you pass "births.csv" to your function, then the result should be either 2006, or 2016.
            string path = "BirdthsFile1.txt";
            Birth(path);
        }
        static void Birth(string path)
        {
            var lines = File.ReadAllLines(path);
            var years = lines.Select(x => x.Substring(x.IndexOf(';'), 5)).ToList()
                .Select(x => x.Remove(0, 1))
                .GroupBy(x => x)
                .Select(g => new { Value = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .First();


            System.Console.WriteLine(years);

        }
    }

}
