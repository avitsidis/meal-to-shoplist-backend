namespace MealToShopList.Models
{
    public class ShopList
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<ShopListItem> Items { get; set; } = new List<ShopListItem>();
        public ShopList()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}