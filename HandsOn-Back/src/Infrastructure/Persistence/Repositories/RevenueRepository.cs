using Core.Entities;
using Core.Repositories;
using Core.Enums;
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

        public async Task<IEnumerable<Revenue>> GetAllByUserIdAndDateRangeAsync(Guid userId, DateTime startDate, DateTime endDate, string[]? source)
        {

            if (source != null && source.Length > 0)
            {
                var sourceValues = source
                    .Select(s => (int)s.ToSource())
                    .ToArray();

                var sourceInClause = string.Join(", ", sourceValues);

                var sql = $@"
                    SELECT * FROM Revenues 
                    WHERE UserId = {{0}} 
                    AND Date >= {{1}} 
                    AND Date <= {{2}} 
                    AND Source IN ({sourceInClause})";

                return await _context.Revenues
                    .FromSqlRaw(sql, userId, startDate, endDate)
                    .ToListAsync();
            }

            return await _context.Revenues
                .Where(e => e.UserId == userId && e.Date >= startDate && e.Date <= endDate)
                .ToListAsync();
        }
    } 
}