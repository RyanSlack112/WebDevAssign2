namespace WebDevAssign2.Migrations
{
    using Models;
    using System.Collections.Generic;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebDevAssign2.OSDB.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebDevAssign2.OSDB.StoreContext context)
        {
            //Categories
            var categories = new List<Category>
           {
               new Category{Name = "Playstation 4"},
               new Category{Name = "Xbox One"},
               new Category{Name = "Nintendo Switch"},
               new Category{Name = "PC Games"},
               new Category{Name = "Playstation 3"},
               new Category{Name = "Xbox 360"},
               new Category{Name = "Nintendo 3DS"}
           };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            //Products
            var products = new List<Product>
            {
                new Product{Name = "Playstation 4 Pro Console", Description = "Sony's Flagship Console", Price = 598, CategoryID = categories.Single(c=>c.Name == "Playstation 4").ID},
                new Product{Name = "Xbox One X Console", Description = "Microsoft's Flagship Console", Price = 698, CategoryID = categories.Single(c=>c.Name == "Xbox One").ID},
                new Product{Name = "Nintendo Switch Console", Description = "Nintendo's Flagship Console", Price = 549, CategoryID = categories.Single(c=>c.Name == "Nintendo Switch").ID},
                new Product{Name = "High End Gaming PC", Description = "Custom Built Gaming PC", Price = 3500, CategoryID = categories.Single(c=>c.Name == "PC Games").ID},
                new Product{Name = "Playstation 3 Console", Description = "Sony's Last Gen Console", Price = 198, CategoryID = categories.Single(c=>c.Name == "Playstation 3").ID},
                new Product{Name = "Nintendo 3DS Console", Description = "Nintendo's Last Generation Portable Console", Price = 98, CategoryID = categories.Single(c=>c.Name == "Nintendo 3DS").ID},
                new Product{Name = "Xbox 360 Console", Description = "Microsoft's Last Gen Console", Price = 98, CategoryID = categories.Single(c=>c.Name == "Xbox 360").ID}
            };
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
        }
    }
}
