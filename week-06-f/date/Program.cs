using System;
using System.Collections.Generic;
using System.Linq;

namespace date
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2020 ,1, 5);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hours: " + now.Hour);
            Console.WriteLine("minute: "+ now.Minute);
            Console.WriteLine("years: " + now.Year);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToString("yyyy-MM hh-mm-ss"));

            //creating
            var timeSpan = new TimeSpan(1,2,3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSapn2 = TimeSpan.FromHours(1);

            Console.WriteLine(timeSapn2);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("duration is: " + duration);

            // properties
            Console.WriteLine("minutes " + timeSpan.Minutes);
            Console.WriteLine("total minutes " + timeSpan.TotalMinutes);

            //add

            Console.WriteLine("add example " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("subtract example " + timeSpan.Subtract(TimeSpan.FromMinutes(8)));

            Console.WriteLine("example 2 " + timeSpan.Add(TimeSpan.FromHours(3)));

            //to String

            Console.WriteLine("To string "+ timeSpan.ToString());

            // Parse
            Console.WriteLine("to parse " + TimeSpan.Parse("01:02:03"));


        }
    }
}
