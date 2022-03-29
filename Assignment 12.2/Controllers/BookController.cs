using Microsoft.AspNetCore.Mvc;
using Assignment_12._2.Models;

namespace Assignment_12._2.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository _tempRepo;
        public BookController(IBookRepository tempRepo)
        {
            _tempRepo = tempRepo;
        }

        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Books = _tempRepo.InitializeData();
            return View(model);
        }

        public IActionResult Details(int? id)
        {
            var model = _tempRepo.GetBook(id);
            if ( model == null )
            {
                return NotFound();
            }
            return View(model);
        }
    }
}
