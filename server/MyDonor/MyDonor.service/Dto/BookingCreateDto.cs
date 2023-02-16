
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDonor.service.Dto
{
    public class BookingCreateDto
    {
        public int Quantity { get; set; }

        public int CustomerId { get; set; }

        public int BloodId { get; set; }

    }
}
