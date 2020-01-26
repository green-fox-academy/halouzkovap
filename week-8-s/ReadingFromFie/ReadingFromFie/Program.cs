using System;
using System.IO;

namespace ReadingFromFie
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("TextFile1.txt");
            string data = sr.ReadLine();

            while (data != null)
            {
                Console.WriteLine(data);
                string[] values = data.Split(',');
                int frequency = Int32.Parse(values[0]);
                int duration = Int32.Parse(values[1]);
                Console.Beep(frequency, duration);
                data = sr.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
