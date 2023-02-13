﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDonor.Domain.Models
{
    public class Appointments
    {
        public int Id { get; set; }

        [ForeignKey(nameof(BloodBank))]
        public int CenterId { get; set; }

        public BloodBank BloodBank { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public int CustomerId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }
    }

}
