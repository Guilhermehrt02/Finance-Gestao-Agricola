namespace Core.Entities
{
    public class Report
    {
        public decimal TotalExpenses { get; set; }
        public decimal TotalRevenues { get; set; }
        public decimal TotalBalance { get; set; }

        public Expense[] Expenses { get; set; } = [];
        public Revenue[] Revenues { get; set; } = [];

        public Report() { }

        public Report(decimal totalExpenses, decimal totalRevenues, decimal totalBalance, Expense[] expenses, Revenue[] revenues)
        {
            TotalExpenses = totalExpenses;
            TotalRevenues = totalRevenues;
            TotalBalance = totalBalance;
            Expenses = expenses;
            Revenues = revenues;
        }
    }
}