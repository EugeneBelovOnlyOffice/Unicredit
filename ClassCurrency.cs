using System;
namespace Methods
{

    internal class ClassCurrency
    {
        public static string ConvertLearAccount(string qadLearAccount)
        {
            if (qadLearAccount == "010004882")
            {
                return "40702978820010004882";
            }
            else if (qadLearAccount == "010004783")
            {
                return "40702840620010004783";
            }
            return "";

        }


        public static string ConvertChargeLearAccount()

        {
         
            return "40702810800014609662";

        }

        public static string ConvertCurrency(string qadCurrency)
        {
            if (qadCurrency != null)
            {
                return "curPayment";
            }


            return "";

        }
    }
}