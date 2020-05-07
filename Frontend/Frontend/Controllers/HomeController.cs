using AutoMapper;
using Frontend.Entities;
using Frontend.Models;
using Frontend.ResourceParametrs;
using Frontend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Frontend.Controllers
{
    [Route("/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogServices logServices;
        private readonly IMapper mapper;

        public HomeController(ILogServices logServices, IMapper mapper)
        {
            this.logServices = logServices;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }


        [Route("doubling/{input?}")]
        [HttpGet]
        [HttpHead]
        public ActionResult doubling(int? input)
        {

            if (input.HasValue)
            {

                var log = new LogObject(input.ToString(), RouteData.Values["action"].ToString());
                logServices.SaveLog(log);
                return Ok(new { received = input, result = input * 2 });
            }

            return BadRequest(new { error = "Please provide an input" });
        }


        [HttpGet("greeter")]
        public ActionResult<Greet> greeter([FromQuery] GreetingResourceParametrs greetingResourceParametrs)
        {
            if (greetingResourceParametrs.Name == null && greetingResourceParametrs.Title == null)
            {
                return BadRequest(new { error = "Please provide a name and a title!" });
            }
            else if (greetingResourceParametrs.Name == null)
            {
                return BadRequest(new { error = "Please provide a name!" });
            }
            else if (greetingResourceParametrs.Title == null)
            {
                return BadRequest(new { error = "Please provide a title!" });
            }
            var log = new LogObject($"{greetingResourceParametrs.Title} {greetingResourceParametrs.Name}", RouteData.Values["action"].ToString());
            logServices.SaveLog(log);

            return Ok(new { welcome_message = "Oh, hi there " + greetingResourceParametrs.Name + ", my dear " + greetingResourceParametrs.Title + "!" });

        }
        [HttpGet("appenda/{appendable}")]
        public ActionResult Appenda(string appendable)
        {
            if (!String.IsNullOrEmpty(appendable))
            {
                var newAppendWord = appendable + "a";
                var log = new LogObject(appendable, RouteData.Values["action"].ToString());
                logServices.SaveLog(log);
                return Ok(new { newAppendWord });
            }

            return BadRequest();
        }

        [HttpPost("dountil/{acion}")]
        public ActionResult DoUntil([FromRoute] string acion, [FromBody]JsonObject data)
        {
            if (acion == "sum")
            {
                int result = 0;
                for (int i = 1; i <= data.until; i++)
                {
                    result += i;
                }

                var log = new LogObject(data.until.ToString(), RouteData.Values["action"].ToString());
                logServices.SaveLog(log);

                return Ok(new { result = result, status = 200 });
            }

            if (acion == "factor")
            {
                int result = 1;
                for (int i = 1; i <= data.until; i++)
                {
                    result *= i;
                }
                var log = new LogObject(data.until.ToString(), RouteData.Values["action"].ToString());
                logServices.SaveLog(log);

                return Ok(new { result = result, status = 200 });
            }

            return BadRequest(error: "Please provide a number");
        }

        [HttpPost("arrays")]
        public ActionResult arrays([FromBody]arra arra)
        {
            var operation = arra.what;
            var result = 0;
            switch (operation)
            {

                case "sum":
                    result = arra.numbers.Sum();
                    var log = new LogObject(arra.numbers.ToString(), RouteData.Values["action"].ToString());
                    logServices.SaveLog(log);
                    break;

                case "multiply":
                    int c = 0;
                    result = arra.numbers.Aggregate((a, b) => c = a * b);
                    log = new LogObject(arra.numbers.ToString(), RouteData.Values["action"].ToString());
                    logServices.SaveLog(log);
                    break;

                case "double":
                    arra.numbers = arra.numbers.Select(x => x * 2).ToArray();
                    log = new LogObject(arra.numbers.ToString(), RouteData.Values["action"].ToString());
                    logServices.SaveLog(log);
                    return Ok(arra.numbers);

                default:
                    return BadRequest(error: "Please provide a number");
            }


            return Ok(result);
        }

        [HttpGet("log")]
        public ActionResult<IEnumerable<LogObject>> Log([FromQuery]LogResourceParametrs logResourceParametrs)
        {


            if (!String.IsNullOrWhiteSpace(logResourceParametrs.Search))
            {
                var logs = logServices.SearchLog(logResourceParametrs.Search);
                return Ok(logs);
            }

            if (logResourceParametrs.CountOfEntries > 0 && logResourceParametrs.Page == 0)
            {
                var logs = logServices.GetLatestLogs(logResourceParametrs.CountOfEntries);
                return Ok(logs);
            }
            if (logResourceParametrs.CountOfEntries > 0 && logResourceParametrs.Page > 0)
            {
                var logs = logServices.GetSecondLatestLogs(logResourceParametrs.CountOfEntries, logResourceParametrs.Page);
                return Ok(logs);
            }
            var logss = logServices.GetLogs();
            return Ok(logss);
        }

        [HttpPost("sith")]
        public ActionResult<SithObj> Sith([FromBody] SithObj sith)
        {
            var text = sith.text;
            if (text == null)
            {
                return BadRequest(error: "Feed me some text you have to, padawan young you are. Hmmm.");
            }

            var count = text.Split(new[] { ' ' }).ToArray().Count();

            var log = new LogObject(sith.text, RouteData.Values["action"].ToString());
            logServices.SaveLog(log);

            if (count % 2 != 0)
            {
                var newSith = sith.RetundSithText(text);
                log = new LogObject(sith.text, RouteData.Values["action"].ToString());

                logServices.SaveLog(log);
                return Ok(newSith.sith_text);
            }

            return Ok(new { text_text = sith.text });
        }



        [HttpPost("translate")]
        public ActionResult<HuTranslater> Translate([FromBody]HuTranslater huTranslater)
        {
            if (huTranslater.Text == null || huTranslater.Lang == null)
            {
                return BadRequest(error: "I can't translate that!");
            }

            var result = huTranslater.Translater(huTranslater.Text);

            return Ok(result);
        }
    }
}