
namespace MyDonor.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        public Customer? Customer { get; set; }
    }
}
