using Bankapp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Bankapp.Models;

namespace Bankapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Logins()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Logins(IFormCollection c)
        {
            string k = c["username"].ToString();
            string p = c["password"].ToString();
            if (k == "2018103584" && p == "Sai@14012001")
            {
                return RedirectToRoute(new { action = "Index", controller = "Log", area = "" });
            }
            else
            {
                ViewBag.Message1 = "Invalid Credentials..Try Again";
                return View();
            }
        }


        }
}