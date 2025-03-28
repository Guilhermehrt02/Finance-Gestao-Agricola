using Core.Entities;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;

using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories
{
    public class RevenueRepository(UsersDbContext context) : IRevenueRepository
    {
        private readonly UsersDbContext _context = context;

        public async Task<IEnumerable<Revenue>> GetAllByUserIdAsync(Guid userId)
        {
            return await _context.Revenues
                .Where(e => e.UserId == userId)
                .ToListAsync();
        }

        public async Task<Revenue?> GetByIdAsync(Guid userId, Guid revenueId)
        {
            return await _context.Revenues
                .Where(e => e.Id == revenueId && e.UserId == userId) 
                .FirstOrDefaultAsync();
        }

        public async Task<Revenue> AddAsync(Revenue revenue)
        {
            var result = await _context.Revenues.AddAsync(revenue);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Revenue> UpdateAsync(Revenue revenue)
        {
            var result = _context.Revenues.Update(revenue);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Revenue> DeleteAsync(Revenue revenue)
        {
            var result = _context.Revenues.Remove(revenue);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
    }
}