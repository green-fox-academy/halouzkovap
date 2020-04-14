namespace AircraftCarrier
{
    public class F16 : Aircrafts
    {

        public F16() : base()
        {
            name = "F16";
            currentAmmo = 0;
            maxAmmo = 8;
            baseDamage = 30;
            AmmoStorage = 0;
        }
    }
}