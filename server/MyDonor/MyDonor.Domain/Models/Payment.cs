using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDonor.Domain.Models
{
    public  class Payment
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        [ForeignKey(nameof(Purchase))]
        public int PurchaseId { get; set; }

        public Purchase Purchase { get; set; }

        [Range(7,2)]
        public Decimal Amount { get; set; }
    }
}
