namespace GardenApp
{
    public abstract class Plant
    {
        protected string Name;
        public double waterStorage;
        public double wateringCoeficient;
        protected double maxWater;
        public Plant()
        {
            waterStorage = 0;
        }

        public virtual void Info()
        {
            if (waterStorage < 10)
            {
                System.Console.WriteLine($"The needs water");
            }
            else
            {
                System.Console.WriteLine($"The doesn´t need water");
            }
        }

        public void AddWaterStorage(double num)
        {
            waterStorage += num;
        }

        public bool NeedWater()
        {
            if (waterStorage < maxWater)
            {
                return true;
            }
            return false;
        }

    }
}
