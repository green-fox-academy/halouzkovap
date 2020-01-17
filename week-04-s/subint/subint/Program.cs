using System;

namespace subint
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 1;
            int[] array = { 1, 2, 3, 5, 6 };

            SubInt(a, array);
            int c = SubInt(a,array);
            if (c == 1)
            {
               
                 foreach ( int item in array)
                { Console.Write(item); }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("[]");
            }
                


            static int SubInt(int a, int[] b)
            {
                foreach(int number in b)
                {
                    if (a == number)
                    {
                        return 1;
                            break;
                    }
                      
                }
                return 0;
            }
        }
    }
}
