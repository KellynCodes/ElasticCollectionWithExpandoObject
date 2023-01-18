namespace EllasticCollection.Models
{
        public class Product
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; private set; }
            public int Quantity { get; set; }
            public long OrderCount { get; set; }
            public string Category { get; set; }

            public Product(string id, string name, decimal price, int quantity, long orderCount, string category)
            {
                Id = id;
                Name = name;
                Price = price;
                Quantity = quantity;
                Category = category;
                OrderCount = orderCount;
            }
        }
}
