﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceLocator.Library.Core;
using ServiceLocator.Library.Models;
using ServiceLocator.WebApp.Models;

namespace ServiceLocator.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly Manager Manager;
        public HomeController(Manager manager) => this.Manager = manager;
        public IActionResult Index()
        {
            News news = this.Manager.Newspaper.News.FirstOrDefault();
            return View(news);
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
