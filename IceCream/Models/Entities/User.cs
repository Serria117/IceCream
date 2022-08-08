using System;
using System.Collections.Generic;

namespace IceCream.Models.Entities
{
    public partial class User
    {
        public User()
        {
            Feedbacks = new HashSet<Feedback>();
            Orders = new HashSet<Order>();
            SubscriptionPayments = new HashSet<SubscriptionPayment>();
        }

        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? Contact { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Password { get; set; }
        public int UserType { get; set; }
        public string? CardNo { get; set; }
        public DateTime JoinDate { get; set; }
        public int IsActive { get; set; }
        public int IsDelete { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<SubscriptionPayment> SubscriptionPayments { get; set; }
    }
}
