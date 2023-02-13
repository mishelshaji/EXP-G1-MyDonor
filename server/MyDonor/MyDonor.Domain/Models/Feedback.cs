using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        [ForeignKey(nameof(Appointments))]
        public int AppointmentId { get; set; }

        public Appointments Appointments { get; set; }
    }
}
