using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.Protocol;
using RVAProdavnica.Data;
using RVAProdavnica.Models;
using RVAProdavnica.Repositories;
using RVAProdavnica.Services;
using System.ComponentModel.DataAnnotations.Schema;

namespace RVAProdavnica.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    [Route("api/user")]
    public class UserController : Controller
    {
        private readonly DbContext dbContext;
        private readonly IUserService userService;


        public UserController(DbContext dbContext, IUserService userService)
        {
            this.dbContext = dbContext;
            this.userService = userService;
        }

        [HttpGet("/{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = userService.GetById(id);
            if (user == null)
            {
                return NotFound(new { message = "User not found!" });
            }
            return Ok(user);

        }

    }

    
}
