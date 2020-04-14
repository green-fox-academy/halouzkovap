using LumenWorks.Framework.IO.Csv;
using System.Collections.Generic;
using System.IO;

namespace LinqEx12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the name of the heaviest character(if the mass is unknown, ignore that character)
            //Print the average height of the male characters
            //Print the average height of the female characters
            //💪 Get the age distribution of the characters by gender(where the gender can be "male", "female" and "other")
            //The age groups are: "below 21", "between 21 and 40", "above 40" and "unknown"
            //The result should be a Dictionary<string, Dictionary<string, int>> similar to this one:

            //CsvFile.DefaultCsvDefinition.FieldSeparator = '\t';
            var csvTable = new System.Data.DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead("starWarst.csv")), true))
            {
                csvTable.Load(csvReader);
            }
            List<Star> searchParameters = new List<Star>();
            for (int i = 0; i < csvTable.Rows.Count; i++)
            {
                searchParameters.Add(new Star { Name = csvTable.Rows[i][0].ToString(), Height = csvTable.Rows[i][1].ToString(), Mass = csvTable.Rows[i][2].ToString(), hair_color = csvTable.Rows[i][3].ToString(), skin_color = csvTable.Rows[i][4].ToString(), eye_color = csvTable.Rows[i][5].ToString(), birth_year = csvTable.Rows[i][6].ToString(), gender = csvTable.Rows[i][7].ToString() });
            }

            //Print the name of the heaviest character(if the mass is unknown, ignore that character))

            //Print the average height of the male characters
            //Print the average height of the female characters

            //foreach (var item in searchParameters)
            //{
            //    System.Console.WriteLine(item.Name);
            //}
        }
    }
}
