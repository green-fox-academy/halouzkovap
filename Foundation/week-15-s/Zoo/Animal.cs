﻿using System;

namespace Zoo
{
    public class Animal
    {
        //The Animal
        //Each animal should have a name and a boolean value if it is herbivore
        //Each animal should store how much food they able to eat and a current belly level as integers
        //Each animal should store a level how much food they consume from the belly while they live
        public string Name { get; set; }
        public bool Herbivore { get; set; }
        public int MaxFood { get; set; }
        public int CurrentBelly;
        public int ConsumeLevel { get; set; }

        //It should have an GetHunger  method that returns how much food the animal needs to be full

        public int GetHunger()
        {
            return MaxFood - CurrentBelly;
        }
        //It should have an Eat method that takes food as integer and fills the belly with that amount.
        //it throws an error if the food is more than it is able to eat
        public void Eat(int food)
        {
            int foodToEat = food;
            if (foodToEat > MaxFood)
            {
                throw new Exception(message: "no pleace for so much food");
            }
            CurrentBelly += foodToEat;
        }
        //It should have a Live  method that returns how much food it consumed
        public int Live()
        {
            return CurrentBelly - ConsumeLevel;
        }
        //It should have a Run method works like Live but consumes 3 times more food
        public int Run()
        {

            int comsume = Live();

            return (comsume * 3);
        }
        //It should have a GetStatus method that returns a string that states the name and the hungerlevel and wether the animal is herbivore


        public string GetStatus()
        {
            if (!Herbivore)
            {
                return $"{Name} hunger level is {ConsumeLevel} and animal is carnival, current belly {CurrentBelly}";
            }
            return $"{Name} hunger level is {ConsumeLevel} and animal is herbivore, current belly {CurrentBelly}";

        }
    }
}
