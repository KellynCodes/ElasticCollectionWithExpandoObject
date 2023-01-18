using System;

namespace ElasticCollection.Utility
{
    public class CheckUserChoice
    {
        public static bool IncludeSpecName()
        {
            Question.DoYouWantToInclude("Product name");
            string answer = Console.ReadLine() ?? string.Empty;
            return BoolReturn.IfStatementToReturnBooleanValue(answer);
        }

        public static bool IncludeSpecPrice()
        {
            Question.DoYouWantToInclude("Product price");
            string answer = Console.ReadLine() ?? string.Empty;
          return  BoolReturn.IfStatementToReturnBooleanValue(answer);
        }

        public static bool IncludeSpecCategories()
        {
            Question.DoYouWantToInclude("Product categories");
            string answer = Console.ReadLine() ?? string.Empty;
            return BoolReturn.IfStatementToReturnBooleanValue(answer);
        }

        public static bool IncludeSpecQuantity()
        {
            Question.DoYouWantToInclude("Product quantity");
            string answer = Console.ReadLine() ?? string.Empty;
            return BoolReturn.IfStatementToReturnBooleanValue(answer);
        }

        public static bool IncludeSpecOrderCount()
        {
            Question.DoYouWantToInclude("Product ordercount");
            string answer = Console.ReadLine() ?? string.Empty;
            return BoolReturn.IfStatementToReturnBooleanValue(answer);
        }
    }
}
