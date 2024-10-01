using Microsoft.AspNetCore.Mvc;
using RVAProdavnica.Data;
using RVAProdavnica.Models;
using RVAProdavnica.Repositories;
using RVAProdavnica.Services;
using RVAProdavnica.Web.Models;
using System.Diagnostics;

namespace RVAProdavnica.Web.Controllers
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

        public IActionResult ContactUs()
        {
            return View();
        }
        
        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult BugReport(){
            return View();
        }
    }
}