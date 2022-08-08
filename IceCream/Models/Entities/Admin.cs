using System;
using System.Collections.Generic;

namespace IceCream.Models.Entities
{
    public partial class Admin
    {
        public Admin()
        {
            Recipes = new HashSet<Recipe>();
        }

        public long AdminId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int? Roles { get; set; }
        public string? Password { get; set; }
        public int? IsActive { get; set; }
        public int? IsDelete { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
