
namespace MyDonor.Domain.Models
{
    public class BloodBank
    {
        public int Id { get; set; }

        [StringLength(25)]
        public string District { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public int ManagerId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
