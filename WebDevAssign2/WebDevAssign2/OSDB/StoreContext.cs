using System.Data.Entity;
using WebDevAssign2.Models;

namespace WebDevAssign2.OSDB
{
    public class StoreContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}