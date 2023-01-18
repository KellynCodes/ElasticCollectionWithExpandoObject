using StringAndIntInputValidation;
using ElasticCollection.Domain;
using ElasticCollection.Enums;
using CustomMessage;
using System;

namespace ElasticCollection.Utility
{
    public class Application
    {

        public static void Start()
        {
            Console.Title = "Elastic Collection";
            GetInfo();
        }

        public static void GetInfo()
        {
            Message.Alert("Choose from the option.");
            Console.WriteLine("1.\t View all Product specifications.\n2.\t Enter product description you would like to view.");
            string input = Console.ReadLine() ?? string.Empty;
            int answer = NumberValidation.ReturnIfIsNumber(input);
            const int Zero = 0;
            if (answer > Zero)
            {
                switch (answer)
                {
                    case (int)SwitchCase.CaseOne:
                        Collection.ViewAllProductSpecs();
                        break;
                    case (int)SwitchCase.CaseTwo:
                        Collection.SelectProductSpecsToView();
                        break;
                    default:
                        Message.Error("Entered Value is not int the options. Please Try agin.");
                        break;
                }
            }
            else
            {
                Message.Error("Sorry an error occured please try again.");
                GetInfo();
            }
        }
    }
}
