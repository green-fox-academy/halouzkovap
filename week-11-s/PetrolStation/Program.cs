namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var gassStation = new GassStation();
            var car = new Car(1);
            car.Info();

            gassStation.Refill(car, 140);

        }
    }
}
