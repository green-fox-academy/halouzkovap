using System.IO;

namespace Files
{
    class Program
    {
        static void WriteFile(string fileName)
        {
            File.WriteAllText(fileName, "Hello");
        }

        static void ReadAllText(string fileName)
        {
            System.Console.WriteLine(File.ReadAllText(fileName));
        }
        static void Main(string[] args)
        {
            string FileName = @"C:\Users\42073\greenfox\halouzkovap\testPrep\text2.txt"; // vytvořil se nový textový soubor text2.txt
            //WriteFile(FileName);
            //ReadAllText(FileName);

            StreamReader mystreamReader = new StreamReader("tasks.txt");
            string line = "";
            while ((line = mystreamReader.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
            }
            mystreamReader.Close();
        }
    }
}
