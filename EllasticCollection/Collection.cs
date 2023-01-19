using ElasticCollection.Utility;
using EllasticCollection.Domain;
using EllasticCollection.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;


namespace ElasticCollection.Domain
{
    public class Collection
    {
        //class


        //digits
        public static decimal _emptyDecimal = 0;
        public static int _emptyInt = 0;
        public static long _emptyLong = 0;

        //strings
        public static string _name = string.Empty;
        public static string _category = string.Empty;

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
          /*  if (CheckUserChoice.IncludeSpecName() && CheckUserChoice.IncludeSpecPrice() && CheckUserChoice.IncludeSpecCategories() && CheckUserChoice.IncludeSpecOrderCount() && CheckUserChoice.IncludeSpecQuantity())
            {
                ProductDb.TemporalProducts.Add(new Product(ReturnSpecs.GetID(), ReturnSpecs.Name(), ReturnSpecs.Price(), ReturnSpecs.Quantity(), ReturnSpecs.OrderCount(), ReturnSpecs.Categories()));
            }

            foreach (var Specs in ProductDb.TemporalProducts)
            {
                Console.WriteLine($"{Specs.Id} | {Specs.Name} | {Specs.Price} {Specs.Category} | {Specs.Quantity} | {Specs.OrderCount}");
                Console.WriteLine();
            }*/


            var products = new List<dynamic>();
            // Add products to the collection
            dynamic product = new ExpandoObject();
            if (CheckUserChoice.IncludeSpecName()) { product.Name = ReturnSpecs.Name(); } else { product.Name = ""; }
            if (CheckUserChoice.IncludeSpecPrice()) { product.Price = ReturnSpecs.Price(); }else { product.Price = null; }
            if (CheckUserChoice.IncludeSpecQuantity()) { product.Quantity = ReturnSpecs.Quantity(); }else { product.Quantity = null; }
            if(CheckUserChoice.IncludeSpecOrderCount()) { product.OrderCount = ReturnSpecs.OrderCount(); }else{product.OrderCount = null;}
            if(CheckUserChoice.IncludeSpecCategories()) { product.Category = ReturnSpecs.Categories(); } else { product.Category = null; }
            products.Add(product);

            // Access the properties of a product
            dynamic Specs = products[0];
            Console.WriteLine($"Name: {Specs.Name}");
            Console.WriteLine($"Price: {Specs.Price}");
            Console.WriteLine($"OrderCount: {Specs.OrderCount}");
            Console.WriteLine($"Quantity: {Specs.Quantity}");
            Console.WriteLine($"Category: {Specs.Category}");
        }
    }
}
