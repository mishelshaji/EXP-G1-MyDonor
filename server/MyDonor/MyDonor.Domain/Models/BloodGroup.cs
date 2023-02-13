using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDonor.Domain.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class BloodGroup
    {
        public int Id { get; set; }

        [StringLength(3)]
        public string Name { get; set; }
    }
}
