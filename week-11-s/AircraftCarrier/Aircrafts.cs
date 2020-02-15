namespace AircraftCarrier
{

    public abstract class Aircrafts
    {
        protected string name;
        protected int currentAmmo;
        protected int maxAmmo;
        protected int baseDamage;

        public Aircrafts()
        {
            //this.currentAmmo = currentAmmo;
            //this.maxAmmo = maxAmmo;
            //this.baseDamage = baseDamage;
        }

        public int Fight()
        {
            int damage = currentAmmo * baseDamage;
            currentAmmo = 0;
            return damage;
        }

        public void Refill(int substractAmmo)
        {

        }

        public void GetType()
        {
            System.Console.WriteLine($"This is {name} type.");
        }
        public void GetStatus()
        {
            System.Console.WriteLine($"Type: {name}, Ammo:{currentAmmo}, Base Damage:{baseDamage}, All Damage :{currentAmmo * baseDamage}.");
        }
        public bool IsPriority()
        {
            return true;
        }

    }
}
