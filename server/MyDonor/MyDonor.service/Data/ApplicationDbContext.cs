
namespace MyDonor.service.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<BloodGroup> BloodGroups { get; set; }
    }
}
