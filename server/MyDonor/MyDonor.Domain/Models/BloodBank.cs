using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDonor.Domain.Models
{
    public class BloodBank
    {
        public int Id { get; set; }

        [StringLength(25)]
        public string District { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public int ManagerId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
