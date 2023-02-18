using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MyDonor.Service.Dto;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyDonor.service.Services
{
    public class AccountsService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signinManager;
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _db;

        public AccountsService(
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

        public async Task<ServiceResponse<string>> LoginAsync(LoginDto dto)
        {
            var response = new ServiceResponse<string>();

            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user == null)
            {
                response.AddError(nameof(dto.Email), "An account with this email does not exist.");
                return response;
            }

            var signin = await _signinManager.CheckPasswordSignInAsync(user, dto.Password, true);
            if (signin.Succeeded)
            {
                response.Result = GenerateToken(user);
                return response;
            }

            // If the signin failed, generate error messages.
            if (signin.IsLockedOut)
                response.AddError("", "Account locked.");
            else if (signin.IsNotAllowed)
                response.AddError("", "You are not allowed to signin.");
            else
                response.AddError("", "Invalid email/password.");

            return response;
        }

        public async Task<ProfileViewDto> GetProfileAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return null;
            }

            return new ProfileViewDto
            {
                Name = user.Name,
                Email = user.Email,
                Phone = user.PhoneNumber,
                Adress = user.Address
            };
        }

        public async Task<ServiceResponse<ProfileEditViewDto>> GetProfileEditAsync(string id, ProfileEditDto dto)
        {
            var Result = new ServiceResponse<ProfileEditViewDto>();
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                Result.AddError("edit", "edit unsuccessfull");
                return Result;
            }
            user.Address = dto.Adress;
            user.PhoneNumber = dto.Phone;
            user.Name = dto.Name;
            
            var profile = await _userManager.UpdateAsync(user);
            if( !profile.Succeeded)
            {
                Result.AddError("user", "edit unsucessfull");
            }

            Result.Result = new ProfileEditViewDto
            {
                Name = user.Name,
                Adress= user.Address,
                Phone = user.PhoneNumber
            };
            return Result;
        }

        public async Task<ServiceResponse<ManagerCreateViewDto>> ManagerCreateAsync(ManagerCreateDto dto)
        {
            var Response = new ServiceResponse<ManagerCreateViewDto>();
            var Manager = await _userManager.FindByEmailAsync(dto.Email);
            if (Manager != null)
            {
                Response.AddError("Manager", "manger exists");
                return Response;
            }

            var ManagerUser = new ApplicationUser
            {
                UserName = Guid.NewGuid().ToString(),
                Email = dto.Email,
                DistrictId = dto.District
            };

            var res = await _userManager.CreateAsync(ManagerUser, dto.Password);
            if( !res.Succeeded)
            {
                Response.AddError("", "manager does not created");
            }

            await _userManager.AddToRoleAsync(ManagerUser, "Manager");

            var bloodBank = new BloodBank
            {
                ManagerId = ManagerUser.Id
            };
            await _db.BloodBanks.AddAsync(bloodBank);
            await _db.SaveChangesAsync();

            Response.Result = new()
            {
                Email = ManagerUser.Email
            };
            return Response;
        }

        private string GenerateToken(ApplicationUser user)
        {
            var role = _userManager.GetRolesAsync(user)
                .GetAwaiter()
                .GetResult()
                .First();

            var claims = new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Name, $"{user.Name}"),
                new Claim(ClaimTypes.Role, role),
                new Claim("userrole", role)
            };

            string issuer = _configuration["Jwt:Issuer"];
            string audience = _configuration["Jwt:Audience"];
            string key = _configuration["Jwt:Key"];

            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(signingKey, "HS256");

            var token = new JwtSecurityToken(
                issuer,
                audience,
                claims,
                expires: DateTime.Now.AddHours(12),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
