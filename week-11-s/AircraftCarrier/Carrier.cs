using System.Collections.Generic;

namespace AircraftCarrier
{
    class Carrier
    {
        private List<Aircrafts> Aircrafts;
        private int HP;
        public Carrier()
        {
            Aircrafts = new List<Aircrafts>();
            HP = 0;
        }

        public void Add(Aircrafts name)
        {
            Aircrafts.Add(name);
            HP += 1000;
        }

        public void ReFillCarrier(int numOfAmmo)
        {
            int refill = numOfAmmo;
            int newRell = 0;

            foreach (var item in Aircrafts)
            {
                bool prioriy = item.IsPriority();

                if (prioriy)
                {
                    newRell = item.Refill(refill);
                    if (newRell <= 0)
                    {
                        break;
                    }
                    else
                    {
                        refill = newRell;
                        continue;
                    }
                }
                else
                {
                    newRell = item.Refill(refill);
                    if (newRell <= 0)
                    {
                        break;
                    }
                    else
                    {
                        refill = newRell;
                        continue;
                    }
                }
            }
        }
        public void FigthCarrir(Carrier carrier)
        {
            int totalDamage = this.TotalDamage();

        }
        public void GetStatus()
        {
            int TotalDem = TotalDamage();
            int AmmoStorage = TotalAmmoStorage();
            System.Console.WriteLine($"HP is {HP}, there are {Aircrafts.Count} Aircragts, total demage is {TotalDem}, total amo storage is {AmmoStorage}");
            System.Console.WriteLine("Aircrafts:");
            foreach (var item in Aircrafts)
            {
                item.GetStatus();

            }


        }
        private int TotalDamage()
        {
            int TotalDamage = 0;
            foreach (var item in Aircrafts)
            {
                TotalDamage += item.currentAmmo * item.baseDamage;
            }
            return TotalDamage;
        }
        private int TotalAmmoStorage()
        {
            int TotalStorage = 0;
            foreach (var item in Aircrafts)
            {
                TotalStorage += item.AmmoStorage;
            }
            return TotalStorage;
        }

    }
}
