using System;

namespace Models
{
    public class Ingredient
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}