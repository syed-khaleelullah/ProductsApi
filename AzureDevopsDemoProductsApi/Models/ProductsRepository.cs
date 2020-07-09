using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureDevopsDemoProductsApi.Models
{
    public class ProductsRepository
    {
        static List<Product> products;
        static ProductsRepository()
        {
            products = new List<Product>();
            products.Add(new Product
            {
                ID = 101,
                Name = "Dell Inspiron 13",
                Description = "13 Inches with touch screen laptop",
                Price = 100000
            });
            products.Add(new Product
            {
                ID = 102,
                Name = "Mac Book Pro",
                Description = "13 Inches MacBook with i9 Processor",
                Price = 200000
            });
        }

        public IEnumerable<Product> GetAll()
        {
            return products.ToList();
        }
        public Product Get(int productId)
        {
            return products.Find(p => p.ID == productId);
        }
    }
}
