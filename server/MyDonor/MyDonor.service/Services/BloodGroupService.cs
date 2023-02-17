namespace MyDonor.service.Services
{
    public class BloodGroupService
    {
        private readonly ApplicationDbContext _db;

        public BloodGroupService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<List<BloodViewDto>> GetBloodAsync()
        {
            return await _db.BloodGroups.Select(c => new BloodViewDto(c)).ToListAsync();
        }
    }
}
