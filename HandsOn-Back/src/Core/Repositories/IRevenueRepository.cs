using Core.Entities;

namespace Core.Repositories
{
    public interface IRevenueRepository
    {
        Task<IEnumerable<Revenue>> GetAllByUserIdAsync(Guid userId);
        Task<Revenue?> GetByIdAsync(Guid userId, Guid revenueId);
        Task<Revenue> AddAsync(Revenue revenue);
        Task<Revenue> UpdateAsync(Revenue revenue);
        Task<Revenue> DeleteAsync(Revenue revenue);
    }
}