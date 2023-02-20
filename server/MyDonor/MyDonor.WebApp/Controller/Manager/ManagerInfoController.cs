using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDonor.Service.Services;

namespace MyDonor.WebApp.Controller.Manager
{
    public class ManagerInfoController : ManagerControllerBase
    {
        private readonly ManagerService _service;

        public ManagerInfoController(ManagerService service)
        {
           _service = service;
        }

        [HttpGet("{userid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> GetStockByDistrict(string userid)
        {
            var result = await _service.GetStocks(userid);
            if(result.IsValid)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("customer/{userid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> GetCustomersByDistrict(string userid)
        {
            var result = await _service.GetCustomers(userid);
            if (result.IsValid)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
