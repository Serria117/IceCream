using System;
using System.Collections.Generic;

namespace IceCream.Models.Entities
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int? UserId { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        public string? Name { get; set; }
        public string? Contact { get; set; }
        public string Email { get; set; } = null!;
        public string? Address { get; set; }
        public string? CardNo { get; set; }
        public double TotalAmount { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
