using ExpenseTracker.Models;
using ExpenseTracker.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var categories = _service.GetAll();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
                return View(category);

            _service.Create(category);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var category = _service.GetById(id);

            if (category == null)
                return NotFound();

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (!ModelState.IsValid)
                return View(category);

            _service.Update(category);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
