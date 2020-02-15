namespace AircraftCarrier
{
    class Program
    {
        static void Main(string[] args)
        {
            Aircrafts f16 = new F16();
            Aircrafts f35 = new F35();

            f16.Fight();
            f16.GetType();
            f16.GetStatus();
        }
    }
}
