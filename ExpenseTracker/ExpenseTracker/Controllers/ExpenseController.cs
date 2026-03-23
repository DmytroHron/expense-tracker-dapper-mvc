using ExpenseTracker.DTOs.Expense;
using ExpenseTracker.Models;
using ExpenseTracker.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly IExpenseService _service;

        public ExpenseController(IExpenseService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var expenses = _service.GetAll();
            return View(expenses);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateExpenseDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            var expense = new Expense
            {
                Title = dto.Title,
                Amount = dto.Amount,
                CategoryId = dto.CategoryId,
                AccountId = dto.AccountId,
                Date = dto.Date
            };

            _service.Create(expense);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var expense = _service.GetById(id);

            if (expense == null)
                return NotFound();

            var dto = new UpdateExpenseDto
            {
                Id = expense.Id,
                Title = expense.Title,
                Amount = expense.Amount,
                CategoryId = expense.CategoryId,
                AccountId = expense.AccountId,
                Date = expense.Date
            };

            return View(dto);
        }

        [HttpPost]
        public IActionResult Edit(UpdateExpenseDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            var expense = new Expense
            {
                Id = dto.Id,
                Title = dto.Title,
                Amount = dto.Amount,
                CategoryId = dto.CategoryId,
                AccountId = dto.AccountId,
                Date = dto.Date
            };

            _service.Update(expense);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}