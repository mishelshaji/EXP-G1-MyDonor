
namespace MyDonor.service.Dto
{
    public class BookingViewDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public int CustomerId { get; set; }

        public DateTime Date { get; set; }

        public int BloodId { get; set; }

    }
}
