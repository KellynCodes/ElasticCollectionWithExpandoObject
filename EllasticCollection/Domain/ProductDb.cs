using EllasticCollection.Models;
using System.Collections.Generic;

namespace EllasticCollection.Domain
{
    public class ProductDb
    {
        public static IList<Product> ProductSpec { get; } = new List<Product>()
        {
            new Product(id: "1", name: "Dell Xp 20540", price: 1000000.00m, quantity: 2, orderCount: 4, category: "Fairly used." ),
            new Product(id: "2", name: "Hp 2050", price: 50000.00m, quantity: 1, orderCount: 2, category: "Fairly used." ),
        };

        public static IList<dynamic> DynamicProducts { get; set; } = new List<dynamic>();
    }
}
