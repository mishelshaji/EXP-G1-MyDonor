using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MyDonor.Domain.Models;
using MyDonor.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDonor.Service.Services
{

    public class BookingAndBuyingService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signinManager;
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _db;

        public BookingAndBuyingService(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<ApplicationUser> signinManager,
            IConfiguration configuration,
            ApplicationDbContext db)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signinManager = signinManager;
            _configuration = configuration;
            _db = db;
        }

        public async Task<ServiceResponse<List<BookingViewDto>>> GetBookingsAsync(BookingCreateDto dto)
        {
            var Response = new ServiceResponse<List<BookingViewDto>>();
            var managers = await _db.ApplicationUsers.FirstOrDefaultAsync(m => m.Roles == "Manager" && m.DistrictId == dto.DistrictId);
            if (managers == null)
            {
                Response.AddError("Manager", "District does not have manager");
                return Response;
            }

            var bloodbank = _db.BloodBanks.Where(m => m.ManagerId == managers.Id).FirstOrDefault();
            var appointment = _db.Appointments.Where(m => m.BloodBankId == bloodbank.Id && m.Date == dto.Date).ToList().Select(m => new BookingViewDto(m.Date, m.Time)).ToList();

            if (!appointment.Any())
            {
                Response.AddError("appointments", "Appointment is empty");
                return Response;
            }
            Response.Result = appointment;
            return Response;
        }

        public async Task<ServiceResponse<string>> BookingsAsync(BookingCreateDto dto)
        {
            var Response = new ServiceResponse<string>();
            var managers = await _db.ApplicationUsers.FirstOrDefaultAsync(m => m.Roles == "Manager" && m.DistrictId == dto.DistrictId);
            if (managers == null)
            {
                Response.AddError("Manager", "District does not have manager");
                return Response;
            }

            var bloodbank = _db.BloodBanks.Where(m => m.ManagerId == managers.Id).FirstOrDefault();
            if (bloodbank == null)
            {
                Response.AddError("Bloodbank", "bloodbank is not present");
                return Response;
            }
            var bookings = await _db.Appointments.FirstOrDefaultAsync(m => m.BloodBankId == bloodbank.Id && m.Date == dto.Date && m.Time == dto.time);
            if (bookings != null)
            {
                Response.AddError("booking", "booked");
                return Response;
            }
            var appointment = new Appointment
            {
                BloodBankId = bloodbank.Id,
                CustomerId = dto.userId,
                Date = dto.Date,
                Time = dto.time
            };
            await _db.Appointments.AddAsync(appointment);
            var userblood = await _db.ApplicationUsers.FirstOrDefaultAsync(m => m.Id == dto.userId);
            var stock = new Stock
            {
                BloodGroupId = userblood.BloodId ??= 0,
                Quantity = 1,
                BloodBankId = bloodbank.Id
            };
            await _db.Stocks.AddAsync(stock);
            await _db.SaveChangesAsync();

            Response.Result = "booking and stock updated";
            return Response;
        }
    }
}
