using System;
using System.Collections.Generic;

namespace CAB
{
    public class UserGues
    {
        private List<int> ListOfUserGuess;
        private int a;

        public void Intro()
        {
            Console.WriteLine("guess numbers");
            Console.WriteLine("Write 4 numbers to console these numberes cannot repeat");
            ListOfUserGuess = new List<int>(4);
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                AddNumbers(a);
            } while (ListOfUserGuess.Count < 4);


            foreach (var item in ListOfUserGuess)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
        }

        protected void AddNumbers(int a)
        {

            if (!ListOfUserGuess.Contains(a))
            {
                ListOfUserGuess.Add(a);
            }
            else
            {
                Console.WriteLine("you already have this number, try another one");
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
