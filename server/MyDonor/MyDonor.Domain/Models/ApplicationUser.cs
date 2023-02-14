
namespace MyDonor.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Id { get; set; }

        public Customer? Customer { get; set; }
    }
}
