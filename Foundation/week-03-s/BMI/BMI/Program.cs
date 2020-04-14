using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the Body mass index (BMI) based on these values
            double massInKg = 81.2;
            double heightInM = 1.78;

            // bmi = weight/height*height

            double BMI;
            BMI = massInKg / Math.Pow(heightInM, 2);
            double newBmi = Math.Round(BMI, 0);
            Console.WriteLine("your BMI is " + newBmi);

        }
    }
}
