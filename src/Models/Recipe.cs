using System;
using System.Collections;

namespace Models
{
    public class Recipe
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}