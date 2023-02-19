using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDonor.Service.Services;

namespace MyDonor.WebApp.Controller.Customer.Controllers
{
    public class CustomerBuyAndBookingsController : CustomersController
    {
        private readonly BookingAndBuyingService _service;

        public CustomerBuyAndBookingsController(BookingAndBuyingService service)
        {
            _service = service;
        }

        [Authorize(Roles = "Customer")]
        [HttpPost("Customer/BookingDetail")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> BookingDetailsAsync(BookingCreateDto dto)
        {
            var result = await _service.GetBookingsAsync(dto);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [Authorize(Roles = "Customer")]
        [HttpPost("Customer/Booking")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> BookingAsync(BookingCreateDto dto)
        {
            var result = await _service.BookingsAsync(dto);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
