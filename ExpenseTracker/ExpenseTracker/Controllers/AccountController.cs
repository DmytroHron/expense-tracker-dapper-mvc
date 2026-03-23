using ExpenseTracker.Models;
using ExpenseTracker.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _service;

        public AccountController(IAccountService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var accounts = _service.GetAll();
            return View(accounts);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Account account)
        {
            if (!ModelState.IsValid)
                return View(account);

            _service.Create(account);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var account = _service.GetById(id);

            if (account == null)
                return NotFound();

            return View(account);
        }

        [HttpPost]
        public IActionResult Edit(Account account)
        {
            if (!ModelState.IsValid)
                return View(account);

            _service.Update(account);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
