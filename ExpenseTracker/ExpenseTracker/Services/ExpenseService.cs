using ExpenseTracker.Models;
using ExpenseTracker.DTOs.Expense;
using ExpenseTracker.Repositories.Interfaces;

namespace ExpenseTracker.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _expenseRepository;

        public ExpenseService(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public IEnumerable<ExpenseDetailsDto> GetAll()
        {
            return _expenseRepository.GetAll();
        }

        public Expense GetById(int id)
        {
            return _expenseRepository.GetById(id);
        }

        public void Create(Expense expense)
        {
            if (expense.Amount <= 0)
                throw new Exception("Amount must be greater than 0");

            _expenseRepository.Add(expense);
        }

        public void Update(Expense expense)
        {
            _expenseRepository.Update(expense);
        }

        public void Delete(int id)
        {
            _expenseRepository.Delete(id);
        }
    }
}
