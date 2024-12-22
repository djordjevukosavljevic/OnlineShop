 using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RVAProdavnica.Data;
using RVAProdavnica.Models;
using RVAProdavnica.Services;
 
namespace RVAProdavnica.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    [Route("Administration/[controller]/[action]/{id?}")]
    public class ProductController : Controller
    {
        #region Dependecy injection

        private readonly IProductService productService;

        #endregion

        #region Constructors
        /// <summary>
        ///     Default constructor
        /// </summary>
        /// <param name="productService"></param>
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        #endregion

        #region Function
        /// <summary>
        ///     Get All Products
        /// </summary>
        /// <returns></returns>
        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Index()
        {
            var result = productService.GetAll();
            return View(result);
        }

        #endregion
        /// <summary>
        ///     Create Method 
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        ///     Create method - POST
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(ProductModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Response"] = false;
                TempData["ResponseMessage"] = "Neuspesno kreiranje!";

                return View(model);
            }
            try
            {
                var result = productService.Create(model);

                if (result != null)
                {
                    TempData["Response"] = true;
                    TempData["ResponseMessage"] = "Uspesno kreirano!";
                }
                else
                {
                    TempData["Response"] = false;
                    TempData["ResponseMessage"] = "Neuspesno kreiranje!";
                }

                return View(model);
            }
            catch (Exception ex)
            {
                TempData["Response"] = false;
                TempData["ResponseMessage"] = "Neuspesno kreiranje!";
                Console.WriteLine(ex.Message);
                return View(model);
            }
        }

        /// <summary>
        ///     Edit Method 
        /// </summary>
        /// <returns></returns>
        public IActionResult Edit(int id)
        {
            var result = productService.getById(id);
            return View(result);
        }

        /// <summary>
        ///     Edit method - POST
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(ProductModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Response"] = false;
                TempData["ResponseMessage"] = "Neuspesno promenjeno!";

                return View(model);
            }
            try
            {
                productService.Update(model);

                TempData["Response"] = true;
                TempData["ResponseMessage"] = "Uspesno promenjeno!";

                return View(model);
            }
            catch (Exception ex)
            {
                TempData["Response"] = false;
                TempData["ResponseMessage"] = "Neuspesno kreirano!";
                Console.WriteLine(ex.Message);
                return View(model);
            }
        }
    
        
        // Metoda za brisanje producta iz baze
        [HttpDelete]
        public void Delete(Product obj)
        {
            try
            {
                productService.Delete(obj);

                TempData["Response"] = true;
                TempData["ResponseMessage"] = "Uspesno izbrisano!";

            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                TempData["Response"] = false;
                TempData["ResponseMessage"] = "Neuspesno brisanje!";
            }

        }

        /// <summary>
        ///     Rows for products
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="rowsPerPage"></param>
        /// <returns></returns>
        public IActionResult Rows(int pageNumber, int rowsPerPage, string search)
        {
            var products = productService.TableSearch(pageNumber, rowsPerPage, search);
            return View(products);
        }
        
    }
}
