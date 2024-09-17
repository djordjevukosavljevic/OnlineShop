using Microsoft.AspNetCore.Mvc;
using RVAProdavnica.Models;
using RVAProdavnica.Web.Controllers;
namespace RVAProdavnica.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AccountController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        // public IActionResult SignOut()
        // {
        //     return RedirectToAction("Index", "Home", new{ area = "Home" });
        // }   


    }
}
