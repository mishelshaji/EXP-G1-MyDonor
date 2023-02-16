
namespace MyDonor.service.Dto
{
    public class RegistrationCreateDto
    {
        public string Name { get; set; }
        public string email { get; set; }
        public string District { get; set; }

        public string PhoneNumber { get; set; }
        public DateTime Dob { get; set; }
        public Genders Gender { get; set; }
        public string Password { get; set; }

        public string Address { get; set; }
    }
}
