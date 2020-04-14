using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lotery
{

    class Program
    {

        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"C:\Users\halouzkova\source\repos\FileIO\Lotery.csv"))
            {
                List<int> listA = new List<int>();
                List<int> listB = new List<int>();
                List<int> listC = new List<int>();
                List<int> listD = new List<int>();
                List<int> listE = new List<int>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listA.Add(int.Parse(values[11]));
                    listB.Add(int.Parse(values[12]));
                    listC.Add(int.Parse(values[13]));
                    listD.Add(int.Parse(values[14]));
                    listE.Add(int.Parse(values[15]));
                }


                listA.AddRange(listB);
                listA.AddRange(listC);
                listA.AddRange(listD);
                listA.AddRange(listE);


                var dict = listA.GroupBy(x => x)
                    .Select(g => new { Value = g.Key, Count = g.Count() })
                    .OrderBy(x => x.Count)
                    .TakeLast(5);



                Console.WriteLine("total count :" + listA.Count);

                foreach (var item in dict)
                {
                    Console.WriteLine(item);
                }


            }
            static void readFile()
            {
                string[] input = null;
                try
                {
                    input = File.ReadAllLines(@"C:\Users\halouzkova\source\repos\FileIO\Lotery.csv");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                string[][] splitInput = new string[input.Length][];
                string[] help;
                for (int i = 0; i < input.Length; i++)
                {
                    help = input[i].Split(";");
                    splitInput[i] = new string[help.Length];
                    splitInput[i] = help;
                }
                Dictionary<int, int> numbersCount = new Dictionary<int, int>();
                for (int i = 0; i < splitInput.Length; i++)
                {
                    for (int j = 11; j < splitInput[i].Length; j++)
                    {
                        if (numbersCount.ContainsKey(Int32.Parse(splitInput[i][j])))
                        {
                            numbersCount[Int32.Parse(splitInput[i][j])]++;
                        }
                        else numbersCount.Add(Int32.Parse(splitInput[i][j]), 1);
                    }
                }
                var numbersCountSorted = numbersCount.OrderBy(x => x.Value);
                foreach (var number in numbersCountSorted)
                {
                    Console.WriteLine($"{number.Key} : {number.Value}");
                }
            }
        }
    }
}
