using Core.Entities;
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
    }
}