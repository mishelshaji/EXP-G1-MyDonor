using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public int PurchaseId { get; set; }
        public Purchase Purchase { get; set; }

        public int AppointmentId { get; set; }

        //public Appointment Appointment { get; set; }
    }
}
