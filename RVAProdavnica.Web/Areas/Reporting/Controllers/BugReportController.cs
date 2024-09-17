using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RVAProdavnica.Data;
using RVAProdavnica.Models;
using RVAProdavnica.Services;

namespace RVAProdavnica.Web.Areas.Administration.Controllers
{
    [Area("Reporting")]
    [Route("Reporting/[controller]/[action]/{id?}")]
    public class BugReportController : Controller
    {
        #region Dependecy injection

        private readonly IBugReportService bugReportService;

        #endregion

        #region Constructors
        /// <summary>
        ///     Default constructor
        /// </summary>
        /// <param name="productService"></param>
        public BugReportController(IBugReportService bugReportService)
        {
            this.bugReportService = bugReportService;
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }
     
    }
}
