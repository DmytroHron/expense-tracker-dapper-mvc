using ExpenseTracker.DTOs.Expense;
using ExpenseTracker.Models;

namespace ExpenseTracker.Repositories.Interfaces
{
    public interface IExpenseRepository
    {
        IEnumerable<ExpenseDetailsDto> GetAll();
        Expense GetById(int id);
        void Add(Expense expense);
        void Update(Expense expense);
        void Delete(int id);
    }
}
