using Application.ViewModels;
using System.Security.Claims;
using Application.InputModels.RevenueModels;

namespace Application.Services
{
    public interface IRevenueServices
    {
        Task<IEnumerable<RevenueViewModel>> GetAllByUserIdAsync(ClaimsPrincipal actionUser);
        Task<RevenueViewModel> GetByIdAsync(ClaimsPrincipal actionUser, Guid id);
        Task<RevenueViewModel> CreateAsync(ClaimsPrincipal actionUser, CreateRevenueInputModel inputModel);
        Task<RevenueViewModel> UpdateAsync(ClaimsPrincipal actionUser, Guid id, UpdateRevenueInputModel inputModel);
        Task<RevenueViewModel> DeleteAsync(ClaimsPrincipal actionUser, Guid id);
    }
}