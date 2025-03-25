using Application.ViewModels;
using Application.InputModels.ExpenseModels;

namespace Application.Services
{
    public interface IExpenseServices
    {
        Task<IEnumerable<ExpenseViewModel>> GetAllAsync();
        Task<ExpenseViewModel> GetByIdAsync(Guid id);
        Task<ExpenseViewModel> CreateAsync(CreateExpenseInputModel inputModel);
        Task<ExpenseViewModel> UpdateAsync(Guid id, UpdateExpenseInputModel inputModel);
        Task<ExpenseViewModel> DeleteAsync(Guid id);
    }
}