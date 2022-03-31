﻿
using Microsoft.AspNetCore.Mvc;
using Assignment_12._3.Models;

namespace Assignment_12._3.Controllers
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

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product obj)
        {
            if (ModelState.IsValid)
            {
                _tempRepo.AddProduct(obj);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _tempRepo.DeleteProduct(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Product obj = _tempRepo.GetProduct(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Update(Product obj, int id)
        {
            obj.Id = id;
            _tempRepo.UpdateProduct(obj);
            return RedirectToAction("Index");
        }
        
    }
}
