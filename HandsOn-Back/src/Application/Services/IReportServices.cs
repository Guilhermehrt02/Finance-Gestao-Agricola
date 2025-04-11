using Application.ViewModels;
using Application.InputModels.ReportModels;
using System.Security.Claims;

namespace Application.Services
{
    public interface IReportServices
    {
        Task<ReportViewModel> GetReportAsync(ClaimsPrincipal actionUser, CreateReportInputModel inputModel);
    }
}