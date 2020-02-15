namespace PetrolStation
{
    class GassStation
    {
        public int GasAmount;

        public GassStation()
        {

        }
        public void Refill(Car car, int gass)
        {
            //decreases the gasAmount by the capacity of the car, and increases the cars gasAmount
            if ((car.Capacity < gass))
            {
                System.Console.WriteLine($"There isnt so much capacity you add only {car.Capacity}");
                car.GassAmout = car.Capacity;
                car.Capacity = 0;
                car.Info();
            }
            else
            {


                car.Capacity = 100 - gass;
                car.GassAmout += gass;
                System.Console.WriteLine("you refill your car.");
                car.Info();
            }

        }
    }
}
