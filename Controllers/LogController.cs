﻿using Microsoft.AspNetCore.Mvc;
using Bankapp.Models;
using System.Diagnostics;

namespace Bankapp.Controllers
{
    public class LogController : Controller
    {


        public IActionResult Index()
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
        public IActionResult Logout()
        {
            return View();
        }
    }
}
