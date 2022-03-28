using Microsoft.AspNetCore.Mvc;
using Assignment_12._1.Models;

namespace Assignment_12._1.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _tempRepo;
        public ProductController(IProductRepository tempRepo)
        {
            _tempRepo = tempRepo;
        }
        public IActionResult Details(int? id)
        {
            var model = _tempRepo.GetProduct(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Products = _tempRepo.InitializeData();
            return View(model);
        }
    }
}
