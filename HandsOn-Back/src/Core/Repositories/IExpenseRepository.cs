using Core.Entities;

namespace Core.Repositories
{
    public interface IExpenseRepository
    {
        Task<IEnumerable<Expense>> GetAllAsync();
        Task<Expense?> GetByIdAsync(Guid id);
        Task<Expense> AddAsync(Expense expense);
        Task<Expense> UpdateAsync(Expense expense);
        Task<Expense> DeleteAsync(Expense expense);
    }
}