using Core.Entities;
using Core.Repositories;
using Application.ViewModels;
using Application.Exceptions;
using Application.Validators;
using Application.InputModels.RevenueModels;
using System.Security.Claims;
using Core.Enums;

namespace Application.Services
{
    public class RevenueServices(IRevenueRepository revenueRepository, IUploadServices uploadServices) : IRevenueServices
    {
        private readonly IRevenueRepository _revenueRepository = revenueRepository;
        private readonly IUploadServices _uploadServices = uploadServices;

        public async Task<IEnumerable<RevenueViewModel>> GetAllByUserIdAsync(ClaimsPrincipal actionUser)
        {
            var userId = Guid.Parse(actionUser.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? throw new NotFoundException("User not found"));
            
            var revenues = await _revenueRepository.GetAllByUserIdAsync(userId);
            
            return revenues.Select(RevenueViewModel.FromEntity);
        }

        public async Task<RevenueViewModel> GetByIdAsync(ClaimsPrincipal actionUser, Guid id)
        {
            var userId = Guid.Parse(actionUser.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? throw new NotFoundException("User not found"));
            
            var revenue = await _revenueRepository.GetByIdAsync(userId, id) ?? throw new NotFoundException("Revenue not found");
            
            return RevenueViewModel.FromEntity(revenue);
        }

        public async Task<RevenueViewModel> CreateAsync(ClaimsPrincipal actionUser, CreateRevenueInputModel inputModel)
        {
            var userId = Guid.Parse(actionUser.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? throw new NotFoundException("User not found"));
            InputModelValidator.Validate(inputModel);

            var revenue = new Revenue
            {
                Description = inputModel.Description,
                Source = SourceExtension.ToSource(inputModel.Source),
                Amount = inputModel.Amount,
                Date = inputModel.Date,
                UserId = userId,
                ReceiptUrl = inputModel.ReceiptUrl
            };

            await _revenueRepository.AddAsync(revenue);
            return RevenueViewModel.FromEntity(revenue);
        }

        public async Task<RevenueViewModel> UpdateAsync(ClaimsPrincipal actionUser, Guid id, UpdateRevenueInputModel inputModel)
        {
            InputModelValidator.Validate(inputModel);

            var userId = Guid.Parse(actionUser.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? throw new NotFoundException("User not found"));
            var revenue = await _revenueRepository.GetByIdAsync(userId, id) ?? throw new NotFoundException("Revenue not found");

            if (!string.IsNullOrEmpty(inputModel.ReceiptUrl) && !string.IsNullOrEmpty(revenue.ReceiptUrl) && inputModel.ReceiptUrl != revenue.ReceiptUrl)
            {
                await _uploadServices.DeleteFileAsync(revenue.ReceiptUrl);
            }

            revenue.Update(
                inputModel.Description,
                inputModel.Source,
                inputModel.Amount,
                inputModel.Date,
                inputModel.ReceiptUrl
            );

            await _revenueRepository.UpdateAsync(revenue);
            return RevenueViewModel.FromEntity(revenue);
        }

        public async Task<RevenueViewModel> DeleteAsync(ClaimsPrincipal actionUser, Guid id)
        {
            var userId = Guid.Parse(actionUser.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? throw new NotFoundException("User not found"));
            var revenue = await _revenueRepository.GetByIdAsync(userId, id) ?? throw new NotFoundException("Revenue not found");

            if (!string.IsNullOrEmpty(revenue.ReceiptUrl))
            {
                await _uploadServices.DeleteFileAsync(revenue.ReceiptUrl);
            }

            await _revenueRepository.DeleteAsync(revenue);
            return RevenueViewModel.FromEntity(revenue);
        }
    }
}