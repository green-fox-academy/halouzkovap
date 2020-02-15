namespace AircraftCarrier
{

    public abstract class Aircrafts
    {
        protected string name;
        public int currentAmmo;
        protected int maxAmmo;
        public int baseDamage;

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
            int canBerefill = maxAmmo - currentAmmo;
            if (substractAmmo <= canBerefill)
            {
                currentAmmo += substractAmmo;
            }
            else
            {
                int remaining = substractAmmo - canBerefill;
                currentAmmo = maxAmmo;
                System.Console.WriteLine("you could add so many ammo. " +
                    "now you have {0} ammo in your storage and remaining ammo is {1}", currentAmmo, remaining);
            }

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
            if (name == "F16")
            {
                return false;
            }
            return true;
        }

    }
}
