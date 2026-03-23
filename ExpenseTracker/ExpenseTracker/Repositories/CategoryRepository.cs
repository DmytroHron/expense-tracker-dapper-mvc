using Dapper;
using ExpenseTracker.Models;
using ExpenseTracker.Data;
using ExpenseTracker.Repositories.Interfaces;

namespace ExpenseTracker.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DapperContext _context;

        public CategoryRepository(DapperContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> GetAll()
        {
            using var connection = _context.CreateConnection();
            return connection.Query<Category>("SELECT * FROM Categories");
        }
        public Category GetById(int id)
        {
            using var connection = _context.CreateConnection();
            return connection.QuerySingleOrDefault<Category>(
                "SELECT * FROM Categories WHERE Id = @Id",
                new { Id = id });
        }

        public void Add(Category category)
        {
            using var connection = _context.CreateConnection();

            connection.Execute(
                "INSERT INTO Categories (Name) VALUES (@Name)",
                new { Name = category.Name });
        }
        public void Update(Category category)
        {
            using var connection = _context.CreateConnection();

            connection.Execute(
                "UPDATE Categories SET Name = @Name WHERE Id = @Id",
                category);
        }

        public void Delete(int id)
        {
            using var connection = _context.CreateConnection();

            connection.Execute(
                "DELETE FROM Categories WHERE Id = @Id",
                new { Id = id });
        }
    }
}
