using ExpenseTracker.Models;
using ExpenseTracker.Repositories.Interfaces;
using ExpenseTracker.Services.Interfaces;

namespace ExpenseTracker.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public IEnumerable<Account> GetAll()
        {
            return _accountRepository.GetAll();
        }

        public Account GetById(int id)
        {
            return _accountRepository.GetById(id);
        }

        public void Create(Account account)
        {
            _accountRepository.Add(account);
        }

        public void Update(Account account)
        {
            _accountRepository.Update(account);
        }

        public void Delete(int id)
        {
            _accountRepository.Delete(id);
        }
    }
}
