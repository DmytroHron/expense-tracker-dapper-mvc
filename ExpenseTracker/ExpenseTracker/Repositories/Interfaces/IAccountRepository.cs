using ExpenseTracker.Models;

namespace ExpenseTracker.Repositories.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAll();
        Account GetById(int id);
        void Add(Account account);
        void Update(Account account);
        void Delete(int id);
    }
}
