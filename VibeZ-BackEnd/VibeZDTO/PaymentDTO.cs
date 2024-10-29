﻿using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VibeZDTO
{
    public class PaymentDTO : BaseEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Payment_method { get; set; }
        public double Amount { get; set; }

    }
}
