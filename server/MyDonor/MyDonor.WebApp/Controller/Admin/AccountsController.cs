using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDonor.service.Services;
using MyDonor.Service.Dto;

namespace MyDonor.WebApp.Controller.Admin
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

        [HttpPost("Manager")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> ManagerAsync(ManagerCreateDto dto)
        {
            var manager = await _service.ManagerCreateAsync(dto);
            if( manager.IsValid)
            {
                return BadRequest(manager.Errors);
            }
            return Ok(manager);
        }

        //public async Task<IActionResult> FeedbackView()
        //{
        //    var result = _service.Feedbacks();
        //}
    }
}
