using CustomMessage;

namespace ElasticCollection.Utility
{
    public class Question
    {
      public static void DoYouWantToInclude(string value)
        {
            Message.Alert($"Do you want to include {value}.? Choose [YES/NO].");
        }
    }
}
