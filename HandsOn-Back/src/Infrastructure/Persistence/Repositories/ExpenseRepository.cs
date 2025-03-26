using Core.Entities;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;

using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories
{
    public class ExpenseRepository(UsersDbContext context) : IExpenseRepository
    {
        private readonly UsersDbContext _context = context;

        public async Task<IEnumerable<Expense>> GetAllAsync()
        {
            return await _context.Expenses.ToListAsync();
        }

        public async Task<Expense?> GetByIdAsync(Guid id)
        {
            return await _context.Expenses.FindAsync(id);
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