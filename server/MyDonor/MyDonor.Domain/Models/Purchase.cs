using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDonor.Domain.Models
{
    public class Purchase
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public int CustomerId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public DateTime Date { get; set; }
    }
}
