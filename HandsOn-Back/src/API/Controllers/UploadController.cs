using Microsoft.AspNetCore.Mvc;
using Application.Services;

namespace API.Controllers
{
    [ApiController]
    [Route("api/upload")]
    public class UploadController(IUploadServices uploadServices) : ControllerBase
    {
        private readonly IUploadServices _uploadServices = uploadServices;

        /// <summary>
        /// This method uploads a file to the server
        /// </summary>
        /// <returns>File URL</returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost("file")]
        public async Task<IActionResult> UploadFile([FromForm] string? description, [FromForm] DateTime? clientDate, IFormFile file)
        {

            var fileUrl = await _uploadServices.UploadFileAsync(file);
            return Ok(fileUrl);
        }
    }
}