using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{

    class Zoo
    {
        //It should store food levels as integers
        //    There are two types of food meat and vegetables
        //It should store a shit level that is 0 on the beginning
        //    It should have a constructor that takes two parameters the food levels as integers
        //    It should have an AddAnimal method that takes a new animal


        //    It should have a SpendNormalDay method that calls the Live and Run methods of each animals and aggregates all the consumed foods as shit into the shit levels
        //    It should have a SpendQuarantineDay method that does the same as SpendNormalDay just only calls the Live  method

        public List<Animal> Animals;
        private int ShitLevel;
        public int MaxFoodLevel;
        public int Stock;
        public int mealOnStock;
        public int vegetableOnStock;


        public Zoo(int totalFood, int currentFood)
        {
            Animals = new List<Animal>();
            ShitLevel = 0;
            mealOnStock = currentFood;
            vegetableOnStock = currentFood;
            MaxFoodLevel = totalFood;
            Stock = vegetableOnStock + mealOnStock;
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }

        public void FeedAllAnimals()
        {
            // It should have a FeedAllAnimals  method that feeds all the animals with the maximum food
            // it can provide and it feed vegetables to herbivores and meat to carnivores
            foreach (var animal in Animals)
            {
                if (!animal.Herbivore)
                {
                    if ((animal.MaxFood - animal.CurrentBelly) < mealOnStock)
                    {
                        animal.CurrentBelly = animal.MaxFood;
                        mealOnStock -= (animal.MaxFood - animal.CurrentBelly);
                    }
                    else
                    {
                        Console.WriteLine("out of meal");
                    }
                }
                else if (animal.Herbivore)
                {
                    if ((animal.MaxFood - animal.CurrentBelly) < vegetableOnStock)
                    {
                        animal.CurrentBelly = animal.MaxFood;
                        vegetableOnStock -= (animal.MaxFood - animal.CurrentBelly);
                    }
                    else
                    {
                        Console.WriteLine("out of vegetable");
                    }
                }
            }

        }

        public void RefillFood(int vegetables, int meat)
        {
            //    It should have a RefillFood method that takes meat and vegetable levels and adds them to the stock
            vegetableOnStock += vegetables;
            mealOnStock += meat;
        }

        public int SpendNormalDay()
        {
            int shit = 0;
            foreach (var animal in Animals)
            {
                shit += animal.Live();
                shit += animal.Run();
            }

            return ShitLevel += shit;
        }

        public int SpendQuarantineDay()
        {
            int shit = 0;
            foreach (var animal in Animals)
            {
                shit += animal.Live();
            }

            return ShitLevel += shit;
        }


        public string GetTheFullestStatus()
        {
            //    It should have a GetTheFullestStatus method that returns the status of the animal that is the least hungry,
            // it should take a filterHerbivore parameter and if that is true it should only search between the carnivores
            StringBuilder st = new StringBuilder();

            var CarniAnimal = Animals.Where(x => x.Herbivore != true)
                .OrderBy(x => x.GetHunger()).ToList();


            st.Append("Carnivore" + Environment.NewLine);
            foreach (var carn in CarniAnimal)
            {
                st.Append(carn.GetStatus() + Environment.NewLine);
            }

            st.Append("Herbivore :" + Environment.NewLine);

            var HerbiAnimal = Animals.Where(x => x.Herbivore != false)
                .OrderBy(x => x.GetHunger()).ToList();

            foreach (var herbi in HerbiAnimal)
            {
                st.Append(herbi.GetStatus() + Environment.NewLine);
            }

            return st.ToString();
        }
    }
}
