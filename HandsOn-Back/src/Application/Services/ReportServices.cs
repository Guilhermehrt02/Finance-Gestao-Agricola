using Core.Repositories;
using Application.ViewModels;
using Application.Exceptions;
using Application.InputModels.ReportModels;
using Application.ViewModels.ExpenseModels;
using Application.ViewModels.RevenueModels;
using System.Security.Claims;
using Core.Enums;
using Core.Entities;

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
            var totalBalance = CalculateTotalBalance(totalRevenues, totalExpenses);

            var revenueAndExpenseByPeriod = GenerateRevenueAndExpenseByPeriod([.. revenues], [.. expenses], inputModel.StartDate, endDate);

            var report = new ReportViewModel
            {
                TotalExpenses = totalExpenses,
                TotalRevenues = totalRevenues,
                TotalBalance = totalBalance,
                Expenses = [.. expenses.Select(ExpenseDataModel.FromEntity)],
                Revenues = [.. revenues.Select(RevenueDataModel.FromEntity)],
                RevenueAndExpenseByPeriod = revenueAndExpenseByPeriod
            };

            return report;
        }

        private static decimal CalculateTotalBalance(decimal totalRevenues, decimal totalExpenses)
        {
            return totalRevenues - totalExpenses;
        }

        private static RevenueAndExpenseDataModel[] GenerateRevenueAndExpenseByPeriod(Revenue[] revenues, Expense[] expenses, DateTime startDate, DateTime endDate)
        {
            var granularity = DefineGranularity(startDate, endDate);

            var groupedRevenues = revenues
                .GroupBy(r => GetGroupKey(r.Date, granularity))
                .Select(g => new RevenueAndExpenseDataModel
                {
                    Period = g.Key,
                    Type = "Receita", 
                    Amount = g.Sum(r => r.Amount) 
                })
                .ToList();

            var groupedExpenses = expenses
                .GroupBy(e => GetGroupKey(e.Date, granularity))
                .Select(g => new RevenueAndExpenseDataModel
                {
                    Period = g.Key,
                    Type = "Despesa", 
                    Amount = g.Sum(e => e.Amount) 
                })
                .ToList();

            var combinedData = groupedRevenues
                .Union(groupedExpenses)
                .OrderBy(d => d.Period) 
                .ToList();

            return [.. combinedData];
        }

        private static string DefineGranularity(DateTime startDate, DateTime endDate)
        {
            var totalDays = (endDate - startDate).TotalDays;

            if (totalDays <= 30)
            {
                return "day";
            }
            else if (totalDays <= 365)
            {
                return "month";
            }
            else
            {
                return "year";
            }
        }

        private static string GetGroupKey(DateTime date, string granularity)
        {
            return granularity switch
            {
                "day" => date.ToString("yyyy-MM-dd"), 
                "month" => date.ToString("yyyy-MM"), 
                "year" => date.ToString("yyyy"), 
                _ => throw new ArgumentException("Invalid granularity value."),
            };
        }   
    }
}