using Core.Entities;
using Core.Repositories;
using Application.ViewModels;
using Application.Exceptions;
using Application.Validators;
using Application.InputModels.ExpenseModels;
using System.Security.Claims;
using Core.Enums;

namespace Application.Services
{
    public class ExpenseServices(IExpenseRepository expenseRepository) : IExpenseServices
    {
        private readonly IExpenseRepository _expenseRepository = expenseRepository;

        public async Task<IEnumerable<ExpenseViewModel>> GetAllByUserIdAsync(ClaimsPrincipal actionUser)
        {
            var userId = Guid.Parse(actionUser.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? throw new NotFoundException("User not found"));

            var expenses = await _expenseRepository.GetAllByUserIdAsync(userId);
            
            return expenses.Select(ExpenseViewModel.FromEntity);
        }

        public async Task<ExpenseViewModel> GetByIdAsync(ClaimsPrincipal actionUser, Guid id)
        {
            var userId = Guid.Parse(actionUser.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? throw new NotFoundException("User not found"));

            var expense = await _expenseRepository.GetByIdAsync(userId, id) ?? throw new NotFoundException("Expense not found");
            return ExpenseViewModel.FromEntity(expense);
        }

        public async Task<ExpenseViewModel> CreateAsync(ClaimsPrincipal actionUser, CreateExpenseInputModel inputModel)
        {
            var userId = Guid.Parse(actionUser.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? throw new NotFoundException("User not found"));

            InputModelValidator.Validate(inputModel);
            
            var expense = new Expense
            {
                Description = inputModel.Description,
                Category = CategoryExtension.ToCategory(inputModel.Category),
                Amount = inputModel.Amount,
                Date = inputModel.Date,
                UserId = userId,
                PaymentMethod = PaymentMethodExtension.ToPaymentMethod(inputModel.PaymentMethod ?? string.Empty),
                ReceiptUrl = inputModel.ReceiptUrl
            };

            await _expenseRepository.AddAsync(expense);
            return ExpenseViewModel.FromEntity(expense);
        }

        public async Task<ExpenseViewModel> UpdateAsync(ClaimsPrincipal actionUser, Guid id, UpdateExpenseInputModel inputModel)
        {
            InputModelValidator.Validate(inputModel);
            
            var userId = Guid.Parse(actionUser.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? throw new NotFoundException("User not found"));

            var expense = await _expenseRepository.GetByIdAsync(userId, id) ?? throw new NotFoundException("Expense not found");

            expense.Update(
                inputModel.Description,
                inputModel.Category,
                inputModel.Amount,
                inputModel.Date,
                inputModel.PaymentMethod,
                inputModel.ReceiptUrl
            );

            await _expenseRepository.UpdateAsync(expense);
            return ExpenseViewModel.FromEntity(expense);
        }

        public async Task<ExpenseViewModel> DeleteAsync(ClaimsPrincipal actionUser, Guid id)
        {
            var userId = Guid.Parse(actionUser.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? throw new NotFoundException("User not found"));

            var expense = await _expenseRepository.GetByIdAsync(userId, id) ?? throw new NotFoundException("Expense not found");
            
            await _expenseRepository.DeleteAsync(expense);
            
            return ExpenseViewModel.FromEntity(expense);
        }
    }

}