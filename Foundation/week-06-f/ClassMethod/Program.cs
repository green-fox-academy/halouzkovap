using System;

namespace ClassMethod
{

    class Program
    {
        static void Main(string[] args)
        {
            int numo;
            var result = int.TryParse("abc", out numo);
            if (result)
            {
                Console.WriteLine(numo);
            }
            else
                Console.WriteLine("conversion faild");

            static void usePramas()
            {
                var calculator = new Calculator();
                Console.WriteLine(calculator.Add(1, 2));
                Console.WriteLine(calculator.Add(1, 2, 3, 4));
                Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));
            }

            static void UsePoint()
            {
                try
                {
                    var point = new Point(10, 20);
                    point.Move(new Point(50, 40));
                    Console.WriteLine("poin x is {0}, point y is {1}", point.X, point.Y);

                    point.Move(100, 200);
                    Console.WriteLine("poin x is {0}, point y is {1}", point.X, point.Y);

                }
                catch (Exception)
                {

                    Console.WriteLine("unecpectal error occure");
                }
            }

        }
    }
}
    

