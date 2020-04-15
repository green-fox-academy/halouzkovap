using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LinqEx12
{
    class Program
    {
        static void Main(string[] args)
        {
            var csvTable = new System.Data.DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead("StarWars.csv")), true))
            {
                csvTable.Load(csvReader);
            }
            List<Star> starWarsVal = new List<Star>();
            for (int i = 0; i < csvTable.Rows.Count; i++)
            {
                starWarsVal.Add(new Star { Name = csvTable.Rows[i][0].ToString(), Height = csvTable.Rows[i][1].ToString(), Mass = csvTable.Rows[i][2].ToString(), hair_color = csvTable.Rows[i][3].ToString(), skin_color = csvTable.Rows[i][4].ToString(), eye_color = csvTable.Rows[i][5].ToString(), birth_year = csvTable.Rows[i][6].ToString().Replace("BBY", ""), gender = csvTable.Rows[i][7].ToString() });
            }



            //💪 Get the age distribution of the characters by gender(where the gender can be "male", "female" and "other")
            //The age groups are: "below 21", "between 21 and 40", "above 40" and "unknown"
            //The result should be a Dictionary<string, Dictionary<string, int>> similar to this one:


            var query = starWarsVal.Where(x => x.gender == "female" || x.gender == "male")
                .GroupBy(x => x.gender).Select(x => new { key = x.Key, val = x.GroupBy(x => x.birth_year).Select(x => new { Key = x.Key, Val = x.Count() }) });




            foreach (var item in query)
            {
                Console.WriteLine(item.key + ":" + item.val);
            }
        }
    }
    class StarWarsValues
    {


        string Name;
        string Height;
        string Mass;
        string hair_color;
        string skin_color;
        string eye_color;
        string birth_year;
        string gender;

        public static StarWarsValues FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(';');
            StarWarsValues starValues = new StarWarsValues();
            starValues.Name = Convert.ToString(values[0]);
            starValues.Height = Convert.ToString(values[1]);
            starValues.Mass = Convert.ToString(values[2]);
            starValues.hair_color = Convert.ToString(values[3]);
            starValues.skin_color = Convert.ToString(values[4]);
            starValues.eye_color = Convert.ToString(values[5]);
            starValues.birth_year = Convert.ToString(values[6]);
            starValues.gender = Convert.ToString(values[7]);
            return starValues;
        }
    }
}
