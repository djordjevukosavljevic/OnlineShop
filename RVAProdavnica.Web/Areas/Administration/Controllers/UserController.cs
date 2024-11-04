using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RVAProdavnica.Models;
using RVAProdavnica.Repositories;
using RVAProdavnica.Services;
using System.ComponentModel.DataAnnotations.Schema;

namespace RVAProdavnica.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    [Route("/Administration/[controller]/[action]/{id}")]
    public class UserController : Controller
    {
        private readonly DbContext _dbContext;

        private readonly IUserService userService;

        public UserController(IUserService userService, DbContext dbContext)
        {
            _dbContext = dbContext;
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

    }
}
