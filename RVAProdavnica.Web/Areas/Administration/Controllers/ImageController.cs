using System.Drawing;
using Microsoft.AspNetCore.Mvc;
using RVAProdavnica.Services;

namespace RVAProdavnica.Web.Areas.Administration.Controllers
{
    [Controller]
    [Route("api/image")]
    public class ImageController : Controller
    {
        private readonly IImageService imageService;


        public ImageController(IImageService imageService)
        {
            this.imageService = imageService;
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}