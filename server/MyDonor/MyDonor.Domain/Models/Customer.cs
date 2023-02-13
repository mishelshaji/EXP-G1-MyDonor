using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public int BloodId { get; set; }
        public BloodGroup BloodGroup { get; set; }

        public DateTime Dob { get; set; }

        public Genders Gender { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
