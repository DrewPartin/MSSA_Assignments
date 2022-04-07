using Assignment_13._3.Filters;
using Assignment_13._3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;

namespace Assignment_13._3.Controllers
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

        [SimpleActionFilter]
        [Authorize(Roles = "Customer")]
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Products = _tempRepo.InitializeData();
            return View(model);
        }

        [Authorize()]
        public IActionResult AddProduct()
        {
            ViewBag.Servertime = DateTime.Now.ToString();
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public IActionResult AddProduct(Product obj)
        {
            if (ModelState.IsValid)
            {
                _tempRepo.AddProduct(obj);
            }
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            _tempRepo.DeleteProduct(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Update(int id)
        {
            Product obj = _tempRepo.GetProduct(id);
            return View(obj);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Update(Product obj, int id)
        {
            obj.Id = id;
            _tempRepo.UpdateProduct(obj);
            return RedirectToAction("Index");
        }
    }
}
