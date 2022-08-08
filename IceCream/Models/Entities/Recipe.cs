using System;
using System.Collections.Generic;

namespace IceCream.Models.Entities
{
    public partial class Recipe
    {
        public int RecipeId { get; set; }
        public string? RecipeName { get; set; }
        public string? Image { get; set; }
        public string? Ingredients { get; set; }
        public string? MakingProcess { get; set; }
        public long? AdminCreateId { get; set; }
        public DateTime PublistDate { get; set; }
        public int FlavorId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long AdminUpdateId { get; set; }

        public virtual Admin? AdminCreate { get; set; }
        public virtual Flavor Flavor { get; set; } = null!;
    }
}
