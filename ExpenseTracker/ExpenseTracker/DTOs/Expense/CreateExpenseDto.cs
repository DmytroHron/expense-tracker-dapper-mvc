using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.DTOs.Expense
{
    public class CreateExpenseDto
    {
        [Required(ErrorMessage = "Title is required")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Range(0.01, 1000000)]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Account is required")]
        public int AccountId { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
