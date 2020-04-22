using System;

namespace DIHelloWord.Models
{
    public class Printer : IPrinter
    {
        public void Log(string message)
        {
            Console.WriteLine(" --- " + DateTime.Now + " MY PRINTER SAYS --- " + message);
        }
    }
}
