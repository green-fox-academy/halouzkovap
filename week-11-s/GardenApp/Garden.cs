using System.Collections.Generic;

namespace GardenApp
{
    class Garden
    {
        private List<Plant> plants;


        public Garden()
        {
            plants = new List<Plant>();
        }

        public void Add(Plant flower)
        {
            plants.Add(flower);
        }

        public void GardenInfo()
        {
            foreach (var item in plants)
            {
                item.Info();
            }

        }

        public void FeedGarden(double num)
        {
            double whoNeedsWater = WhoNeedsWater();
            double everyPlangGets = num / whoNeedsWater;
            foreach (var item in plants)
            {
                if (item is Flowers)
                {
                    if (item.NeedWater())
                    {
                        double bum = (double)everyPlangGets * item.wateringCoeficient;
                        item.AddWaterStorage(bum);
                    }
                }
                else if (item is Tree)
                {
                    if (item.NeedWater())
                    {
                        double bum = (double)everyPlangGets * item.wateringCoeficient;
                        item.AddWaterStorage(bum);
                    }
                }
            }
        }

        private double WhoNeedsWater()
        {
            double needs = 0;
            foreach (var item in plants)
            {
                if (item.NeedWater())
                {
                    needs++;

                }
            }

            return needs;
        }
    }
}