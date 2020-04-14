using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace logs
{
    class Program
    {
        public static List<string> ReturnArrayIp(string path)
        {
            StreamReader sr = new StreamReader(path);
            string line;
            List<string> listOfIp = new List<string>();


            while ((line = sr.ReadLine()) != null)
            {

                listOfIp.Add(line.Substring(27, 11));

            }

            List<string> uniqueId = listOfIp.Distinct().ToList();

            return uniqueId;

        }
        public static string ReturnRation(string path)
        {
            StreamReader sr = new StreamReader(path);
            string line;
            List<string> getPost = new List<string>();


            while ((line = sr.ReadLine()) != null)
            {

                getPost.Add(line.Substring(41));

            }

            int TotalCount = getPost.Count;
            int getCount = 0;
            int postCount = 0;

            for (int i = 0; i < TotalCount; i++)
            {
                if (getPost[i].Contains("GET /"))
                {
                    getCount++;
                }
                else
                {
                    postCount++;
                }
            }
            string message = "Ration of GET/ : Post/ is " + getCount + ':' + postCount;
            return message;


        }
        static void Main(string[] args)
        {

            // Read all data from 'log.txt'.
            // Each line represents a log message from a web server


            string path = @"C:\Users\halouzkova\source\repos\logs\logs.txt";

            List<string> uniqueID = ReturnArrayIp(path);  // Write a function that returns an array with the unique IP adresses.
            foreach (string item in uniqueID)
            {
                Console.WriteLine(item);
            }

            // Write a function that returns the GET / POST request ratio.
            Console.WriteLine(ReturnRation(path));

            Console.ReadLine();

        }
    }
}
