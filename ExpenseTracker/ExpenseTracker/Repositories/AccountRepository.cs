using Dapper;
using ExpenseTracker.Models;
using ExpenseTracker.Data;
using ExpenseTracker.Repositories.Interfaces;

namespace ExpenseTracker.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DapperContext _context;
        public AccountRepository(DapperContext context)
        {
            _context = context;
        }
        public IEnumerable<Account> GetAll()
        {
            using var connection = _context.CreateConnection();
            return connection.Query<Account>("SELECT * FROM Accounts");
        }
        public Account GetById(int id)
        {
            using var connection = _context.CreateConnection();

            return connection.QuerySingleOrDefault<Account>(
                "SELECT * FROM Accounts WHERE Id = @Id",
                new { Id = id });
        }
        public void Add(Account account)
        {
            using var connection = _context.CreateConnection();

            connection.Execute(
                "INSERT INTO Accounts (Name, Balance) VALUES (@Name, @Balance)", 
                new { account.Name, account.Balance });
        }
        public void Update(Account account)
        {
            using var connection = _context.CreateConnection();

            connection.Execute(
                "UPDATE Accounts SET Name = @Name, Balance = @Balance WHERE Id = @Id",
                account);
        }
        public void Delete(int id)
        {
            using var connection = _context.CreateConnection();

            connection.Execute(
                "DELETE FROM Accounts WHERE Id = @Id",
                new { Id = id });
        }
    }
}