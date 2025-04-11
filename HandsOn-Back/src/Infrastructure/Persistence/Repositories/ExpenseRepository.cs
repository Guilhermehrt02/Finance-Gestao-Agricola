using Core.Entities;
using Core.Enums;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;

using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories
{
    public class ExpenseRepository(UsersDbContext context) : IExpenseRepository
    {
        private readonly UsersDbContext _context = context;

        public async Task<IEnumerable<Expense>> GetAllByUserIdAsync(Guid userId)
        {
            return await _context.Expenses
                .Where(e => e.UserId == userId)
                .ToListAsync();
        }

        public async Task<Expense?> GetByIdAsync(Guid userId, Guid expenseId)
        {
            return await _context.Expenses
                .Where(e => e.Id == expenseId && e.UserId == userId) 
                .FirstOrDefaultAsync();
        }

        public async Task<Expense> AddAsync(Expense expense)
        {
            var result = await _context.Expenses.AddAsync(expense);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Expense> UpdateAsync(Expense expense)
        {
            var result = _context.Expenses.Update(expense);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Expense> DeleteAsync(Expense expense)
        {
            var result = _context.Expenses.Remove(expense);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<IEnumerable<Expense>> GetAllByUserIdAndDateRangeAsync(Guid userId, DateTime startDate, DateTime endDate, string[]? category)
        {
            if (category != null && category.Length > 0)
            {
                var categoryValues = category
                    .Select(c => (int)c.ToCategory()) // converte para enum e depois para int
                    .ToArray();

                var categoryInClause = string.Join(", ", categoryValues); // ex: "1, 2, 3"

                var sql = $@"
                    SELECT * FROM Expenses 
                    WHERE UserId = {{0}} 
                    AND Date >= {{1}} 
                    AND Date <= {{2}} 
                    AND Category IN ({categoryInClause})";

                return await _context.Expenses
                    .FromSqlRaw(sql, userId, startDate, endDate)
                    .ToListAsync();

            }
            else
            {
                return await _context.Expenses
                    .Where(e => e.UserId == userId && e.Date >= startDate && e.Date <= endDate)
                    .ToListAsync();
            }
        }

    }
}