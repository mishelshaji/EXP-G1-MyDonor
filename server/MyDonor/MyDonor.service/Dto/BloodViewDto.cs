
namespace MyDonor.service.Dto
{
    public class BloodViewDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public BloodViewDto(BloodGroup m)
        {
            Id = m.Id;
            Name = m.Name;
        }
    }
}
