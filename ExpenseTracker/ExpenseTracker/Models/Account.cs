using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Account
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Account name is required")]
        [StringLength(50, ErrorMessage = "Max length is 50 characters")]
        public string Name { get; set; }

        [Range(0, 1000000, ErrorMessage = "Balance must be positive")]
        public decimal Balance { get; set; }
    }
}
