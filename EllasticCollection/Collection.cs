using ElasticCollection.Utility;
using EllasticCollection.Domain;
using System;
using System.Dynamic;


namespace ElasticCollection.Domain
{
    public class Collection
    {
        public static void ViewAllProductSpecs()
        {
            foreach (var Specs in ProductDb.ProductSpec)
            {
                Console.WriteLine($"{Specs.Id} | {Specs.Name} | {Specs.Price} {Specs.Category} | {Specs.Quantity} | {Specs.OrderCount}");
                Console.WriteLine();
                Application.GetInfo();
            }
        }
        public static void SelectProductSpecsToView()
        {
            // Add products to the collection
            dynamic product = new ExpandoObject();
            if (CheckUserChoice.IncludeSpecName()) { product.Name = ReturnSpecs.Name(); } else { product.Name = ""; }
            if (CheckUserChoice.IncludeSpecPrice()) { product.Price = ReturnSpecs.Price(); }else { product.Price = null; }
            if (CheckUserChoice.IncludeSpecQuantity()) { product.Quantity = ReturnSpecs.Quantity(); }else { product.Quantity = null; }
            if(CheckUserChoice.IncludeSpecOrderCount()) { product.OrderCount = ReturnSpecs.OrderCount(); }else{product.OrderCount = null;}
            if(CheckUserChoice.IncludeSpecCategories()) { product.Category = ReturnSpecs.Categories(); } else { product.Category = null; }
            ProductDb.DynamicProducts.Add(product);

            // Access the properties of a product
            dynamic Specs = ProductDb.DynamicProducts[0];
            Console.WriteLine($"Name: {Specs.Name}");
            Console.WriteLine($"Price: {Specs.Price}");
            Console.WriteLine($"OrderCount: {Specs.OrderCount}");
            Console.WriteLine($"Quantity: {Specs.Quantity}");
            Console.WriteLine($"Category: {Specs.Category}");
        }
    }
}
