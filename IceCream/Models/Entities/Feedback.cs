using System;
using System.Collections.Generic;

namespace IceCream.Models.Entities
{
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        public string? FeedbackDetail { get; set; }
        public int? UserId { get; set; }
        public string? Name { get; set; }
        public DateTime Date { get; set; }
        public string? Contact { get; set; }
        public string? Email { get; set; }

        public virtual User? User { get; set; }
    }
}
