using System;
using System.Collections.Generic;

namespace CAB
{
    public class UserGues
    {
        public List<int> ListOfUserGuess;

        public void Intro()
        {
            ListOfUserGuess = new List<int>(4);
            do
            {
                int a = Convert.ToInt32(Console.ReadLine());
                AddNumbers(a);
            } while (ListOfUserGuess.Count < 4);

        }

        public void PrintGuessingNumber()
        {
            foreach (var item in ListOfUserGuess)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();

        }

        public void AddNumbers(int numberToCheck)
        {
            if (numberToCheck < 9 && numberToCheck >= 0 && !ListOfUserGuess.Contains(numberToCheck))
            {
                ListOfUserGuess.Add(numberToCheck);
            }
            else
            {
                Console.WriteLine("Your numbers have to be unique and between 0-9. Try it again");
            }
        }

        public List<int> GetUserGuess()
        {
            List<int> NewList = new List<int>();
            foreach (var item in ListOfUserGuess)
            {
                NewList.Add(item);
            }
            return NewList;
        }
    }
}
