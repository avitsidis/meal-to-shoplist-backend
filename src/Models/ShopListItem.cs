using System;

namespace Models
{
    public class ShopListItem
    {
        public long Id { get; set; }
        public Ingredient Ingredient { get; set; }
        public Meal Meal { get; set; }
        public ShopList ShopList { get; set; }
    }
}