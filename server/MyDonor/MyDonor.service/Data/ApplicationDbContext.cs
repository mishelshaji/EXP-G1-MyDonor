
namespace MyDonor.service.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<BloodGroup> BloodGroups { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
