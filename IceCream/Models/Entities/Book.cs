using System;
using System.Collections.Generic;

namespace IceCream.Models.Entities
{
    public partial class Book
    {
        public Book()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public double Price { get; set; }
        public DateTime CreateDate { get; set; }
        public long AdminAddId { get; set; }
        public string? Author { get; set; }
        public long? AdminUpdateId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? IsActive { get; set; }
        public int? IsDelete { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
