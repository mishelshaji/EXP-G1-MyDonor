
using Microsoft.AspNetCore.Mvc;

namespace MyDonor.WebApp.Controller.Customer.Controllers
{
    public class AccountsController : CustomersController
    {
        private readonly AccountsService _service;

        public AccountsController(AccountsService service)
        {
            _service = service;
        }

        [HttpPost("customer/register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateCustomerAsync(RegistrationCreateDto dto)
        {

            var result = await _service.CreateAsync(dto);
            if (!result.IsValid)
            {
                return BadRequest(result.Errors);
            }

            return Ok("sucessfully inserted");
        }
    }
}
