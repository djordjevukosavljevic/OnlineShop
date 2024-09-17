using Microsoft.AspNetCore.Mvc;
using RVAProdavnica.Data;

namespace RVAProdavnica.Web.Areas.Administration.Controllers
{
    public class CartController : Controller
    {
        public DataContext _dbContext;

        public CartController(DataContext dbConext)
        {
            _dbContext = dbConext;
        }


    }
}
