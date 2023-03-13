using System.Text.RegularExpressions;

namespace Methods

{
    internal class Class1
    {
        public static void WriteString(string parsedSymbol, int parsedCount)
        {

            for (int i = 0; i < parsedCount; i++)
            {
                Console.Write(parsedSymbol);
            }

        }
        public static void FindIndex(int[] myArray, int Element)
        {

            for (int i = 0; i < myArray.Length; i++)
            {
                if (Element == myArray[i])
                { Console.WriteLine("Индекс элемента в массиве = " + i); }

            }


        }
        public static void Resize(ref int[] myArray, int numOfElements)

        {
            int[] array = new int[numOfElements];

            if (array.Length <= myArray.Length)
            {





                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = myArray[i];
                }

                myArray = array;
            }
            else
            {

                myArray = array;


            }
        }
        public static async Task WriteAsync(string[] lines)
        {

            {
                await File.WriteAllLinesAsync("unicredit.tsv", lines, System.Text.Encoding.UTF8);

            }
        }
        public static string[] ReadFile()
        {

            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                return File.ReadAllLines("unicredit.txt", System.Text.Encoding.GetEncoding("windows-1251"));

            }

        }

        public static string[] ParseString(string line, int numOfElements)
        {

            {
                string[] array = new string[numOfElements];
                string s = null;

                for (int i = 1, j = 0; i < line.Length; i++)
                {


                    if (line[i].ToString() == "#")
                    {
                        array[j] = s;
                        s = null;
                        j++;
                    }
                    else
                    {
                        s = s + line[i].ToString();

                    }


                }

                return array;
            }
        }
        public static string ConvertDate(string qadDate)

        {
            if (qadDate != null)
            {

                return qadDate.Substring(6, 2) + "." + qadDate.Substring(4, 2) + "." + qadDate.Substring(0, 4);
            }
            return "";
        }
        public static string ConvertCurrency(string qadCurrency)
        {
            if (qadCurrency != null)
            {
                return "rubPayment";
            }


            return "";

        }
        public static string ConvertPaymentMethod(string PaymentMethod)
        {
            if (PaymentMethod != null)
            {
                return "Электронно";
            }
            return "";

        }
        public static string ConvertTaxNum(string qadTaxNum)

        {
            if (qadTaxNum != null)
            {
                return "5256029449";
            }
            return "";

        }
        public static string ConvertLearAccount(string qadLearAccount)

        {
            if (qadLearAccount == "014609662")
            {
                return "40702810800014609662";
            }
            else if (qadLearAccount == "454847026")
            {
                return "40702810100454847026";
            }
            return "";

        }
        public static string ClearNonUTF8(string nonUTF8String)
        {

            return Regex.Replace(nonUTF8String, @"[\u00A0\u2007\u202F\u2060\u00ab]+", string.Empty);
      
        }
    }
}

