using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic_Text
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //string methods
            var myName = " Tom Ladder ";
            Console.WriteLine("Trim '{0}' ", myName.Trim());
            Console.WriteLine("ToUpper '{0}' ", myName.ToUpper().Trim());
            Console.WriteLine("ToLower '{0}' ", myName.ToLower().Trim());
            var arrayName = myName.Trim().Split(' ');
            Console.WriteLine("ArrayName : {0},{1}", arrayName[0], arrayName[1]);
            var index = myName.Trim().IndexOf(' ');
            var firstName = myName.Trim().Substring(0, index);
            var lastName = myName.Trim().Substring(index + 1);
            Console.WriteLine("f,l {0},{1}", firstName, lastName);
            var fullName = myName.Replace("Tom", "Tomonit");
            var replacedName = myName.Replace('o', '0');
            Console.WriteLine("fullName : " + fullName);
            Console.WriteLine("replacedName : " + replacedName);
            Console.WriteLine("Pls enter creditCard:\t\t\t\t(PS:We won't log it)");
            var creditCard = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(creditCard))
            {
                Console.WriteLine("Invalid card!");
            }
            //Convert int to string and vice-versa
            var input = "30";
            byte input2 = byte.Parse(input);
            byte input3 = Convert.ToByte(input);
            Console.WriteLine(input2 + " | " + input3);
            var price = 29.98f;
            var priceStr = Convert.ToString(price);
            var priceStr1 = price.ToString("C");
            Console.WriteLine(priceStr + " | " + priceStr1);

            //Summarizing text
            var text = "This is going to be a super really omega(ly) freakishly" +
                " amazingly perpetually impossiblely the longest sentence, NOT.";
            var summarizedText = StringSummarizer.Summarize(text);
            Console.WriteLine("summarizedText : " + summarizedText);
        }
    }
}
