using System;

namespace MealToShopList.Models
{
    public class Ingredient
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public Ingredient(string name, Category category)
        {
            Name = name;
            Category = category;
            CreatedAt = DateTime.UtcNow;
            Recipes = new List<Recipe>();
        }

        public Category Category { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<Recipe> Recipes { get; set; }

    }
}