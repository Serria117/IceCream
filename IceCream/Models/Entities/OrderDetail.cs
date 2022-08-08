﻿using System;
using System.Collections.Generic;

namespace IceCream.Models.Entities
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public virtual Book Book { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
