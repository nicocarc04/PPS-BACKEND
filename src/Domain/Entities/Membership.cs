﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Membership
    {
        [Required]
        public string? Type { get; set; }
        [Required]
        public double? Price { get; set; }
        [Required]
        public string? Description { get; set; }
    }
}
