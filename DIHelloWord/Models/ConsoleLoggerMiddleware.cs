using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace DIHelloWord.Models
{
    class ConsoleLoggerMiddleware : IMiddleware
    {
        private readonly IPrinter printer;
        private readonly IColor color;

        public ConsoleLoggerMiddleware(IPrinter printer, IColor color)
        {
            this.printer = printer;
            this.color = color;
        }
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            printer.Log("Hello");
            color.PrintColor("yellow");

            return next(context);
        }
    }
}
