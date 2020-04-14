using System;

namespace PetrolStation
{
    class Car
    {

        public int GassAmout;
        public int Capacity;


        public Car(int gassAmout)
        {

            if (gassAmout > 0)
            {
                GassAmout = gassAmout;
            }
            else
            {
                Console.WriteLine("That no sence");
                GassAmout = 0;
            }

            Capacity = 100;

        }



        public void Info()
        {

            Console.WriteLine($"{GassAmout} , {Capacity}");
        }
    }
}
