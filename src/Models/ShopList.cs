using System;
using System.Collections;

namespace Models
{
    public class ShopList
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<ShopListItem> Items { get; set; }
    }
}