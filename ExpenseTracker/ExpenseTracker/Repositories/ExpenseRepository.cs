using Dapper;
using ExpenseTracker.Data;
using ExpenseTracker.DTOs.Expense;
using ExpenseTracker.Models;
using ExpenseTracker.Repositories.Interfaces;

namespace ExpenseTracker.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly DapperContext _context;

        public ExpenseRepository(DapperContext context)
        {
            _context = context;
        }

        public IEnumerable<ExpenseDetailsDto> GetAll()
        {
            string sql = @"
                SELECT e.Id, e.Title, e.Amount,
                       c.Name AS CategoryName,
                       a.Name AS AccountName,
                       e.Date
                FROM Expenses e
                JOIN Categories c ON e.CategoryId = c.Id
                JOIN Accounts a ON e.AccountId = a.Id";

            using var connection = _context.CreateConnection();
            return connection.Query<ExpenseDetailsDto>(sql);
        }

        public Expense GetById(int id)
        {
            using var connection = _context.CreateConnection();

            return connection.QueryFirstOrDefault<Expense>(
                "SELECT * FROM Expenses WHERE Id = @Id",
                new { Id = id });
        }

        public void Add(Expense expense)
        {
            string sql = @"
                INSERT INTO Expenses (Title, Amount, CategoryId, AccountId, Date)
                VALUES (@Title, @Amount, @CategoryId, @AccountId, @Date)";

            using var connection = _context.CreateConnection();
            connection.Execute(sql, expense);
        }

        public void Update(Expense expense)
        {
            string sql = @"UPDATE Expenses
                       SET Title = @Title,
                           Amount = @Amount,
                           CategoryId = @CategoryId,
                           AccountId = @AccountId,
                           Date = @Date
                       WHERE Id = @Id";

            using var connection = _context.CreateConnection();
            connection.Execute(sql, expense);
        }

        public void Delete(int id)
        {
            using var connection = _context.CreateConnection();

            connection.Execute("DELETE FROM Expenses WHERE Id = @Id", new { Id = id });
        }
    }
}
