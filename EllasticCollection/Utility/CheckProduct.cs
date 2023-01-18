namespace EllasticCollection.Utility
{
    public class CheckProduct
    {
        public static bool CheckProductName(string name, string productInputName)
        {
            if (name == productInputName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
