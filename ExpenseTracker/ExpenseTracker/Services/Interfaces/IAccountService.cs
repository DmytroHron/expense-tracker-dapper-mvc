using ExpenseTracker.Models;

namespace ExpenseTracker.Services.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAll();
        Account GetById(int id);
        void Create(Account account);
        void Update(Account account);
        void Delete(int id);
    }
}
