﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models {
    public class MembershipType {
        public byte Id { get; set; }    
        public byte DiscountRate { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        [Required]
        [MaxLength(18)]
        public String Name { get; set; }    
    }
}