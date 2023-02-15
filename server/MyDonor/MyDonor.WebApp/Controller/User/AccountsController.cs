using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyDonor.WebApp.Controller.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly AccountsService _service;

        public AccountsController(AccountsService service)
        {
            _service = service;

        }

        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostLogin(LoginDto dto)
        {
            var result = await _service.LoginAsync(dto);
            if (result.IsValid)
                return Ok(result);

            return BadRequest(result.Errors);
        }
    }
}
