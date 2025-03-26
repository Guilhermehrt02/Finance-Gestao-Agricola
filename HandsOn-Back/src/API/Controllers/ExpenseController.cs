using Microsoft.AspNetCore.Authorization;
using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Application.InputModels.ExpenseModels;

namespace API.Controllers
{

    [ApiController] // This attribute indicates that this class is a controller
    [Route("api/expense")]
    [Authorize] // This attribute indicates that this controller requires authentication
    public class ExpenseController(IExpenseServices expenseServices) : ControllerBase
    {
        private readonly IExpenseServices _expenseServices = expenseServices;

        /// <summary>
        /// This method returns all expense transactions
        /// </summary>
        /// <returns>Expense</returns>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var expenses = await _expenseServices.GetAllByUserIdAsync(User);
            return Ok(expenses);
        }

        /// <summary>
        /// This method returns expense by id
        /// </summary>
        /// <param name="id">Expense Id</param>
        /// <returns>Expense</returns>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var expense = await _expenseServices.GetByIdAsync(User, id);
            return Ok(expense);
        }

        /// <summary>
        /// This method creates a new expense
        /// </summary>
        /// <param name="inputModel">Expense Input Model</param>
        /// <returns>Expense</returns>
        /// <response code="201">Created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateExpenseInputModel inputModel)
        {
            var expense = await _expenseServices.CreateAsync(User, inputModel);
            return CreatedAtAction(nameof(GetById), new { id = expense.Id }, expense);
        }


        /// <summary>
        /// This method updates a expense
        /// </summary>
        /// <param name="id">Expense Id</param>
        /// <param name="inputModel">Expense Input Model</param>
        /// <returns>Expense</returns>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateExpenseInputModel inputModel)
        {
            var expense = await _expenseServices.UpdateAsync(User, id, inputModel);
            return Ok(expense);
        }

        /// <summary>
        /// This method deletes a expense
        /// </summary>
        /// <param name="id">Expense Id</param>
        /// <returns>No Content</returns>
        /// <response code="204">No Content</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _expenseServices.DeleteAsync(User, id);
            return NoContent();
        }

    }
}