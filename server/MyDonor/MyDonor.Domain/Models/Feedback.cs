
namespace MyDonor.Domain.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string Content { get; set; }

        [ForeignKey(nameof(Purchase))]
        public int PurchaseId { get; set; }
        public Purchase Purchase { get; set; }

        [ForeignKey(nameof(Appointment))]
        public int AppointmentId { get; set; }

        public Appointment Appointment { get; set; }
    }
}
