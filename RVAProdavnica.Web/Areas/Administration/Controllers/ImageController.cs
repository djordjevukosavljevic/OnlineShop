using Microsoft.AspNetCore.Mvc;
using RVAProdavnica.Services;

namespace RVAProdavnica.Web.Areas.Administration.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService imageService;


        public ImageController(IImageService imageService)
        {
            this.imageService = imageService;
        }

    }
}