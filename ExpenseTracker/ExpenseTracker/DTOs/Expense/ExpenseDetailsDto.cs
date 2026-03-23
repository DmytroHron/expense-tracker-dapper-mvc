namespace ExpenseTracker.DTOs.Expense
{
    public class ExpenseDetailsDto
    {
        public int Id { get; set; }   // удобно для delete/edit

        public string Title { get; set; }

        public decimal Amount { get; set; }

        public string CategoryName { get; set; }

        public string AccountName { get; set; }

        public DateTime Date { get; set; }
    }
}
