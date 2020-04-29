﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Reddit.Models;
using Reddit.Servises;
using Reddit.ViewModel;
using System.Diagnostics;

namespace Reddit.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IPostService postService;

        public HomeController(ILogger<HomeController> logger, IPostService postService)
        {
            this.logger = logger;
            this.postService = postService;
        }

        public IActionResult Index()
        {
            var posts = postService.GellAllPost();
            return View(new PostViewModel
            {
                Posts = posts
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
