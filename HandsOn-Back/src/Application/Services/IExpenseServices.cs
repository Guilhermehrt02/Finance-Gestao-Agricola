using Application.ViewModels.ExpenseModels;
using Application.InputModels.ExpenseModels;
using System.Security.Claims;

namespace Application.Services
{
    public interface IExpenseServices
    {
        Task<IEnumerable<ExpenseViewModel>> GetAllByUserIdAsync(ClaimsPrincipal actionUser);
        Task<ExpenseViewModel> GetByIdAsync(ClaimsPrincipal actionUser, Guid id);
        Task<ExpenseViewModel> CreateAsync(ClaimsPrincipal actionUser, CreateExpenseInputModel inputModel);
        Task<ExpenseViewModel> UpdateAsync(ClaimsPrincipal actionUser, Guid id, UpdateExpenseInputModel inputModel);
        Task<ExpenseViewModel> DeleteAsync(ClaimsPrincipal actionUser, Guid id);
    }
}