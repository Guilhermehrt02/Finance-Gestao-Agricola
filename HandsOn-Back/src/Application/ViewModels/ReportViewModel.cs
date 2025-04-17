using Core.Entities;
using Core.Enums;
using Application.ViewModels.ExpenseModels;
using Application.ViewModels.RevenueModels;
using Application.ViewModels;

namespace Application.ViewModels
{
    public class ReportViewModel
    {
        public decimal TotalExpenses { get; set; }
        public decimal TotalRevenues { get; set; }
        public decimal TotalBalance { get; set; }
        public ExpenseDataModel[] Expenses { get; set; } = [];
        public RevenueDataModel[] Revenues { get; set; } = [];
        public RevenueAndExpenseDataModel[] RevenueAndExpenseByPeriod {get; set; } = [];

        public static ReportViewModel FromEntity(Report report)
        {
            return new ReportViewModel
            {
                TotalExpenses = report.TotalExpenses,
                TotalRevenues = report.TotalRevenues,
                TotalBalance = report.TotalBalance,
                Expenses = [.. report.Expenses.Select(ExpenseDataModel.FromEntity)],
                Revenues = [.. report.Revenues.Select(RevenueDataModel.FromEntity)]
            };
        }
    }
}