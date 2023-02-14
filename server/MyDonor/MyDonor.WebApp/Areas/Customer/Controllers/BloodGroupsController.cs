
using Microsoft.AspNetCore.Mvc;

namespace MyDonor.WebApp.Areas.Customer.Controllers
{
    public class BloodGroupsController : CustomersController
    {
        private readonly BloodGroupService _service;

        public BloodGroupsController(BloodGroupService service)
        {
            _service = service;
        }

        [HttpGet]
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
