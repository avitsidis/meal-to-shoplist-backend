using System.Reflection.Metadata;

using MealToShopList.Models;

using Microsoft.EntityFrameworkCore;

namespace MealToShopList.Data
{
    public class MealToShopListDbContext : DbContext
    {
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<ShopList> ShopLists { get; set; }
        public DbSet<WeeklyMenu> Menus { get; set; }

        public MealToShopListDbContext(DbContextOptions<MealToShopListDbContext> context)
            : base(context)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
