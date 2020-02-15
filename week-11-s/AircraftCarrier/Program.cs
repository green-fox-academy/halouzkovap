namespace AircraftCarrier
{
    class Program
    {
        static void Main(string[] args)
        {
            Aircrafts f16 = new F16();
            Aircrafts f35 = new F35();

            //f16.Fight();
            //f16.Refill(16);
            //f16.GetType();
            //f16.GetStatus();

            var listOfAircrafts = new Carrier();

            listOfAircrafts.Add(f16);
            listOfAircrafts.Add(f35);

            listOfAircrafts.GetStatus();
        }
    }
}
