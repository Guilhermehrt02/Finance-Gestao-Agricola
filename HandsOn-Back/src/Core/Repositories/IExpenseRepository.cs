using Core.Entities;

namespace Core.Repositories
{
    public interface IExpenseRepository
    {
        Task<IEnumerable<Expense>> GetAllByUserIdAsync(Guid userId);
        Task<Expense?> GetByIdAsync(Guid userId, Guid expenseId);
        Task<Expense> AddAsync(Expense expense);
        Task<Expense> UpdateAsync(Expense expense);
        Task<Expense> DeleteAsync(Expense expense);
        Task<IEnumerable<Expense>> GetAllByUserIdAndDateRangeAsync(Guid userId, DateTime startDate, DateTime endDate, string[]? category);
    }
}