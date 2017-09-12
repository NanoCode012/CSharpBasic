using System;
using System.Collections.Generic;

namespace CSharpBasic_Text
{
    public class StringSummarizer
    {
		public static string Summarize(string text, int maxLength = 50)
		{
			//method1
			//var lastSpace = 0;
			var show_text = String.Empty;
			if (text.Length > maxLength)
			{
				if (text[maxLength] == ' ')
				{
					show_text = text.Substring(0, maxLength);
					//Console.WriteLine("ShowText : " + show_text + "...");
				}
				else
				{
					//This works too. It is basically the same as LastIndexOf
					//This code if code block can be shortened, but kept for
					//self others to understand the code
					//method1_0
					/*for (var i = 0; i < maxLength; i++)
					{
						if(text[i] == ' ')
						{
							lastSpace = i;
						}
					}*/
					//var show_text = text.Substring(0, lastSpace);
					//method1_2
					show_text = text.Substring(0, maxLength);
					show_text = text.Substring(0, show_text.LastIndexOf(' '));
					//Console.WriteLine("show_text : " + show_text + "...");
				}
			}
			else
			{
				show_text = text;
				Console.WriteLine("show_text : " + show_text);
			}
			//method2
			//A harsher way to do the method above
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
						Console.WriteLine("word is where is cuts : " + word);
						break;
					}
					listWords.Add(word);
				}
				show_text = String.Join(" ", listWords) + "...";

			}
			else
			{
				Console.WriteLine("text : " + text);
			}
			return show_text;
		}
    }
}
