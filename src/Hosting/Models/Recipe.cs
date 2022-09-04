namespace MealToShopList.Models
{
    public class Recipe
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public Recipe(string name)
        {
            Name = name;
            CreatedAt = DateTime.UtcNow;
        }

        public string? Link { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}