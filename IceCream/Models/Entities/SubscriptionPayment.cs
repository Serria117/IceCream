using System;
using System.Collections.Generic;

namespace IceCream.Models.Entities
{
    public partial class SubscriptionPayment
    {
        public int SubscriptionPaymentId { get; set; }
        public int UserId { get; set; }
        public int SubscriptionId { get; set; }
        public DateTime Date { get; set; }

        public virtual Subscription Subscription { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
