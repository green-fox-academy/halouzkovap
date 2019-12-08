using System;

namespace CodingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            int dailyHours = 6;
            int daysInWeek = 5;
            int weeksInSemester = 17;
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            int codingHoursInSemestr;
            codingHoursInSemestr = weeksInSemester * (dailyHours * daysInWeek);

            Console.WriteLine("you spend " + codingHoursInSemestr + " coding hours during one semestr");

            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            int codingHoursInYear = 52 * (daysInWeek * dailyHours);
            //Console.WriteLine(codingHoursInYear);

            double percentage;
            percentage = ((double)codingHoursInSemestr / codingHoursInYear)*100;
            double newPercentage = Math.Round(percentage, 2);
            Console.WriteLine("Percentage of coding hours in semester is " + newPercentage + " %.");

        }
    }
}
