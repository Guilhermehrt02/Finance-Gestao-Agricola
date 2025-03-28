// using Microsoft.AspNetCore.Authorization;
// using Application.Services;
// using Microsoft.AspNetCore.Mvc;

// namespace API.Controllers
// {

//     [ApiController] // This attribute indicates that this class is a controller
//     [Route("api/revenue")]
//     [Authorize] // This attribute indicates that this controller requires authentication
//     public class RevenueController(IRevenueServices revenueServices) : ControllerBase
//     {
//         private readonly IRevenueServices _revenueServices = revenueServices;

//         /// <summary>
//         /// This method returns all revenue transactions
//         /// </summary>
//         /// <returns>Revenue</returns>
//         /// <response code="200">Success</response>
//         /// <response code="401">Unauthorized</response>
//         /// <response code="500">Internal Server Error</response>
//         [HttpGet]
//         public async Task<IActionResult> GetAll()
//         {
//             var revenues = await _revenueServices.GetAllAsync();
//             return Ok(revenues);
//         }

//         /// <summary>
//         /// This method returns revenue by id
//         /// </summary>
//         /// <param name="id">Revenue Id</param>
//         /// <returns>Revenue</returns>
//         /// <response code="200">Success</response>
//         /// <response code="401">Unauthorized</response>
//         /// <response code="404">Not Found</response>
//         /// <response code="500">Internal Server Error</response>
//         [HttpGet("{id}")]
//         public async Task<IActionResult> GetById(Guid id)
//         {
//             var revenue = await _revenueServices.GetByIdAsync(id);
//             return Ok(revenue);
//         }

//         /// <summary>
//         /// This method creates a new revenue
//         /// </summary>
//         /// <param name="inputModel">Revenue Input Model</param>
//         /// <returns>Revenue</returns>
//         /// <response code="201">Created</response>
//         /// <response code="400">Bad Request</response>
//         /// <response code="401">Unauthorized</response>
//         /// <response code="500">Internal Server Error</response>
//         [HttpPost]
//         public async Task<IActionResult> Create([FromBody] CreateRevenueInputModel inputModel)
//         {
//             var revenue = await _revenueServices.CreateAsync(inputModel);
//             return CreatedAtAction(nameof(GetById), new { id = revenue.Id }, revenue);
//         }


//         /// <summary>
//         /// This method updates a revenue
//         /// </summary>
//         /// <param name="id">Revenue Id</param>
//         /// <param name="inputModel">Revenue Input Model</param>
//         /// <returns>Revenue</returns>
//         /// <response code="200">Success</response>
//         /// <response code="400">Bad Request</response>
//         /// <response code="401">Unauthorized</response>
//         /// <response code="404">Not Found</response>
//         /// <response code="500">Internal Server Error</response>
//         [HttpPut("{id}")]
//         public async Task<IActionResult> Update(Guid id, [FromBody] UpdateRevenueInputModel inputModel)
//         {
//             var revenue = await _revenueServices.UpdateAsync(id, inputModel);
//             return Ok(revenue);
//         }

//         /// <summary>
//         /// This method deletes a revenue
//         /// </summary>
//         /// <param name="id">Revenue Id</param>
//         /// <returns>No Content</returns>
//         /// <response code="204">No Content</response>
//         /// <response code="401">Unauthorized</response>
//         /// <response code="404">Not Found</response>
//         /// <response code="500">Internal Server Error</response>
//         [HttpDelete("{id}")]
//         public async Task<IActionResult> Delete(Guid id)
//         {
//             await _revenueServices.DeleteAsync(id);
//             return NoContent();
//         }

//     }
// }