using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Interfaces;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly IDateTime _dateTime;

        public HomeController(IDateTime dateTime)
        {
            _dateTime = dateTime;
        }


        public IActionResult Index()
        {
            var currentTime = _dateTime.Now;
            if (currentTime.Hour < 12)
            {
                ViewData["Message"] = "Good Morning!";
            }
            else if (currentTime.Hour < 18)
            {
                ViewData["Message"] = "Good Afternoon!";
            }
            else
            {
                ViewData["Message"] = "Good Evening!";
            }
            ViewData["Time"] = currentTime;

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
