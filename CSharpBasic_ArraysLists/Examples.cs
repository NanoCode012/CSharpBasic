using System;
using System.Collections.Generic;
using System.Linq;
namespace CSharpBasic_ArraysLists
{
    class Examples
    {
        /// <summary>
        /// Write a program and continuously ask the user to enter different 
        /// names, until the user presses Enter (without supplying a name). 
        /// Depending on the number of names provided, display a message based 
        /// on the FB pattern. If no one likes post, you receive no message. If 
        /// you do, your message varries.
        /// </summary>
        public void Mission1()
        {
            var fbNameList = new List<string>();
            while (true)
            {
                Console.WriteLine("Please enter name(s) : ");
                var input = Console.ReadLine();
                if (input == String.Empty)
                {
                    break;
                }
                fbNameList.Add(input);
            }
            switch (fbNameList.Count)//Can be optimized, but use switch to be familiar
            {
                case 0:
                    Console.WriteLine("No one liked your post. Check again later.");
                    break;
                case 1:
                    Console.WriteLine(fbNameList[0] + " likes your post.");
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} like your post.", fbNameList[0], fbNameList[1]);
                    break;
            }
            if (fbNameList.Count > 2)
            {
                Console.WriteLine("{0},{1} and {2} other people like your post.",
                                  fbNameList[0], fbNameList[1], fbNameList.Count - 2);
            }
        }

        /// <summary>
        /// Write a program and ask the user to enter their name. Use an array 
        /// to reverse the name and then store the result in a new string. Display 
        /// the reversed name on the console.
        /// </summary>
        public void Mission2()
        {
            Console.WriteLine("Please enter YOUR name : ");
            var input2 = Console.ReadLine();
			//method1
			var reverseArray = new string[input2.Length];
            var count = 0;
            foreach (var character in input2)
            {
                reverseArray[count] = character.ToString();
                count++;
            }
            Array.Reverse(reverseArray);
            var reverseString = String.Join("", reverseArray);
			Console.WriteLine("Here's your name in reverse : " + reverseString.ToLower());
			//method2
			var reverseArray2 = new char[input2.Length];
            for (var i = input2.Length; i > 0; i--)
            {
                reverseArray2[input2.Length - i] = input2[i - 1];
                //Manually reversing values between two arrays
                //reverse# goes up, input# goes down
            }
            var reverseString2 = new string(reverseArray2);
            Console.WriteLine("Your reversed name : " + reverseString2);
        }

		/// <summary>
		/// Write a program and ask the user to enter 5 numbers. If a number has 
        /// been previously entered, display an error message and ask the user 
        /// to re-try. Once the user successfully enters 5 unique numbers, sort 
        /// them and display the result on the console.
		/// </summary>
		public void Mission3()
        {
            Console.WriteLine("Please input 5 numbers : ");
			//method1
            var arrayNumbers = new int[5];//using array to accomplish task
            var listNumbers = new List<int>(5);//using string to accomplish task
			for (var i = 0; i < 5; i++)
            {
                var input3 = Convert.ToInt32(Console.ReadLine());
                var a = Array.IndexOf(arrayNumbers, input3);
				//careful VS doesn't warn when comparing str and int in IndexOf of arrays
                var b = listNumbers.IndexOf(input3);
                if (a == -1 && b == -1)//can simplify by removing b condition
                {

                    arrayNumbers[i] = input3;
                    listNumbers.Add(input3);
                }
                else if (a != -1 && b != -1) 
                {
                    Console.WriteLine("Error, number already entered before, "
                                         + "please choose another.");
                    i--;
                    continue;
                }
            }
			Array.Sort(arrayNumbers);
			Console.WriteLine("Sorted array");
			foreach (var number in arrayNumbers)
			{
				Console.WriteLine(number);            
			}
			listNumbers.Sort();
			Console.WriteLine("Sorted list");
			foreach (var number in listNumbers)
			{
				Console.WriteLine(number);
			}
			//method2
			var listNumbers2 = new List<int>();
            while (listNumbers2.Count < 5)
            {
                Console.WriteLine("Please input {0}th number : ", (listNumbers2.Count + 1));
                var input4 = Convert.ToInt32(Console.ReadLine());
                if (listNumbers2.Contains(input4))
                {
                    Console.WriteLine("Sorry, number already inputted. Try another one.");
                }else
                {
                    listNumbers2.Add(input4);
                }
            }
            listNumbers2.Sort();
			foreach (var number in listNumbers2)
			{
				Console.WriteLine(number);
			}
        }

