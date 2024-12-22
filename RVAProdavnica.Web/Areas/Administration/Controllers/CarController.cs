using Microsoft.AspNetCore.Mvc;
using RVAProdavnica.Models;
using RVAProdavnica.Services;

namespace RVAProdavnica.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    [Route("Cars/[controller]/[action]/{id}")]
    public class CarController : Controller
    {
        private readonly ICarService carService;

        public CarController(ICarService carService)
        {
            this.carService = carService;
        }

        public IActionResult Index()
        {
            var result = carService.GetAll();
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }
        

    }
}
