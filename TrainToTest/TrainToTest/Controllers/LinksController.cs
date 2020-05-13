using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using TrainToTest.Models;
using TrainToTest.Service;

namespace TrainToTest.Controllers
{
    [Route("api/links/")]

    [ApiController]
    public class LinksController : Controller
    {
        private readonly IUrlService urlService;

        public LinksController(IUrlService urlService)
        {
            this.urlService = urlService;
        }



        [HttpGet]
        public ActionResult<List<UrlDto>> GetLinks()
        {
            var urls = urlService.GetUrls();
            var urlDto = new List<UrlDto>();
            foreach (var item in urls)
            {
                urlDto.Add(new UrlDto(item.Id, item.UrlAdress, item.Alias, item.HitCount));
            }
            return Ok(urlDto);
        }

        [HttpDelete("{id}")]
        public ActionResult Deletelinks(int id, [FromBody]int secreteCode)
        {
            var url = urlService.FindAlias(id);
            if (url == null)
            {
                return NotFound();
            }
            if (urlService.SecreteCode(secreteCode, id))
            {
                urlService.DeleteUrl(id);
                return Ok();
            }
            return BadRequest();


        }
    }




}