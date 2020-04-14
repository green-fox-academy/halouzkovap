using System;
using System.Collections.Generic;
using System.Linq;

namespace matchinch
{
    class Program
    {
        static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Claire", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Tom", "Todd", "Neef", "Jeff" };

            // Write a method that joins the two lists by matching one girl with one boy into a new list
            // If someone has no pair, he/she should be the element of the list too
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            MakingMatches(girls, boys);
        }
        static void MakingMatches(List<string> girls, List<string> boys)
        {
            List<string> couples = new List<string>();
            couples = couples.Concat(boys).ToList();

            int j = 0;

            for (int i = 0; i < girls.Count; i++)
            {


                couples.Insert((i + j), girls[i]);
                j++;

            }



            foreach (var item in couples)
            {
                Console.WriteLine(item);
            }

        }
    }
}
