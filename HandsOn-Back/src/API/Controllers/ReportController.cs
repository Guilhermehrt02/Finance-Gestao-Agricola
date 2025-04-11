using Microsoft.AspNetCore.Authorization;
using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Application.InputModels.ReportModels;

namespace API.Controllers
{
    [ApiController]
    [Route("api/report")]
    [Authorize]
    public class ReportController(IReportServices reportServices) : ControllerBase
    {
        private readonly IReportServices _reportServices = reportServices;

        /// <summary>
        /// This method return report
        /// </summary>
        /// <returns>Report</returns>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        public async Task<IActionResult> GetReport([FromQuery] CreateReportInputModel inputModel)   
        {
            var report = await _reportServices.GetReportAsync(User, inputModel);
            return Ok(report);
        }
        
    }
}