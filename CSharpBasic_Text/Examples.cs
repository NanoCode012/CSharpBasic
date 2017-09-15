using System;
using System.Collections.Generic;
using System.Globalization;

namespace CSharpBasic_Text
{
    class Examples
    {
		/// <summary>
		/// Write a program and ask the user to enter a few numbers separated by 
        /// a hyphen. Work out if the numbers are consecutive. For example, if 
        /// the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: 
        /// "Consecutive"; otherwise, display "Not Consecutive".
		/// </summary>
		public void Mission1()
        {
            Console.WriteLine("Please enter consecutive numbers(seperate by hyphens) : ");
            var number = Console.ReadLine();
            var isConsecutive = ConsecutiveCheck(number);
            var text = isConsecutive ? "is" : "isn't";
			Console.WriteLine("This string {0} consecutive", text);
        }

        static bool ConsecutiveCheck(string number, char seperator = '-')
        {
            var numberArray = number.Split(seperator);
            var numberLength = numberArray.Length;
            var increment = 0;
            var decrement = 0;
            //Array.Sort(numberArray);
            for (var i = 0; i < numberLength - 1; i++)
            {
                var a = Convert.ToInt32(numberArray[i + 1]);
                var b = Convert.ToInt32(numberArray[i]);
                if (a == b + 1)//Increment
                {
                    increment++;
                    if (increment == numberLength - 1)
                    {
                        //Console.WriteLine("Consecutive Up!");
                        return true;
                    }
                }
                else if (a == b - 1)//Decrement
                {
                    decrement++;
                    if (decrement == numberLength - 1)
                    {
                        //Console.WriteLine("Consecutive Down!");
                        return true;
                    }
                }
                else
                {
                    //Console.WriteLine("No consecutive!");
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by 
        /// a hyphen. If the user simply presses Enter, without supplying an 
        /// input, exit immediately; otherwise, check to see if there are 
        /// duplicates. If so, display "Duplicate" on the console.
        /// </summary>
        public void Mission2()
        {
            Console.WriteLine("Please supply a few (duplicate) numbers(seperate by hyphen) : ");
            var input = Console.ReadLine();
            var hasDuplicate = false;
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error format");
                return;
            }
			hasDuplicate = DuplicateCheck(input);
			var text = hasDuplicate ? "has" : "doesn't have";
			Console.WriteLine("This string {0} duplicate(s)", text);
        }

        static bool DuplicateCheck(string input, char seperator = '-')
        {
            var inputArray = input.Split(seperator);
            var inputList = new List<int>();
            foreach (var number in inputArray)
            {
                if (inputList.Contains(Convert.ToInt32((number))))
                {
                    //Console.WriteLine("Duplicate exist!");
                    return true;
                }
                inputList.Add(Convert.ToInt32(number));
            }
            return false;
        }

        /// <summary>
        /// Write a program and ask the user to enter a time value in the 24-hour 
        /// time format (e.g. 19:00). A valid time should be between 00:00 and 
        /// 23:59. If the time is valid, display "Ok"; otherwise, display 
        /// "Invalid Time". If the user doesn't provide any values, consider it 
        /// as invalid time. 
        /// </summary>
        public void Mission3()
        {
            Console.WriteLine("Please type a time value(24h format hh:mm) : ");
            var input = Console.ReadLine();
			if (String.IsNullOrWhiteSpace(input))
			{
				Console.WriteLine("Error format");
				return;
			}
            var valid = TimeChecker(input);
			var text = valid ? "ok" : "incorrect";
			Console.WriteLine("This timeFormat is {0} ", text);

        }

        static bool TimeChecker(string input)
        {
            var inputArray = input.Split(':');
            if (inputArray.Length != 2)
            {
                return false;
            }
            try
            {
                var hour = Convert.ToInt32(inputArray[0]);
                var minute = Convert.ToInt32(inputArray[1]);
                if (hour > 23 || hour < 0)
                {
                    //Console.WriteLine("Error Hour");
                    return false;
                }
                if (minute > 60 || minute < 0)
                {
                    //Console.WriteLine("Error minute");
                    return false;
                }
                //Console.WriteLine("It is the {0}th hour and {1}th minute", hour, minute);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Write a program and ask the user to enter a few words separated by a 
        /// space. Use the words to create a variable name with PascalCase. For 
        /// example, if the user types: "number of students", display 
        /// "NumberOfStudents". Make sure that the program is not dependent on 
        /// the input. So, if the user types "NUMBER OF STUDENTS", the program 
        /// should still display "NumberOfStudents".
        /// </summary>
        public void Mission4()
        {
            Console.WriteLine("Please enter a few words(seperate with space) : ");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error format");
                return;
            }
            //method1
            var input2 = StringToPascalCase(input);
            Console.WriteLine("input2 : " + input2);
            //method2
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;//check MSDN for more info
            var input3 = textInfo.ToTitleCase(input).Replace(" ", "");
            Console.WriteLine("input3 : " + input3);
            //method3
            var input4 = StringToPascalCase2(input);
            Console.WriteLine("input4 : " + input4);

        }

        static string StringToPascalCase(string input)
        {
			char[] inputArray = input.ToLower().Trim().ToCharArray();
			inputArray[0] = char.ToUpper(inputArray[0]);
			for (var i = 1; i <= inputArray.Length; i++)
            {
                if (inputArray[i - 1] == ' ')
                {
                    inputArray[i] = char.ToUpper(inputArray[i]);
                }
            }
            return new string(inputArray).Replace(" ","");
        }

        static string StringToPascalCase2(string input)
		{
            var input4 = String.Empty;
			foreach (var word in input.Split(' '))
			{
				var wordCapital = char.ToUpper(word[0]) + word.ToLower().Substring(1);
				input4 += wordCapital;
			}

			return input4;
		}

        /// <summary>
        /// Write a program and ask the user to enter an English word. Count the 
        /// number of vowels (a, e, o, u, i) in the word. So, if the user enters 
        /// "inadequate", the program should display 6 on the console.
        /// </summary>
        public void Mission5()
        {
            Console.WriteLine("Please enter one word(with vowel) : ");
            var input = Console.ReadLine().ToLower();//cuz 'A' and 'a' is different
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error format");
                return;
            }
            var vowelCount = VowelCheck(input);
            Console.WriteLine("vowelCount : " + vowelCount);
        }

        static int VowelCheck(string input)
        {
            var list = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            var vowelCount = 0;
            foreach (var character in input)
            {
                if (list.Contains(character))
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
    }

}