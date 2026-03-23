using ExpenseTracker.DTOs.Expense;
using ExpenseTracker.Models;

namespace ExpenseTracker.Services.Interfaces
{
    public interface IExpenseService
    {
        IEnumerable<ExpenseDetailsDto> GetAll();
        Expense GetById(int id);
        void Create(Expense expense);
        void Update(Expense expense);
        void Delete(int id);
    }
}
