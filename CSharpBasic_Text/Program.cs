using System;
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

            //StringBuilder
            var build = new StringBuilder();
            build.Append('_',10);//we can chain these because they don't return void
            build.AppendLine();
            build.Append("Title");
            build.AppendLine()//an ex. of chaining, can make it longer, no limit
                 .Append('_', 10);//do it to be more clean
            Console.WriteLine("Build : \n" + build);
            Console.WriteLine();
            build.Replace('_','-');
			Console.WriteLine("build : \n" + build);
            Console.WriteLine();
            build.Remove(0,10);
            Console.WriteLine("buildr : \n" + build);
			Console.WriteLine();
            build.Insert(0,new string('+',10),1);
            Console.WriteLine("builds : \n" + build);

            const int passLength = 8;
            var password = new StringBuilder();
            var password2 = new StringBuilder();
            var arrayPassword = new char[8];
            var random = new Random();
            for (var i = 0; i < passLength; i++)
            {
                arrayPassword[i] = (char)('a' + random.Next(0, 26));
            }
            password.Append(arrayPassword);
            for (var i = 0; i < passLength; i++)
            {
                password2.Append((char)('a' + random.Next(0,26)));
            }
            Console.WriteLine("Password : " + password);
            Console.WriteLine("Password2 : " + password2);
            foreach(var pass in arrayPassword)
            {
                Console.WriteLine("Pass : " + pass);
            }

            ///Constructor
            var examples = new Examples();
            //examples.Mission1();
            //examples.Mission2();
            //examples.Mission3();
            //examples.Mission4();
            examples.Mission5();
        }
    }
}
