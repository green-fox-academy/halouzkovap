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

            string path = @"C:\Users\42073\halouzkovap\starWarst.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] columns = line.Split(';');
                foreach (string column in columns)
                {
                    System.Console.WriteLine(column);
                }
            }
        }
    }
}
