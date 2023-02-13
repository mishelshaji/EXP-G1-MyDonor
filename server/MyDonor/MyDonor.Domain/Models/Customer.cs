using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDonor.Domain.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [ForeignKey(nameof(BloodGroup))]
        public int BloodId { get; set; }
        public BloodGroup BloodGroup { get; set; }

        public DateTime Dob { get; set; }

        public Genders Gender { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
