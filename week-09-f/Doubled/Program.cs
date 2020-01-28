using System;
using System.IO;
using System.Text;

namespace Doubled
{
    class Program
    {
        public static void Doubled(string path)
        {
            StreamReader sr = new StreamReader(path);

            string line;


            while ((line = sr.ReadLine()) != null)
            {
                char[] myArr = line.ToCharArray();
                for (int i = 0; i < myArr.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        int j = 0;
                        int num = (myArr.Length / 2);
                        char[] uniqueArr = new char[num];
                        uniqueArr[j] = myArr[i];
                        j++;

                        foreach (var item in uniqueArr)
                        {
                            Console.Write(item);
                        }
                        Console.WriteLine();
                    }

                }

            }
        }
        static void FileRead(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

            byte[] buffer = new byte[1000];
            int byteRead = fs.Read(buffer, 0, buffer.Length);
            string text = (Encoding.ASCII.GetString(buffer, 0, byteRead));

            byte[] byteTex = Encoding.ASCII.GetBytes(text);
            byte[] uniqueArr = new byte[byteTex.Length];
            int j = 0;

            for (int i = 0; i < byteTex.Length; i++)
            {
                if (i % 2 == 0)
                {
                    uniqueArr[j] = byteTex[i];
                    j++;
                }

            }


            foreach (var item in uniqueArr)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            string unique = Encoding.ASCII.GetString(uniqueArr);
            Console.WriteLine(unique);



            fs.Close();


        }
        static void Main(string[] args)
        {
            string path = @"C:\Users\halouzkova\source\repos\Doubled\doubled.txt";

            Doubled(path);


            Console.ReadLine();
        }
    }

}
