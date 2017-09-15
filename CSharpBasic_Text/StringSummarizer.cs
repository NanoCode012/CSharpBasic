using System;
using System.Collections.Generic;

namespace CSharpBasic_Text
{
    public class StringSummarizer
    {
		public static string Summarize(string text, int maxLength = 50)
        {
            //method1
            var show_text = String.Empty;
            show_text = Summarize1(text, maxLength);
            //method2
            //show_text = Summarize2(text, maxLength);
            return show_text;
        }



        private static string Summarize1(string text, int maxLength)
        {
            string show_text = String.Empty;
            if (text.Length > maxLength)
            {
                if (text[maxLength] != ' ')
                {
					//method1_0
					//show_text = ShortenStringToLastWhitespace1(text, maxLength);
					//method1_1
					show_text = ShortenStringToLastWhitespace2(text, maxLength);
                }
            }
            else
            {
                show_text = text;
            }

            return show_text;
        }



        static string ShortenStringToLastWhitespace1(string text, int maxLength)
        {
            var lastSpace = 0;
			for (var i = 0; i < maxLength; i++)
			{
				if (text[i] == ' ')
				{
					lastSpace = i;
				}
			}
            var show_text = text.Substring(0, lastSpace);
            return show_text + "...";
        }

		static string ShortenStringToLastWhitespace2(string text, int maxLength)
		{
			string show_text = text.Substring(0, maxLength);
			show_text = text.Substring(0, show_text.LastIndexOf(' '));
			return show_text + "...";
		}

		private static string Summarize2(string text, int maxLength)
		{
			//A harsher way to do the method1
            string show_text = String.Empty;
			if (text.Length > maxLength)
			{
				var words = text.Split(' ');
				var sumCharacter = 0;
				var listWords = new List<string>();
				foreach (var word in words)
				{
					sumCharacter += word.Length + 1;//add 1 cuz of space after word
					if (sumCharacter >= maxLength)
					{
						break;
					}
					listWords.Add(word);
				}
                show_text = String.Join(" ", listWords) + "...";

			}
			else
			{
				show_text = text;
			}

			return show_text;
		}
    }
}