		/// <summary>
		/// Write a program and ask the user to continuously enter a number or 
        /// type "Quit" to exit. The list of numbers may include duplicates. 
        /// Display the unique numbers that the user has entered.
		/// </summary>
		public void Mission4()
        {
            var listNumbers3 = new List<int>();
            while(true)
            {
				Console.WriteLine("Type in number(quit to exit) : ");
                var input5 = Console.ReadLine();
				if (input5.ToLower() == "quit")
				{
					break;
				}
                listNumbers3.Add(Convert.ToInt32(input5));
            }
            var countIndex = 0;//method1
            var listNumbersUnique = new List<int>();
			foreach(var number in listNumbers3)
            {
                if (listNumbers3.IndexOf(number) == countIndex)
                    //This is a sneaky bypass, takes advantage of IndexOf only
                    //registering the first of any one unique number
                {
                    Console.WriteLine("Unique number via method 1 : " + number);
                }
                countIndex++;
                if (!listNumbersUnique.Contains(number))
                {
                    listNumbersUnique.Add(number);
                }
            }
            foreach(var number in listNumbersUnique)
            {
                Console.WriteLine("Unique number via method 2 : " + number);
            }
        }

		/// <summary>
		/// Write a program and ask the user to supply a list of comma separated 
        /// numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less 
        /// than 5 numbers, display "Invalid List" and ask the user to re-try; 
        /// otherwise, display the 3 smallest numbers in the list.
		/// </summary>
		public void Mission5()
        {
            /*This works but I don't understand it fully
            while (true)
            {
				Console.WriteLine("Please input a line of at least 5 numbers(comma to seperate) : ");
				var lineString = Console.ReadLine();
                List<string> lineList = (lineString.Split(',').ToList());
                List<int> lineListInteger = lineList.Select(s => int.Parse(s)).ToList();//List<string> to List<int>
                //I basically copied/pasted the line above. No idea :D
                //assume they split by comma, ToList converts from array to list
                if (lineList.Count < 5)
				{
					Console.WriteLine("Invalid list. Need at least 5 values!");
                    continue;
				}
                var lineListInteger2 = new List<int>(lineList.Count);
                //for (var i = 0; i < lineList.Count; i++)
                //{
                //    int a = 0;
                //    int.TryParse(lineList[i],out a);
                //    lineListInteger2 = a.ToList();
                //}

				lineListInteger.Sort();//method1
                Console.WriteLine("The smallest three numbers are {0}, {1}, and {2}.",
                                  lineListInteger[0],lineListInteger[1],lineListInteger[2]);
                lineListInteger2.Sort();//method2
				//Console.WriteLine("The smallest three numbers are {0}, {1}, and {2}.",
								  //lineListInteger2[0], lineListInteger2[1], lineListInteger2[2]);
                break;
            }
            */
            while (true)
            {
                Console.WriteLine("Please input a line of at least 5 numbers(comma to seperate) : ");
                var lineString = Console.ReadLine();
                var characterToSkip = new char[] { ',', ' ' };
                var lineArray = lineString.Split(characterToSkip, StringSplitOptions.RemoveEmptyEntries);
                if (lineArray.Length < 5)
                {
                    Console.WriteLine("Not enough entries!");
                    continue;
                }
                Array.Sort(lineArray);
                Console.WriteLine("The three smallest numbers are {0}, {1}, and {2}",
                                  lineArray[0], lineArray[1], lineArray[2]);
                break;

            }


        }
    }

}
