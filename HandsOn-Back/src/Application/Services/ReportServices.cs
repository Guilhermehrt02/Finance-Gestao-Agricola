using Core.Repositories;
using Application.ViewModels;
using Application.Exceptions;
using Application.InputModels.ReportModels;
using Application.ViewModels.ExpenseModels;
using System.Security.Claims;
using Core.Enums;

namespace Application.Services
{
    public class ReportServices(IExpenseRepository expenseRepository, IRevenueRepository revenueRepository) : IReportServices
    {
        private readonly IExpenseRepository _expenseRepository = expenseRepository;
        private readonly IRevenueRepository _revenueRepository = revenueRepository;

        public async Task<ReportViewModel> GetReportAsync(ClaimsPrincipal actionUser, CreateReportInputModel inputModel)
        {
            var userId = Guid.Parse(actionUser.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? throw new NotFoundException("User not found"));

            var endDate = inputModel.EndDate ?? DateTime.UtcNow;

            if (inputModel.Source != null && inputModel.Source.Length > 0)
            {
                foreach (var source in inputModel.Source)
                {
                    if (!Enum.IsDefined(typeof(Source), source))
                    {
                        throw new ArgumentException($"Invalid source value: {source}");
                    }
                }
            }

            if (inputModel.Category != null && inputModel.Category.Length > 0)
            {
                foreach (var category in inputModel.Category)
                {
                    if (!Enum.IsDefined(typeof(Category), category))
                    {
                        throw new ArgumentException($"Invalid category value: {category}");
                    }
                }
            }

            var expenses = await _expenseRepository.GetAllByUserIdAndDateRangeAsync(userId, inputModel.StartDate, endDate, inputModel.Category);
            var revenues = await _revenueRepository.GetAllByUserIdAndDateRangeAsync(userId, inputModel.StartDate, endDate, inputModel.Source);

            var totalExpenses = expenses.Sum(e => e.Amount);
            var totalRevenues = revenues.Sum(r => r.Amount);
            var totalBalance = totalRevenues - totalExpenses;

            var report = new ReportViewModel
            {
                TotalExpenses = totalExpenses,
                TotalRevenues = totalRevenues,
                TotalBalance = totalBalance,
                Expenses = [.. expenses.Select(ExpenseDataModel.FromEntity)],
                Revenues = [.. revenues.Select(RevenueDataModel.FromEntity)]
            };

            return report;
        }
    }
}