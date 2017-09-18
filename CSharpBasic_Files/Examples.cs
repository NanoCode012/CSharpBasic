using System;
using System.IO;
namespace CSharpBasic_Files
{
    public class Examples
    {
		/// <summary>
		/// Write a program that reads a text file and displays the number of 
        /// words.
		/// </summary>
		public void Mission1()
        {
            var path = @"/Users/kevinvong/Desktop/Visual Studio/CSharpBasic/CSharpBasic_Files/myTextFile2.txt";
            Console.WriteLine("There is {0} words ", ArrayFromTextFile(path).Length);
        }

		/// <summary>
		/// Write a program that reads a text file and displays the longest word 
        /// in the file.
		/// </summary>
		public void Mission2()
        {
            var path = @"/Users/kevinvong/Desktop/Visual Studio/CSharpBasic/CSharpBasic_Files/myTextFile2.txt";
            var longestWord = "";
            foreach (var word in ArrayFromTextFile(path))
            {
                if (longestWord.Length < word.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine("The longest word,{0}, is {1} characters", longestWord
                              , longestWord.Length);
        }

        string[] ArrayFromTextFile(string path)
        {
			var sentence = File.ReadAllText(path);
			var splitSentence = sentence.Split(' ');
            return splitSentence;
        }
    }
}
