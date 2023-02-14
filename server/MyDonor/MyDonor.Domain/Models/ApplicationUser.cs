
namespace MyDonor.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
