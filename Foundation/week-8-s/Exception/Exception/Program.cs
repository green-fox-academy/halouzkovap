using System;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //int x = 1;
                //int y = 0;
                //double z = x / y;
                //Console.WriteLine(z);
                Console.WriteLine("hello word");
                throw new SystemException("goodbye ");
            }
            catch (System.Exception zeroError)
            {

                Console.WriteLine(zeroError.Message);

            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
