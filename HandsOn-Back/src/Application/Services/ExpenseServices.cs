using Core.Entities;
using Core.Repositories;
using Application.ViewModels;
using Application.Exceptions;
using Application.Validators;
using Application.InputModels.ExpenseModels;

namespace Application.Services
{
    public class ExpenseServices(IExpenseRepository expenseRepository): IExpenseServices
    {
        private readonly IExpenseRepository _expenseRepository = expenseRepository;

        public async Task<IEnumerable<ExpenseViewModel>> GetAllAsync()
        {
            var expenses = await _expenseRepository.GetAllAsync();
            return expenses.Select(ExpenseViewModel.FromEntity);
        }

        public async Task<ExpenseViewModel> GetByIdAsync(Guid id)
        {
            var expense = await _expenseRepository.GetByIdAsync(id) ?? throw new NotFoundException("Expense not found");
            return ExpenseViewModel.FromEntity(expense);
        }

        public async Task<ExpenseViewModel> CreateAsync(CreateExpenseInputModel inputModel)
        {
            InputModelValidator.Validate(inputModel);
            
            var expense = new Expense
            {
                Description = inputModel.Description,
                Category = inputModel.Category,
                Amount = inputModel.Amount,
                Date = inputModel.Date,
                UserId = inputModel.UserId,
                PaymentMethod = inputModel.PaymentMethod,
                ReceiptUrl = inputModel.ReceiptUrl
            };

            await _expenseRepository.AddAsync(expense);
            return ExpenseViewModel.FromEntity(expense);
        }

        public async Task<ExpenseViewModel> UpdateAsync(Guid id, UpdateExpenseInputModel inputModel)
        {
            InputModelValidator.Validate(inputModel);
            
            var expense = await _expenseRepository.GetByIdAsync(id) ?? throw new NotFoundException("Expense not found");

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

        public async Task<ExpenseViewModel> DeleteAsync(Guid id)
        {
            var expense = await _expenseRepository.GetByIdAsync(id) ?? throw new NotFoundException("Expense not found");
            
            await _expenseRepository.DeleteAsync(expense);
            
            return ExpenseViewModel.FromEntity(expense);
        }
    }

}