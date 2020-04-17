using BasicShop.Models;
using BasicShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BasicShop.Controllers
{
    public class ShopController : Controller
    {
        private readonly IShopData _shopData;
        private IEnumerable<Item> shoes;

        public ShopController(IShopData shopData)
        {
            _shopData = shopData;
        }
        [HttpGet]
        public IActionResult GetAllShoes()
        {

            shoes = _shopData.AllShoe();

            return View(new ShoeListViewModel
            {
                Shoes = shoes
            });
        }

        [HttpGet]
        public IActionResult OnlyAvailable()
        {
            shoes = _shopData.OnlyAvailable();
            return View(new ShoeListViewModel
            {
                Shoes = shoes
            });
        }

        [HttpGet]
        public IActionResult CheapFirts()
        {
            shoes = _shopData.CheapestFirst();
            return View(new ShoeListViewModel
            {
                Shoes = shoes
            });
        }
        [HttpGet]
        public IActionResult ContainsNike()
        {
            shoes = _shopData.ContainsNike();
            return View(new ShoeListViewModel
            {
                Shoes = shoes
            });
        }
        [HttpGet]
        public IActionResult MostExpensive()
        {
            shoes = _shopData.GetMostExpensive();
            return View(new ShoeListViewModel
            {
                Shoes = shoes
            });
        }
        [HttpGet]
        public IActionResult AveradgeStock()
        {
            var average = _shopData.Averadge();
            return View(
                new AverageStockViewModel
                {
                    Avg = average
                });

        }

        [HttpGet]
        public IActionResult GetExpensive()
        {
            shoes = _shopData.MostExpensive();
            return View(new ShoeListViewModel
            {
                Shoes = shoes
            });
        }

        [HttpPost("search")]
        public IActionResult Search(string name)
        {
            return View();
            //todo:
        }

    }


}