using EllasticCollection.Domain;

namespace ElasticCollection.Utility
{
    public class ReturnSpecs
    {

        public static string GetID()
        {
            int One = 1;
            int ID = One + One;
            return ID.ToString();
        }

        public static string Name()
        {
            foreach(var Specs in ProductDb.ProductSpec)
            {
                return Specs.Name;
            }
            return string.Empty;
        }

        public static decimal Price()
        {
            foreach (var Specs in ProductDb.ProductSpec)
            {
                return Specs.Price;
            }
            const int Zero = 0;
            return Zero;
        }

        public static long OrderCount()
        {
            foreach (var Specs in ProductDb.ProductSpec)
            {
                return Specs.OrderCount;
           }
            const long Zero = 0;
            return Zero;
        }

        public static string Categories()
        {
            foreach (var Specs in ProductDb.ProductSpec)
            {
                return Specs.Category;
            }
            return string.Empty;
        }

        public static int Quantity()
        {
            foreach (var Specs in ProductDb.ProductSpec)
            {
                return Specs.Quantity;
            }
            const int Zero = 0;
            return Zero;
        }
    }
}
