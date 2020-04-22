using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace DIHelloWord.Models
{
    class ConsoleLoggerMiddleware : IMiddleware
    {
        private readonly IPrinter printer;

        public ConsoleLoggerMiddleware(IPrinter printer)
        {
            this.printer = printer;
        }
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            printer.Log("Hello");

            return next(context);
        }
    }
}
