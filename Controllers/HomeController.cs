﻿using E_commerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace E_commerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult shop()
        {
            return View();
        }
        public IActionResult detail()
        {
            return View();
        }
        public IActionResult cart()
        {
            return View();
        }
        public IActionResult checkout()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
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
