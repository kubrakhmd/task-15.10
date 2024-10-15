using System.Globalization;
using System.Reflection.Metadata;
using System.Text;

namespace task_15._10
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // string SentenceInput = ("    EverytHing i neeD, IS a CuP of CofFee   ");
           // string SentenceOutput = (SentenceInput);
           // Console.WriteLine(ModifiedSentence(SentenceOutput));
            Product product = new Product("Apple", "Iphone13", 1000m, 700m, 10);
            product.GetInfo();
            product.Sale(5);
            product.GetInfo();
        }
        public static string ModifiedSentence(string sentence)
        {
            sentence = sentence.Trim();
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            StringBuilder result = new StringBuilder();

            string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (i > 0)
                {
                    result.Append(" "); 
                }
                result.Append(textInfo.ToTitleCase(words[i].ToLower()));
            }

            return result.ToString();

        }
    }
}
