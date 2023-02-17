
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

        public async Task<ServiceResponse<RegisterViewDto>> CreateAsync(RegistrationCreateDto dto)
        {
            var Response = new ServiceResponse<RegisterViewDto>();
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
                PhoneNumber = dto.Phone,
                Gender = dto.Gender,
                Dob = dto.Dob,
                Address = dto.Address,
                DistrictId = dto.District,
                BloodId= dto.BloodId,
                UserName = Guid.NewGuid().ToString()
            };

            var userstatus = await _userManager.CreateAsync(user, dto.Password);
            if (!userstatus.Succeeded)
            {
                Response.AddError("", "Failed to Add User");
                return Response;
            }
            await _userManager.AddToRoleAsync(user, "Customer");
            Response.Result = new RegisterViewDto
            {
                Id=user.UserName,
                Name= dto.Name,
                Email= dto.email,
            };
            return Response;
        }
    }
}
