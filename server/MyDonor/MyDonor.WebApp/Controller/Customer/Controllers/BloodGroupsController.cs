
using Microsoft.AspNetCore.Mvc;

namespace MyDonor.WebApp.Controller.Customer.Controllers
{
    public class BloodGroupsController : CustomersController
    {
        private readonly BloodGroupService _service;

        public BloodGroupsController(BloodGroupService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetBloodAsync();
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
