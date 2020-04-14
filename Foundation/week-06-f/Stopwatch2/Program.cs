using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stopwatch2
{
    class Stopwatch
    {
        private DateTime _currentTime { get; set; } = DateTime.Parse("00:00");
        private DateTime _lastTime { get; set; } = DateTime.Parse("00:00");

        

        public void Start()
        {
            if (_currentTime!= DateTime.Parse("00:00"))
                throw new InvalidOperationException("you strat twice you stopwatch");

            _currentTime = DateTime.Now;
            Console.WriteLine("Starting stopwatch");
           
        }

        public void End()
        {
           _lastTime = DateTime.Now;
            Console.WriteLine("ending stopwatch");
        }

        public void Duration()
        {
            var Duration = _lastTime - _currentTime;
            Console.WriteLine("your time is " + Duration);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {

            var stopWatch = new Stopwatch();
           
            Console.WriteLine("Welcome to stopwatch, press \"s\" to start and press \"x\" to stop and get your result...");
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "s")
                {
                    stopWatch.Start();
                }
                if (input == "x")
                {
                    stopWatch.End();
                    stopWatch.Duration();
                }

            }
        }
    } 
}

