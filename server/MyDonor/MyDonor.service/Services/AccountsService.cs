﻿
using MyDonor.service.Dto;

namespace MyDonor.service.Services
{
    public class AccountsService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;

        public AccountsService
            (
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext db
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
        }

        public async Task<ServiceResponse<bool>> CreateAsync(RegistrationCreateDto dto)
        {
            var Response = new ServiceResponse<bool>();
            var useremail = await _userManager.FindByEmailAsync(dto.email);
            if (useremail != null)
            {
                Response.AddError("", "An account with this email exist.");
                return Response;
            }
            var user = new ApplicationUser
            {
                Name = dto.Name,
                Email = dto.email,
                PhoneNumber = dto.PhoneNumber,
                Gender = dto.Gender,
                Dob = dto.Dob,
                Address = dto.Address,
                UserName = Guid.NewGuid().ToString()
            };

            var userstatus = await _userManager.CreateAsync(user, dto.Password);
            if (!userstatus.Succeeded)
            {
                Response.AddError("", "Failed to Add User");
                return Response;
            }
            await _userManager.AddToRoleAsync(user, "Customer");
            Response.Result = true;
            return Response;
        }
    }
}
