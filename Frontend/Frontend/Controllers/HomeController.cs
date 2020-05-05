using AutoMapper;
using Frontend.Entities;
using Frontend.Models;
using Frontend.ResourceParametrs;
using Frontend.Services;
using Microsoft.AspNetCore.Mvc;
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



        [HttpGet("doubling/{input?}")]
        public ActionResult Doubling(int? input)
        {
            if (input.HasValue)
            {
                return Ok(new { received = input, result = input * 2 });
            }
            var log = new LogObject(input.ToString(), "/doubling");
            logServices.SaveLog(log);
            return BadRequest(new { error = "Please provide an input" });
        }


        [HttpGet("greeter")]
        public ActionResult<Greet> Greeter([FromQuery] GreetingResourceParametrs greetingResourceParametrs)
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
            var log = new LogObject($"{greetingResourceParametrs.Title} {greetingResourceParametrs.Name}", "/greeter");
            logServices.SaveLog(log);

            return Ok(new { welcome_message = "Oh, hi there " + greetingResourceParametrs.Name + ", my dear " + greetingResourceParametrs.Title + "!" });

        }
        [HttpGet("appenda/{appendable}")]
        public ActionResult Appenda(string appendable)
        {
            if (!String.IsNullOrEmpty(appendable))
            {
                var newAppendWord = appendable + "A";
                var log = new LogObject(appendable, "/appenda");
                logServices.SaveLog(log);
                return Ok(new { appendable = newAppendWord });
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

                var log = new LogObject(data.until.ToString(), "/DoUntil");
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
                var log = new LogObject(data.until.ToString(), "/DoUntil");
                logServices.SaveLog(log);

                return Ok(new { result = result, status = 200 });
            }

            return BadRequest(error: "Please provide a number");
        }

        [HttpPost("arrays")]
        public ActionResult array([FromBody]arra arra)
        {
            var operation = arra.what;
            var result = 0;
            switch (operation)
            {

                case "sum":
                    result = arra.numbers.Sum();
                    var log = new LogObject(arra.numbers.ToString(), "/arrays");
                    logServices.SaveLog(log);
                    break;

                case "multiply":
                    int c = 0;
                    result = arra.numbers.Aggregate((a, b) => c = a * b);
                    log = new LogObject(arra.numbers.ToString(), "/arrays");
                    logServices.SaveLog(log);
                    break;

                case "double":
                    arra.numbers = arra.numbers.Select(x => x * 2).ToArray();
                    log = new LogObject(arra.numbers.ToString(), "/arrays");
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
            var logs = logServices.GetLogs();

            if (!String.IsNullOrWhiteSpace(logResourceParametrs.Search))
            {
                logs = logServices.SearchLog(logResourceParametrs.Search);
                return Ok(logs);
            }

            if (logResourceParametrs.CountOfEntries > 0 && logResourceParametrs.Page == 0)
            {
                logs = logServices.GetLatestLogs(logResourceParametrs.CountOfEntries);
                return Ok(logs);
            }
            if (logResourceParametrs.CountOfEntries > 0 && logResourceParametrs.Page > 0)
            {
                logs = logServices.GetSecondLatestLogs(logResourceParametrs.CountOfEntries, logResourceParametrs.Page);
                return Ok(logs);
            }

            return Ok(logs);
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

            if (count / 2 != 0)
            {
                return Ok(new { sith_text = sith.RetundSithText(text) });
            }

            return Ok(new { text_text = sith.text });
        }



        [HttpPost("translate")]
        public ActionResult Translate([FromBody]HuTranslater huTranslater)
        {
            if (huTranslater.Text == null || huTranslater.Lang == null)
            {
                return BadRequest(error: "I can't translate that!");
            }

            char[] vowels = new char[] { 'E', 'a', 'e', 'i', 'o', 'u', 'á', 'é', 'í', 'ó', 'ů', 'ú' };
            var text = huTranslater.Text.ToCharArray().ToList();
            var output = new List<char>();
            for (int i = 0; i < text.Count; i++)
            {
                if (vowels.Contains(text[i]))
                {

                    output.Add(text[i]);
                    output.Add('v');
                    output.Add(Char.ToLower(text[i]));
                }
                else
                {
                    output.Add(text[i]);
                }

            }
            var result = new String(output.ToArray());
            return Ok(new { text = result, lang = "teve" });
        }
    }
}