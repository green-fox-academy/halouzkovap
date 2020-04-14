using System;

namespace increamentElement
{
    class Program
    {
        static void Main(string[] args)
        {

            //- Create an array variable named `t`
            //  with the following content: `[1, 2, 3, 4, 5]`
            int[] t = new int[] { 1, 2, 3, 4, 5 };
            //- Increment the third element
            t[2]++;
            //- Print the third element
            Console.WriteLine(t[2]);
            Console.ReadLine();
        }
    }
}
