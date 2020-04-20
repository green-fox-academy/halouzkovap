using Microsoft.AspNetCore.Mvc;
using MvcStart.Models;

namespace MvcStart.Controllers
{
    public class RestController : Controller
    {
        public Greeting Greet(string name)
        {
            var greeting = new Greeting(name);


            return greeting;
        }
    }
}