using System.Collections.Generic;

namespace eCademy.Oblig.Knockout.Models
{
    public class Database
    {
        public static List<Product> Products = new List<Product>();

        static Database()
        {
            Products.Add(new Product { Id = 1, Name = "Brave New World", Category = "Book", Price = 299 });
            Products.Add(new Product { Id = 2, Name = "Alice in Wonderland", Category = "Book", Price = 259.99m});
            Products.Add(new Product { Id = 3, Name = "Game Of Thrones", Category = "TV series", Price = 50 });
            Products.Add(new Product { Id = 4, Name = "Black Mirror", Category = "TV series", Price = 39.99m });
            Products.Add(new Product { Id = 5, Name = "Westworld", Category = "TV series", Price = 49.90m });
        }
    }
}